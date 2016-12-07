using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projects
{
    public partial class MultiplePrograms : Form
    {
        ArrayList Programs = new ArrayList();
        ArrayList Directories = new ArrayList();
        SortedList finalSend = new SortedList();

        DataTable ProgramsTable;
        DataRow newProgram;


        public MultiplePrograms()
        {
            InitializeComponent();
            ProgramsTable = new DataTable();

            DataColumn programName = new DataColumn("name", Type.GetType("System.String"));
            DataColumn programDir = new DataColumn("dir",Type.GetType("System.String"));
            ProgramsTable.Columns.Add(programName);
            ProgramsTable.Columns.Add(programDir);
        }

        #region properties

        public ArrayList programs
        {
            set { Programs = value; }
        }

        public ArrayList directories
        {
            set { Directories = value; }
        }

        public SortedList FinalSend
        {
            get { return finalSend; }
        }

        #endregion

        private void MultiplePrograms_Load(object sender, EventArgs e)
        {
            setPosition();

            for (int i = 0; i < Programs.Count; i++)
            {
                newProgram = ProgramsTable.NewRow();
                newProgram["name"] = Programs[i];
                newProgram["dir"] = Directories[i];
                ProgramsTable.Rows.Add(newProgram);

                programsDataGridView.DataSource = ProgramsTable;
            }
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

        private void programsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection selected = programsDataGridView.SelectedCells;
            finalSend.Add("name", ProgramsTable.Rows[selected[0].RowIndex]["name"]);
            finalSend.Add("dir", ProgramsTable.Rows[selected[0].RowIndex]["dir"]);
            this.Close();
        }
    }
}