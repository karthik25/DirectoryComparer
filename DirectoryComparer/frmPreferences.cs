using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DirectoryComparer.Objects;
using System.Text.RegularExpressions;
using System.IO;
using DirectoryComparer.RegistryManager;
using System.Diagnostics;

namespace DirectoryComparer
{
    public partial class frmPreferences : Form
    {
        public frmPreferences()
        {
            InitializeComponent();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            textBox1.Text = DirectoryComparerBaseInfo.Preferences.DefaultLeftPath;
            textBox2.Text = DirectoryComparerBaseInfo.Preferences.DefaultRightPath;

            List<ColumnItem> columnItems = DirectoryComparerBaseInfo.Preferences.Columns;
            List<CheckBox> chkBoxes = GetCheckBoxes();

            foreach (var chkBox in chkBoxes)
            {
                chkBox.Checked = columnItems.Single(c => c.ColumnCaption == Regex.Replace(chkBox.Text, @"[&]", "")).IsVisible;
            }
        }

        private List<CheckBox> GetCheckBoxes()
        {
            List<CheckBox> chkBoxes = this.Controls
                                          .Cast<Control>()
                                          .OfType<GroupBox>()
                                          .Single()
                                          .Controls
                                          .Cast<Control>()
                                          .OfType<CheckBox>()
                                          .ToList();
            return chkBoxes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strStatus = ValidateInputs();

            if (!string.IsNullOrEmpty(strStatus))
            {
                MessageBox.Show(strStatus, "Directory Comparer");
                return;
            }

            string columnStr = "{0},{1},{2},{3},{4},{5}";
            columnStr = string.Format(columnStr,
                                      checkBox2.Checked.ToInt(),
                                      checkBox1.Checked.ToInt(),
                                      checkBox4.Checked.ToInt(),
                                      checkBox5.Checked.ToInt(),
                                      checkBox6.Checked.ToInt(),
                                      checkBox7.Checked.ToInt());

            DirectoryComparerBaseInfo.Preferences.Columns = ColumnItemHelper.GetColumns(columnStr);

            RegManager regManager = RegManager.getInstance();
            bool status = regManager.writeColumnPreferences(columnStr);
            status = regManager.writeDefaultLeftDir(textBox1.Text);
            status = regManager.writeDefaultRightDir(textBox2.Text);
            lblStatus.Text = status ? "Preferences saved" : "Errors were encountered";
        }

        private string ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return "Please choose folder 1";

            if (string.IsNullOrEmpty(textBox2.Text))
                return "Please choose folder 2";

            if (File.Exists(textBox1.Text))
                return string.Format("{0} is a file, please choose a folder.", textBox1.Text);

            if (File.Exists(textBox2.Text))
                return string.Format("{0} is a file, please choose a folder.", textBox2.Text);

            if (!Directory.Exists(textBox1.Text))
                return string.Format("{0} does not exist", textBox1.Text);

            if (!Directory.Exists(textBox2.Text))
                return string.Format("{0} does not exist", textBox2.Text);

            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderChooser.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = folderChooser.SelectedPath;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderChooser.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = folderChooser.SelectedPath;
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            string appPath = Application.ExecutablePath;

            Process process = new Process();
            process.StartInfo.FileName = appPath;
            process.Start();

            System.Environment.Exit(0);
        }
    }
}
