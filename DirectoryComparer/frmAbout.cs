using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace DirectoryComparer
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.textBoxDescription.Text = "This is just a simple application that can be used to compare 2 directories." 
                                           + Environment.NewLine
                                           + Environment.NewLine
                                           + " For updates visit http://comparer.thekfactor.info";
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process siteLauncher = new Process();
            siteLauncher.StartInfo.FileName = "iexplore.exe";
            siteLauncher.StartInfo.Arguments = ((LinkLabel)sender).Text;
            siteLauncher.Start();
        }
    }
}
