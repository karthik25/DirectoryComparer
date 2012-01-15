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
            this.SuspendLayout();
            // 
            // lblFolder1
            // 
            this.lblFolder1.AutoSize = true;
            this.lblFolder1.Location = new System.Drawing.Point(24, 25);
            this.lblFolder1.Name = "lblFolder1";
            this.lblFolder1.Size = new System.Drawing.Size(81, 13);
            this.lblFolder1.TabIndex = 0;
            this.lblFolder1.Text = "Choose folder 1";
            // 
            // txtFolder1
            // 
            this.txtFolder1.Location = new System.Drawing.Point(121, 18);
            this.txtFolder1.Name = "txtFolder1";
            this.txtFolder1.Size = new System.Drawing.Size(370, 20);
            this.txtFolder1.TabIndex = 1;
            // 
            // lblFolder2
            // 
            this.lblFolder2.AutoSize = true;
            this.lblFolder2.Location = new System.Drawing.Point(24, 57);
            this.lblFolder2.Name = "lblFolder2";
            this.lblFolder2.Size = new System.Drawing.Size(81, 13);
            this.lblFolder2.TabIndex = 2;
            this.lblFolder2.Text = "Choose folder 2";
            // 
            // txtFolder2
            // 
            this.txtFolder2.Location = new System.Drawing.Point(121, 54);
            this.txtFolder2.Name = "txtFolder2";
            this.txtFolder2.Size = new System.Drawing.Size(370, 20);
            this.txtFolder2.TabIndex = 3;
            // 
            // btnChoose1
            // 
            this.btnChoose1.Location = new System.Drawing.Point(498, 18);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(34, 23);
            this.btnChoose1.TabIndex = 4;
            this.btnChoose1.Text = "...";
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // bnChoose2
            // 
            this.bnChoose2.Location = new System.Drawing.Point(498, 52);
            this.bnChoose2.Name = "bnChoose2";
            this.bnChoose2.Size = new System.Drawing.Size(34, 23);
            this.bnChoose2.TabIndex = 5;
            this.bnChoose2.Text = "...";
            this.bnChoose2.UseVisualStyleBackColor = true;
            this.bnChoose2.Click += new System.EventHandler(this.bnChoose2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(186, 111);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(362, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 23);
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
            this.chkRecursive.Location = new System.Drawing.Point(27, 111);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(80, 17);
            this.chkRecursive.TabIndex = 8;
            this.chkRecursive.Text = "&Recursive?";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(27, 159);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(505, 23);
            this.progressBar.TabIndex = 9;
            // 
            // comparerWorker
            // 
            this.comparerWorker.WorkerReportsProgress = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 194);
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
    }
}

