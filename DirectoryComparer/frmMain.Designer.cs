namespace DirectoryComparer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblFolder1 = new System.Windows.Forms.Label();
            this.txtFolder1 = new System.Windows.Forms.TextBox();
            this.lblFolder2 = new System.Windows.Forms.Label();
            this.txtFolder2 = new System.Windows.Forms.TextBox();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.bnChoose2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comparerWorker = new System.ComponentModel.BackgroundWorker();
            this.comboBox_choose_strategy = new System.Windows.Forms.ComboBox();
            this.label_compare_strategy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFolder1
            // 
            this.lblFolder1.AutoSize = true;
            this.lblFolder1.Location = new System.Drawing.Point(32, 31);
            this.lblFolder1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolder1.Name = "lblFolder1";
            this.lblFolder1.Size = new System.Drawing.Size(108, 17);
            this.lblFolder1.TabIndex = 0;
            this.lblFolder1.Text = "Choose folder 1";
            // 
            // txtFolder1
            // 
            this.txtFolder1.Location = new System.Drawing.Point(161, 22);
            this.txtFolder1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolder1.Name = "txtFolder1";
            this.txtFolder1.Size = new System.Drawing.Size(492, 22);
            this.txtFolder1.TabIndex = 1;
            // 
            // lblFolder2
            // 
            this.lblFolder2.AutoSize = true;
            this.lblFolder2.Location = new System.Drawing.Point(32, 70);
            this.lblFolder2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolder2.Name = "lblFolder2";
            this.lblFolder2.Size = new System.Drawing.Size(108, 17);
            this.lblFolder2.TabIndex = 2;
            this.lblFolder2.Text = "Choose folder 2";
            // 
            // txtFolder2
            // 
            this.txtFolder2.Location = new System.Drawing.Point(161, 66);
            this.txtFolder2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolder2.Name = "txtFolder2";
            this.txtFolder2.Size = new System.Drawing.Size(492, 22);
            this.txtFolder2.TabIndex = 3;
            // 
            // btnChoose1
            // 
            this.btnChoose1.Location = new System.Drawing.Point(664, 22);
            this.btnChoose1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(45, 28);
            this.btnChoose1.TabIndex = 4;
            this.btnChoose1.Text = "...";
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // bnChoose2
            // 
            this.bnChoose2.Location = new System.Drawing.Point(664, 64);
            this.bnChoose2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnChoose2.Name = "bnChoose2";
            this.bnChoose2.Size = new System.Drawing.Size(45, 28);
            this.bnChoose2.TabIndex = 5;
            this.bnChoose2.Text = "...";
            this.bnChoose2.UseVisualStyleBackColor = true;
            this.bnChoose2.Click += new System.EventHandler(this.bnChoose2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(36, 151);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(227, 28);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(482, 151);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // folderChooser
            // 
            this.folderChooser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderChooser.ShowNewFolderButton = false;
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Checked = true;
            this.chkRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecursive.Location = new System.Drawing.Point(35, 111);
            this.chkRecursive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(101, 21);
            this.chkRecursive.TabIndex = 8;
            this.chkRecursive.Text = "&Recursive?";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(36, 196);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(673, 28);
            this.progressBar.TabIndex = 9;
            // 
            // comparerWorker
            // 
            this.comparerWorker.WorkerReportsProgress = true;
            // 
            // comboBox_choose_strategy
            // 
            this.comboBox_choose_strategy.FormattingEnabled = true;
            this.comboBox_choose_strategy.Location = new System.Drawing.Point(482, 109);
            this.comboBox_choose_strategy.Name = "comboBox_choose_strategy";
            this.comboBox_choose_strategy.Size = new System.Drawing.Size(227, 24);
            this.comboBox_choose_strategy.TabIndex = 14;
            this.comboBox_choose_strategy.SelectedIndexChanged += new System.EventHandler(this.comboBox_choose_strategy_SelectedIndexChanged);
            // 
            // label_compare_strategy
            // 
            this.label_compare_strategy.AutoSize = true;
            this.label_compare_strategy.Location = new System.Drawing.Point(290, 112);
            this.label_compare_strategy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_compare_strategy.Name = "label_compare_strategy";
            this.label_compare_strategy.Size = new System.Drawing.Size(174, 17);
            this.label_compare_strategy.TabIndex = 13;
            this.label_compare_strategy.Text = "Choose Compare Strategy";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 239);
            this.Controls.Add(this.comboBox_choose_strategy);
            this.Controls.Add(this.label_compare_strategy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chkRecursive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.bnChoose2);
            this.Controls.Add(this.btnChoose1);
            this.Controls.Add(this.txtFolder2);
            this.Controls.Add(this.lblFolder2);
            this.Controls.Add(this.txtFolder1);
            this.Controls.Add(this.lblFolder1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Directory Comparer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolder1;
        private System.Windows.Forms.TextBox txtFolder1;
        private System.Windows.Forms.Label lblFolder2;
        private System.Windows.Forms.TextBox txtFolder2;
        private System.Windows.Forms.Button btnChoose1;
        private System.Windows.Forms.Button bnChoose2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog folderChooser;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker comparerWorker;
        private System.Windows.Forms.ComboBox comboBox_choose_strategy;
        private System.Windows.Forms.Label label_compare_strategy;
    }
}

