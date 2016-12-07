using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Projects
{
    public partial class Preferences : Form
    {
        SortedList ExportToXml;

        public Preferences()
        {
            InitializeComponent();
            ExportToXml = new SortedList();
        }

        Size mainFormSize;

        public Size MainFormSize
        {
            set { mainFormSize = value; }
        }

        private void setPosition()
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

        private void Preferences_Load(object sender, EventArgs e)
        {
            setPosition();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (remSizeCheckBox.Checked == true)
            {
                ExportToXml.Add("rememberSize", "true");
                ExportToXml.Add("width",mainFormSize.Width);
                ExportToXml.Add("height", mainFormSize.Height);
            }

            savePreferencesInXml();

            this.Close();
        }

        private void savePreferencesInXml()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            using (XmlWriter writer = XmlWriter.Create("configuration.xml", settings))
            {
                writer.WriteStartElement("settings");
                writer.WriteStartElement("size");
                writer.WriteElementString("remember_size", ExportToXml["rememberSize"].ToString());
                writer.WriteElementString("width", ExportToXml["width"].ToString());
                writer.WriteElementString("height", ExportToXml["height"].ToString());
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}