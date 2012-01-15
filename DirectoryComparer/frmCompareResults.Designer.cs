using System.Windows.Forms;
using System.Drawing;
using DirectoryComparer.Services;
namespace DirectoryComparer
{
    partial class frmCompareResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompareResults));
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftSideOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSideOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showMatchesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMismatchesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLeftFilesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRightFilesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openLeftFilewNotepa0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRightFilewNotepa0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLeftPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRightPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.openLeftFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRightFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(976, 443);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareFoldersToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.saveResultsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // compareFoldersToolStripMenuItem
            // 
            this.compareFoldersToolStripMenuItem.Name = "compareFoldersToolStripMenuItem";
            this.compareFoldersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.compareFoldersToolStripMenuItem.Text = "&Compare Folders";
            this.compareFoldersToolStripMenuItem.Click += new System.EventHandler(this.compareFoldersToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.preferencesToolStripMenuItem.Text = "P&references";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asXMLToolStripMenuItem,
            this.asCSVToolStripMenuItem});
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveResultsToolStripMenuItem.Text = "&Save Results";
            // 
            // asXMLToolStripMenuItem
            // 
            this.asXMLToolStripMenuItem.Name = "asXMLToolStripMenuItem";
            this.asXMLToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.asXMLToolStripMenuItem.Text = "As XM&L";
            this.asXMLToolStripMenuItem.Click += new System.EventHandler(this.asXMLToolStripMenuItem_Click);
            // 
            // asCSVToolStripMenuItem
            // 
            this.asCSVToolStripMenuItem.Name = "asCSVToolStripMenuItem";
            this.asCSVToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.asCSVToolStripMenuItem.Text = "&As CSV";
            this.asCSVToolStripMenuItem.Click += new System.EventHandler(this.asCSVToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bothResultsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.leftSideOnlyToolStripMenuItem,
            this.rightSideOnlyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // bothResultsToolStripMenuItem
            // 
            this.bothResultsToolStripMenuItem.Checked = true;
            this.bothResultsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bothResultsToolStripMenuItem.Name = "bothResultsToolStripMenuItem";
            this.bothResultsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bothResultsToolStripMenuItem.Text = "&Both Results";
            this.bothResultsToolStripMenuItem.Click += new System.EventHandler(this.bothResultsToolStripMenuItem_Click);
            // 
            // leftSideOnlyToolStripMenuItem
            // 
            this.leftSideOnlyToolStripMenuItem.Name = "leftSideOnlyToolStripMenuItem";
            this.leftSideOnlyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.leftSideOnlyToolStripMenuItem.Text = "&Left Side Only";
            this.leftSideOnlyToolStripMenuItem.Click += new System.EventHandler(this.leftSideOnlyToolStripMenuItem_Click);
            // 
            // rightSideOnlyToolStripMenuItem
            // 
            this.rightSideOnlyToolStripMenuItem.Name = "rightSideOnlyToolStripMenuItem";
            this.rightSideOnlyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.rightSideOnlyToolStripMenuItem.Text = "&Right Side Only";
            this.rightSideOnlyToolStripMenuItem.Click += new System.EventHandler(this.rightSideOnlyToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showMatchesOnlyToolStripMenuItem,
            this.showMismatchesOnlyToolStripMenuItem,
            this.showLeftFilesOnlyToolStripMenuItem,
            this.showRightFilesOnlyToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "F&ilter";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Checked = true;
            this.showAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showAllToolStripMenuItem.Text = "Show A&ll";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // showMatchesOnlyToolStripMenuItem
            // 
            this.showMatchesOnlyToolStripMenuItem.Name = "showMatchesOnlyToolStripMenuItem";
            this.showMatchesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showMatchesOnlyToolStripMenuItem.Text = "Show &Matches Only";
            this.showMatchesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showMatchesOnlyToolStripMenuItem_Click);
            // 
            // showMismatchesOnlyToolStripMenuItem
            // 
            this.showMismatchesOnlyToolStripMenuItem.Name = "showMismatchesOnlyToolStripMenuItem";
            this.showMismatchesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showMismatchesOnlyToolStripMenuItem.Text = "Show Mismatches &Only";
            this.showMismatchesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showMismatchesOnlyToolStripMenuItem_Click);
            // 
            // showLeftFilesOnlyToolStripMenuItem
            // 
            this.showLeftFilesOnlyToolStripMenuItem.Name = "showLeftFilesOnlyToolStripMenuItem";
            this.showLeftFilesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showLeftFilesOnlyToolStripMenuItem.Text = "Show Left Files Onl&y";
            this.showLeftFilesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showLeftFilesOnlyToolStripMenuItem_Click);
            // 
            // showRightFilesOnlyToolStripMenuItem
            // 
            this.showRightFilesOnlyToolStripMenuItem.Name = "showRightFilesOnlyToolStripMenuItem";
            this.showRightFilesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showRightFilesOnlyToolStripMenuItem.Text = "Show Right Files O&nly";
            this.showRightFilesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showRightFilesOnlyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLeftFilewNotepa0ToolStripMenuItem,
            this.openRightFilewNotepa0ToolStripMenuItem,
            this.copyLeftPathToolStripMenuItem,
            this.copyRightPathToolStripMenuItem,
            this.toolStripMenuItem2,
            this.openLeftFolderToolStripMenuItem,
            this.openRightFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 142);
            // 
            // openLeftFilewNotepa0ToolStripMenuItem
            // 
            this.openLeftFilewNotepa0ToolStripMenuItem.Name = "openLeftFilewNotepa0ToolStripMenuItem";
            this.openLeftFilewNotepa0ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openLeftFilewNotepa0ToolStripMenuItem.Text = "Open &Left File (w/ Notepad)";
            this.openLeftFilewNotepa0ToolStripMenuItem.Click += new System.EventHandler(this.openLeftFilewNotepa0ToolStripMenuItem_Click);
            // 
            // openRightFilewNotepa0ToolStripMenuItem
            // 
            this.openRightFilewNotepa0ToolStripMenuItem.Name = "openRightFilewNotepa0ToolStripMenuItem";
            this.openRightFilewNotepa0ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openRightFilewNotepa0ToolStripMenuItem.Text = "Open &Right File (w/ Notepad)";
            this.openRightFilewNotepa0ToolStripMenuItem.Click += new System.EventHandler(this.openRightFilewNotepa0ToolStripMenuItem_Click);
            // 
            // copyLeftPathToolStripMenuItem
            // 
            this.copyLeftPathToolStripMenuItem.Name = "copyLeftPathToolStripMenuItem";
            this.copyLeftPathToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.copyLeftPathToolStripMenuItem.Text = "Copy Left &Path";
            this.copyLeftPathToolStripMenuItem.Click += new System.EventHandler(this.copyLeftPathToolStripMenuItem_Click_1);
            // 
            // copyRightPathToolStripMenuItem
            // 
            this.copyRightPathToolStripMenuItem.Name = "copyRightPathToolStripMenuItem";
            this.copyRightPathToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.copyRightPathToolStripMenuItem.Text = "Copy Right P&ath";
            this.copyRightPathToolStripMenuItem.Click += new System.EventHandler(this.copyRightPathToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // openLeftFolderToolStripMenuItem
            // 
            this.openLeftFolderToolStripMenuItem.Name = "openLeftFolderToolStripMenuItem";
            this.openLeftFolderToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openLeftFolderToolStripMenuItem.Text = "Open L&eft Folder";
            this.openLeftFolderToolStripMenuItem.Click += new System.EventHandler(this.openLeftFolderToolStripMenuItem_Click_1);
            // 
            // openRightFolderToolStripMenuItem
            // 
            this.openRightFolderToolStripMenuItem.Name = "openRightFolderToolStripMenuItem";
            this.openRightFolderToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openRightFolderToolStripMenuItem.Text = "Open R&ight Folder";
            this.openRightFolderToolStripMenuItem.Click += new System.EventHandler(this.openRightFolderToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 6);
            // 
            // frmCompareResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 467);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCompareResults";
            this.Text = "Directory Comparer - Compare Results";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompareResults_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftSideOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightSideOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareFoldersToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem asXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asCSVToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem showAllToolStripMenuItem;
        private ToolStripMenuItem showMatchesOnlyToolStripMenuItem;
        private ToolStripMenuItem showMismatchesOnlyToolStripMenuItem;
        private ToolStripMenuItem showLeftFilesOnlyToolStripMenuItem;
        private ToolStripMenuItem showRightFilesOnlyToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openLeftFilewNotepa0ToolStripMenuItem;
        private ToolStripMenuItem openRightFilewNotepa0ToolStripMenuItem;
        private ToolStripMenuItem copyLeftPathToolStripMenuItem;
        private ToolStripMenuItem copyRightPathToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem openLeftFolderToolStripMenuItem;
        private ToolStripMenuItem openRightFolderToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
    }
}