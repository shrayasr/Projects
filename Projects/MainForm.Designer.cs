namespace Projects
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.projectTreeView = new System.Windows.Forms.TreeView();
            this.rightClickContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.overwriteExistingProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addAnotherProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeConfigDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectManagerNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.settingsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.rightClickContextMenuStrip.SuspendLayout();
            this.runContextMenuStrip.SuspendLayout();
            this.settingsContextMenuStrip.SuspendLayout();
            this.helpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectTreeView
            // 
            this.projectTreeView.ContextMenuStrip = this.rightClickContextMenuStrip;
            this.projectTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectTreeView.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.projectTreeView.Indent = 18;
            this.projectTreeView.Location = new System.Drawing.Point(0, 0);
            this.projectTreeView.Name = "projectTreeView";
            this.projectTreeView.Size = new System.Drawing.Size(271, 407);
            this.projectTreeView.TabIndex = 0;
            this.projectTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectTreeView_NodeMouseDoubleClick);
            this.projectTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.projectTreeView_AfterCollapse);
            this.projectTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.projectTreeView_NodeMouseClick);
            this.projectTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectTreeView_KeyDown);
            this.projectTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.projectTreeView_AfterExpand);
            // 
            // rightClickContextMenuStrip
            // 
            this.rightClickContextMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightClickContextMenuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.rightClickContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeSelectedProjectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.overwriteExistingProjectsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.propertiesToolStripMenuItem});
            this.rightClickContextMenuStrip.Name = "rightClickContextMenuStrip";
            this.rightClickContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rightClickContextMenuStrip.Size = new System.Drawing.Size(216, 104);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::Projects.Properties.Resources._;
            this.addToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addToolStripMenuItem.Text = "&Add another project";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeSelectedProjectToolStripMenuItem
            // 
            this.removeSelectedProjectToolStripMenuItem.Image = global::Projects.Properties.Resources.x;
            this.removeSelectedProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeSelectedProjectToolStripMenuItem.Name = "removeSelectedProjectToolStripMenuItem";
            this.removeSelectedProjectToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.removeSelectedProjectToolStripMenuItem.Text = "&Remove selected project";
            this.removeSelectedProjectToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // overwriteExistingProjectsToolStripMenuItem
            // 
            this.overwriteExistingProjectsToolStripMenuItem.Image = global::Projects.Properties.Resources.o;
            this.overwriteExistingProjectsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.overwriteExistingProjectsToolStripMenuItem.Name = "overwriteExistingProjectsToolStripMenuItem";
            this.overwriteExistingProjectsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.overwriteExistingProjectsToolStripMenuItem.Text = "&Overwrite existing projects";
            this.overwriteExistingProjectsToolStripMenuItem.Click += new System.EventHandler(this.overwriteExistingProjectsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(212, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Image = global::Projects.Properties.Resources.properties;
            this.propertiesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // addAnotherProjectToolStripMenuItem
            // 
            this.addAnotherProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addAnotherProjectToolStripMenuItem.Name = "addAnotherProjectToolStripMenuItem";
            this.addAnotherProjectToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addAnotherProjectToolStripMenuItem.Text = "Add another Project";
            // 
            // remToolStripMenuItem
            // 
            this.remToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.remToolStripMenuItem.Name = "remToolStripMenuItem";
            this.remToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.remToolStripMenuItem.Text = "Remove this project";
            // 
            // changeConfigDirectoryToolStripMenuItem
            // 
            this.changeConfigDirectoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changeConfigDirectoryToolStripMenuItem.Name = "changeConfigDirectoryToolStripMenuItem";
            this.changeConfigDirectoryToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.changeConfigDirectoryToolStripMenuItem.Text = "Overwrite current projects";
            // 
            // runContextMenuStrip
            // 
            this.runContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runProjectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.openDirectoryToolStripMenuItem});
            this.runContextMenuStrip.Name = "runContextMenuStrip";
            this.runContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.runContextMenuStrip.Size = new System.Drawing.Size(159, 54);
            // 
            // runProjectToolStripMenuItem
            // 
            this.runProjectToolStripMenuItem.Image = global::Projects.Properties.Resources.run;
            this.runProjectToolStripMenuItem.Name = "runProjectToolStripMenuItem";
            this.runProjectToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.runProjectToolStripMenuItem.Text = "&Run Project";
            this.runProjectToolStripMenuItem.Click += new System.EventHandler(this.runProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Image = global::Projects.Properties.Resources.folder;
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openDirectoryToolStripMenuItem.Text = "&Open Directory";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // projectManagerNotifyIcon
            // 
            this.projectManagerNotifyIcon.ContextMenuStrip = this.settingsContextMenuStrip;
            this.projectManagerNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("projectManagerNotifyIcon.Icon")));
            this.projectManagerNotifyIcon.Text = "Project Manager";
            this.projectManagerNotifyIcon.Visible = true;
            this.projectManagerNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.projectManagerNotifyIcon_MouseClick);
            this.projectManagerNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.projectManagerNotifyIcon_MouseDoubleClick);
            // 
            // settingsContextMenuStrip
            // 
            this.settingsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.settingsContextMenuStrip.Name = "settingsContextMenuStrip";
            this.settingsContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.settingsContextMenuStrip.Size = new System.Drawing.Size(144, 26);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Image = global::Projects.Properties.Resources.settings;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpPanel
            // 
            this.helpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpPanel.Controls.Add(this.helpTextBox);
            this.helpPanel.Location = new System.Drawing.Point(12, 12);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(247, 372);
            this.helpPanel.TabIndex = 3;
            // 
            // helpTextBox
            // 
            this.helpTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpTextBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.helpTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.helpTextBox.Location = new System.Drawing.Point(0, 0);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.Size = new System.Drawing.Size(245, 370);
            this.helpTextBox.TabIndex = 0;
            this.helpTextBox.Text = resources.GetString("helpTextBox.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 407);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.projectTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rightClickContextMenuStrip.ResumeLayout(false);
            this.runContextMenuStrip.ResumeLayout(false);
            this.settingsContextMenuStrip.ResumeLayout(false);
            this.helpPanel.ResumeLayout(false);
            this.helpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView projectTreeView;
        private System.Windows.Forms.ContextMenuStrip rightClickContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem changeConfigDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnotherProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem overwriteExistingProjectsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip runContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem runProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon projectManagerNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip settingsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.TextBox helpTextBox;
    }
}

