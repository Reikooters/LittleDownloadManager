﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LittleDownloadManager
{
    public partial class frmAddURL : Form
    {
        private readonly frmMain mainForm;
        public frmAddURL(frmMain parentForm)
        {
            mainForm = parentForm;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check URL is valid
            Uri uriResult;
            String uriName = txtEnterURL.Text;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps || uriResult.Scheme == Uri.UriSchemeFtp);
            if (!result)
            {
                MessageBox.Show("Invalid URL entered", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open a save dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "All Files|*.*";
            saveFileDialog1.Title = "Select save location";
            saveFileDialog1.FileName = System.IO.Path.GetFileName(uriResult.LocalPath);
            DialogResult dlgResult = saveFileDialog1.ShowDialog();

            // Make sure 'Save' was pressed and not 'Cancel'
            if (dlgResult == DialogResult.OK)
            {
                mainForm.queueManager.addItem("Default", saveFileDialog1.FileName, txtEnterURL.Text);
                mainForm.queueManager.save();
                mainForm.addURLToTableAndUpdateStatusBar(saveFileDialog1.FileName, txtEnterURL.Text);
                this.Close();
            }
        }
    }
}
