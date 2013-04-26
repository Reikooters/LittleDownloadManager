using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LittleDownloadManager
{
    public partial class AddURL : Form
    {
        private readonly Form1 form1;
        public AddURL(Form1 parentForm)
        {
            form1 = parentForm;
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
            String uriName = textBox1.Text;
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
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                form1.addURLToTable(saveFileDialog1.FileName, textBox1.Text);
                this.Close();
            }
        }
    }
}
