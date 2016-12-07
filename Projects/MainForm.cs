using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Projects
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string _projectDir = "";
        string _exeDir = "";
        string _mode = "";

        bool _isHidden = false;
        TreeNode _currentNode = new TreeNode();

        List<string> _dirIgnoreList = new List<string>
        {
            ".git",
            ".svn",
            "node_modules"
        };


        private bool ConfigExists()
        {
            _exeDir = Environment.CurrentDirectory;

            if (File.Exists(_exeDir + "\\config.cfg"))
                return true;
            else
                return false;
        }

        private void SetPosition()
        {
            Size resolution = SystemInformation.PrimaryMonitorSize;

            this.Location = new Point
            {
                X = resolution.Width - this.Width,
                Y = 0
            };

            this.Height = resolution.Height - 30;
        }

        private void ReadConfiguration()
        {
            int FormWidth, FormHeight;

            using (XmlReader reader = XmlReader.Create("configuration.xml"))
            {
                reader.Read();
                reader.ReadStartElement("settings");
                reader.ReadStartElement("size");
                reader.ReadStartElement("remember_size");
                if (reader.ReadString() == "true")
                {
                    reader.ReadEndElement();
                    reader.ReadStartElement("width");
                    FormWidth = Convert.ToInt32(reader.ReadString());
                    reader.ReadEndElement();
                    reader.ReadStartElement("height");
                    FormHeight = Convert.ToInt32(reader.ReadString());
                    reader.ReadEndElement();
                    reader.ReadEndElement();
                    SetSize(FormWidth, FormHeight);
                }
            }
        }

        private void SetSize(int width, int height)
        {
            Size newSize = new Size();
            newSize.Height = height;
            newSize.Width = width;

            this.Size = newSize;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            helpPanel.Visible = false;

            if (File.Exists("configuration.xml") == true)
                ReadConfiguration();

            SetPosition();

            bool configFile = ConfigExists();

            if (configFile == true)
                GetExistingDir();

            else
            {
                GetNewDir();
                GetSolutions();
            }
        }

        private void GetSolutions()
        {

            if (_mode == "OVERWRITE")
            {
                projectTreeView.Nodes.Clear();
            }
            
            ArrayList nodes = new ArrayList();

            if (_projectDir == "")
                return;

            DirectoryInfo di = new DirectoryInfo(_projectDir);
            FileInfo[] fi = GetFiles(di);

            if (fi.Length == 0)
            {
                TreeNode tn = new TreeNode("No Solutions");
                nodes.Add(tn);
            }

            else
            {
                string[] files = new string[fi.Length];
                string[] fileDirs = new string[fi.Length];
                for (int i = 0; i < fi.Length; i++)
                {
                    files[i] = fi[i].ToString();
                    fileDirs[i] = fi[i].DirectoryName.ToString().Trim();
                }

                for (int i = 0; i < fi.Length; i++)
                {
                    TreeNode tn = new TreeNode(files[i].Substring(0, files[i].Length - 4));
                    tn.Tag = fileDirs[i];
                    tn.ForeColor = Color.DarkBlue;
                    nodes.Add(tn);
                }
            }

            TreeNode dir = new TreeNode("Project Dir");
            dir.ForeColor = Color.OrangeRed;
            nodes.Add(dir);

            TreeNode newPrj = new TreeNode("Start a new project");
            newPrj.ForeColor = Color.Green;
            nodes.Add(newPrj);

            TreeNode[] tns = new TreeNode[nodes.Count];

            nodes.CopyTo(tns);

            TreeNode topN = new TreeNode("My Projects - " + di.Name, tns);
            topN.ForeColor = Color.MidnightBlue;
            topN.Tag = _projectDir;
            projectTreeView.Nodes.Add(topN);
        }

        private FileInfo[] GetFiles(DirectoryInfo di)
        {
            if (_dirIgnoreList.Contains(di.Name))
                return new List<FileInfo>().ToArray();

            var solutions = new List<FileInfo>();

            foreach (var f in di.GetFiles())
            {
                if (f.Name.Contains(".sln"))
                    solutions.Add(f);
            }

            foreach (var d in di.GetDirectories())
                solutions.AddRange(GetFiles(d));

            return solutions.ToArray();
        }

        private void GetExistingDir()
        {
            StreamReader sr = new StreamReader(_exeDir + "\\config.cfg");
            while (true)
            {
                _projectDir = sr.ReadLine();
                if (_projectDir == null)
                    break;
                else
                    GetSolutions();
            }
            sr.Close();
        }

        private void GetNewDir()
        {
            Config cfg = new Config();
            cfg.ExeDir = _exeDir;
            if (_mode == "ADD")
                cfg.Mode = "ADD";
            else
                cfg.Mode = "OVERWRITE";
            cfg.ShowDialog();
            _projectDir = cfg.ProjectDir;
        }

        private int DelDir(string dirToDel)
        {
            int projectCounts = 0;

            StreamReader sr = new StreamReader(_exeDir + "\\config.cfg");
            StreamWriter sw = new StreamWriter(_exeDir + "\\config.tmp");
            while (true)
            {
                _projectDir = sr.ReadLine();
                if (_projectDir != dirToDel && _projectDir != null)
                {
                    sw.WriteLine(_projectDir);
                    projectCounts++;
                }
                else if (_projectDir == null)
                    break;
            }
            sw.Close();
            sr.Close();

            File.Delete(_exeDir + "\\config.cfg");
            File.Move(_exeDir + "\\config.tmp", _exeDir + "\\config.cfg");

            FileInfo fi = new FileInfo(_exeDir + "\\config.cfg");
            if (fi.Length == 0)
                File.Delete(_exeDir + "\\config.cfg");

            return projectCounts;
        }

        private void projectTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (e.Node.Text == "Project Dir")
            {
                Process explorer = new Process();
                explorer.StartInfo.FileName = Environment.GetEnvironmentVariable("WINDIR") + "\\explorer.exe";
                explorer.StartInfo.Arguments = e.Node.Parent.Tag.ToString();
                explorer.Start();
                explorer.Close();
                //this.Close();
            }

             if (e.Node.Text.Contains("My Projects - ") == true)
            {
                this.Cursor = Cursors.Arrow;
                return;
            }

            else if (e.Node.Text == "Start a new project")
            {
                Process newvs = new Process();
                newvs.StartInfo.FileName = @"C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe";
                newvs.Start();
                newvs.Close();
                //this.Close();
            }

            else
            {
                Process vs = new Process();
                vs.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                vs.StartInfo.CreateNoWindow = true;
                vs.StartInfo.FileName = Environment.GetEnvironmentVariable("WINDIR") + "\\system32\\cmd";
                vs.StartInfo.Arguments = " /c \""+e.Node.Tag+"\\"+e.Node.Text+".sln\"";
                vs.Start();
                while (!vs.HasExited)
                {

                }
                vs.Close();
                //this.Close();
            }
        }



        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mode = "ADD";
            GetNewDir();
            GetSolutions();
        }

        private void removeSelectedProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count;
            this.Cursor = Cursors.WaitCursor;

            TreeNode toDel = projectTreeView.SelectedNode.Parent;
            if (toDel == null)
                toDel = projectTreeView.SelectedNode;
            count = DelDir(toDel.Tag.ToString());
            toDel.Remove();

            if (count == 0)
            {
                this.Cursor = Cursors.Arrow;
                return;
            }

            else
            {
                projectTreeView.Nodes.Clear();
                GetExistingDir();
            }

            this.Cursor = Cursors.Arrow;
        }

        private void overwriteExistingProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mode = "OVERWRITE";
            GetNewDir();
            GetSolutions();
        }

        private void projectTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _currentNode = e.Node;
            projectTreeView.SelectedNode = e.Node;
        }

        private void projectTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            bool OtherProjectsOpen = false;

            for (int i = 0; i < projectTreeView.Nodes.Count; i++)
            {
                if (projectTreeView.Nodes[i].IsExpanded == true)
                {
                    OtherProjectsOpen = true;
                    break;
                }
            }

            if (OtherProjectsOpen == true)
                projectTreeView.ContextMenuStrip = runContextMenuStrip;
            else
                projectTreeView.ContextMenuStrip = rightClickContextMenuStrip;
        }

        private void projectTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            projectTreeView.ContextMenuStrip = runContextMenuStrip;
        }

        private void runProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //currentNode = projectTreeView.SelectedNode;
            RunOperation();
        }

        private void RunOperation()
        {
            if (_currentNode.Text.Contains("My Projects - ") == true || _currentNode.Text == "Project Dir" || _currentNode.Text == "Start a new project" || _currentNode.Text == "No Solutions")
            {
                return;
            }

            else
            {
                int count = 0;
                string exeFile = "";
                string workDir = "";
                ArrayList Programs = new ArrayList();
                ArrayList Directories = new ArrayList();

                DirectoryInfo di = new DirectoryInfo(_currentNode.Tag.ToString());
                FileInfo[] fi = di.GetFiles("*.exe", SearchOption.AllDirectories);

                foreach (FileInfo f in fi)
                {
                    if (f.DirectoryName.Contains("obj") == true || f.Name.Contains("vshost") == true)
                        count++;
                }

                if (fi.Length - count == 1)
                {
                    foreach (FileInfo f in fi)
                    {
                        if (f.DirectoryName.Contains("obj") == true || f.Name.Contains("vshost") == true)
                            continue;
                        else
                        {
                            exeFile = f.DirectoryName + "\\" + f.Name;
                            _currentNode.Tag = f.DirectoryName;
                        }
                    }

                    workDir = _currentNode.Tag.ToString();
                }

                else if (fi.Length - count != 0)
                {
                    count = 0;

                    foreach (FileInfo f in fi)
                    {
                        if (f.DirectoryName.Contains("obj") == true || f.Name.Contains("vshost") == true)
                            continue;
                        else
                        {
                            Programs.Add(f.Name);
                            Directories.Add(f.DirectoryName);
                        }
                    }

                    MultiplePrograms mp = new MultiplePrograms();
                    mp.programs = Programs;
                    mp.directories = Directories;
                    mp.ShowDialog();
                    if (mp.FinalSend.Count != 0)
                    {
                        workDir = mp.FinalSend["dir"].ToString();
                        exeFile = workDir + "\\" + mp.FinalSend["name"].ToString();
                    }
                    else
                        return;
                }

                else
                {
                    return;
                }

                Process runProject = new Process();
                runProject.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                runProject.StartInfo.CreateNoWindow = true;
                runProject.StartInfo.FileName = Environment.GetEnvironmentVariable("WINDIR") + "\\system32\\cmd";
                runProject.StartInfo.Arguments = " /c \"" + exeFile + "\"";
                runProject.StartInfo.WorkingDirectory = workDir;
                runProject.Start();
                runProject.Close();
            }

            //this.Close();
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDirectoryOperation();
        }

        private void OpenDirectoryOperation()
        {
            if (_currentNode.Text != "Project Dir" && _currentNode.Text != "Start a new project")
            {
                Process explorer = new Process();
                explorer.StartInfo.FileName = Environment.GetEnvironmentVariable("WINDIR") + "\\explorer.exe";
                if (projectTreeView.SelectedNode.Parent == null)
                    explorer.StartInfo.Arguments = projectTreeView.SelectedNode.Tag.ToString();
                else
                    explorer.StartInfo.Arguments = "\"" + _currentNode.Tag.ToString() + "\"";
                explorer.Start();
                explorer.Close();

                //this.Close();
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";
            FileInfo[] fi;
            DirectoryInfo di;

            try
            {
                di = new DirectoryInfo(_currentNode.Tag.ToString());
            }

            catch
            {
                return;
            }
            
            fi = di.GetFiles("*.cs", SearchOption.AllDirectories);
            message += "C# Source Files - "+fi.Length;
            fi = di.GetFiles("*.sln", SearchOption.AllDirectories);
            message += "\r\nSolutions - " + fi.Length;
            fi = di.GetFiles("*.exe", SearchOption.AllDirectories);
            message += "\r\nExecutables - " + fi.Length;
            fi = di.GetFiles("*.ico", SearchOption.AllDirectories);
            message += "\r\nIcons - " + fi.Length;
            fi = di.GetFiles("*.png", SearchOption.AllDirectories);
            message += "\r\nPNG files - " + fi.Length;


            MessageBox.Show(message,"Properties");
        }

        private void projectManagerNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
        }

        private void projectManagerNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_isHidden == false)
            {
                this.Hide();
                _isHidden = true;
            }

            else if (_isHidden == true)
            {
                this.Show();
                _isHidden = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            projectManagerNotifyIcon.Visible = false;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences p = new Preferences();
            p.MainFormSize = this.Size;
            p.ShowDialog();
        }

        private void projectTreeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Cursor = Cursors.WaitCursor;

                if (projectTreeView.SelectedNode.Text == "Project Dir")
                {
                    OpenDirectoryOperation();
                }

                if (projectTreeView.SelectedNode.Text.Contains("My Projects - ") == true)
                {
                    this.Cursor = Cursors.Arrow;
                    return;
                }

                else if (projectTreeView.SelectedNode.Text == "Start a new project")
                {
                    Process newvs = new Process();
                    newvs.StartInfo.FileName = @"C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe";
                    newvs.Start();
                    newvs.Close();
                    //this.Close();
                }

                else
                {
                    Process vs = new Process();
                    vs.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    vs.StartInfo.CreateNoWindow = true;
                    //vs.StartInfo.FileName = Environment.GetEnvironmentVariable("WINDIR") + "\\system32\\cmd";
                    vs.StartInfo.FileName = "cmd.exe";
                    vs.StartInfo.Arguments = " /c \"" + projectTreeView.SelectedNode.Tag + "\\" + projectTreeView.SelectedNode.Text + ".sln\"";
                    vs.Start();
                    while (!vs.HasExited)
                    {

                    }
                    vs.Close();
                    //this.Close();
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                helpPanel.Visible = true;
            }

            else if (e.KeyCode == Keys.F5)
            {
                _currentNode = projectTreeView.SelectedNode;
                RunOperation();
            }

            else if (e.KeyCode == Keys.F2)
            {
                _currentNode = projectTreeView.SelectedNode;
                OpenDirectoryOperation();
            }

            else if (e.KeyCode == Keys.F6)
            {
                OpenDirectoryOperation();
            }

            //else if (e.KeyCode == Keys.Escape)
            //    this.Close();

            else
                helpPanel.Visible = false;
        }
    }
}