using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Projects
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        string projectDir = "";
        string exeDir = "";
        string mode = "";

        #region properties
        public string ProjectDir
        {
            get { return projectDir; }
        }

        public string ExeDir
        {
            set { exeDir = value; }
        }

        public string Mode
        {
            set { mode = value; }
        }
        #endregion

        private void projectBrowseButton_Click(object sender, EventArgs e)
        {
            if (projectFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                projectDirTextBox.Text = projectFolderBrowserDialog.SelectedPath;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (projectDirTextBox.Text == "")
            {
                MessageBox.Show("Project Directory not selected");
                projectBrowseButton.Focus();
                return;
            }

            projectDir = projectDirTextBox.Text;

            if (File.Exists(exeDir+"\\config.cfg") == true && mode == "ADD")
            {
                FileInfo fi = new FileInfo(exeDir + "\\config.cfg");
                StreamWriter sw = fi.AppendText();
                sw.WriteLine(projectDir);
                sw.Close();
            }

            else
            {
                StreamWriter sw = new StreamWriter(exeDir + "\\config.cfg");
                sw.WriteLine(projectDir);
                sw.Close();
            }
            

            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            Size resolution = SystemInformation.PrimaryMonitorSize;

            Size test = new Size();

            test.Width = resolution.Width - this.Width;
            test.Height = resolution.Height - this.Height - 30;

            Point x = new Point();
            x.X = test.Width;
            x.Y = test.Height;

            this.Location = x;
        }
    }
}