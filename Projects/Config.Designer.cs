namespace Projects
{
    partial class Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.projectDirTextBox = new System.Windows.Forms.TextBox();
            this.projectBrowseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.projectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Directory";
            // 
            // projectDirTextBox
            // 
            this.projectDirTextBox.Location = new System.Drawing.Point(117, 6);
            this.projectDirTextBox.Name = "projectDirTextBox";
            this.projectDirTextBox.ReadOnly = true;
            this.projectDirTextBox.Size = new System.Drawing.Size(212, 22);
            this.projectDirTextBox.TabIndex = 1;
            // 
            // projectBrowseButton
            // 
            this.projectBrowseButton.Location = new System.Drawing.Point(335, 5);
            this.projectBrowseButton.Name = "projectBrowseButton";
            this.projectBrowseButton.Size = new System.Drawing.Size(27, 23);
            this.projectBrowseButton.TabIndex = 2;
            this.projectBrowseButton.Text = "...";
            this.projectBrowseButton.UseVisualStyleBackColor = true;
            this.projectBrowseButton.Click += new System.EventHandler(this.projectBrowseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(368, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 34);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projectBrowseButton);
            this.Controls.Add(this.projectDirTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 68);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 68);
            this.Name = "Config";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projectDirTextBox;
        private System.Windows.Forms.Button projectBrowseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog projectFolderBrowserDialog;
    }
}