namespace Projects
{
    partial class MultiplePrograms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.programsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.programsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programsDataGridView
            // 
            this.programsDataGridView.AllowUserToAddRows = false;
            this.programsDataGridView.AllowUserToDeleteRows = false;
            this.programsDataGridView.AllowUserToResizeColumns = false;
            this.programsDataGridView.AllowUserToResizeRows = false;
            this.programsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.programsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.programsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dir});
            this.programsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.programsDataGridView.Name = "programsDataGridView";
            this.programsDataGridView.ReadOnly = true;
            this.programsDataGridView.RowHeadersVisible = false;
            this.programsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.programsDataGridView.Size = new System.Drawing.Size(271, 183);
            this.programsDataGridView.TabIndex = 0;
            this.programsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.programsDataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.programsDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 183);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "There are Multiple programs that are launchable\r\nPlease select a Program by Doubl" +
                "e clicking on it";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Program Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dir
            // 
            this.dir.DataPropertyName = "dir";
            this.dir.HeaderText = "dir";
            this.dir.Name = "dir";
            this.dir.ReadOnly = true;
            this.dir.Visible = false;
            // 
            // MultiplePrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiplePrograms";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Multiple Program Launcher";
            this.Load += new System.EventHandler(this.MultiplePrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView programsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
    }
}