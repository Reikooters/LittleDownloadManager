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
    public partial class frmMain : Form
    {
        QueueManager queueManager = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region SplitContainer Focus Workaround
        /* --- SplitContainer focus workaround ---
         * by Scott Morrison of Microsoft */
        // Temp variable to store a previously focused control
        private Control focused = null;
        private void splitContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the focused control before the splitter is focused
            focused = getFocused(this.Controls);
        }
        private Control getFocused(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c.Focused)
                {
                    // Return the focused control
                    return c;
                }
                else if (c.ContainsFocus)
                {
                    // If the focus is contained inside a control's children
                    // return the child
                    return getFocused(c.Controls);
                }
            }
            // No control on the form has focus
            return null;
        }
        private void splitContainer1_MouseUp(object sender, MouseEventArgs e)
        {
            // If a previous control had focus
            if (focused != null)
            {
                // Return focus and clear the temp variable for 
                // garbage collection
                focused.Focus();
                focused = null;
            }
        }
        /* --- end SplitContainer focus workaround --- */
        #endregion

        // If File->Add URL is clicked
        private void addURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAddURLForm();
        }

        // If File->Exit is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the program
            Close();
        }

        private void table1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Create QueueManager and load the queue from disk.
            queueManager = new QueueManager("queue");

            queueManager.fillTable(this);

            // After table has been filled, sort it by filename (ascending)
            this.table.Sort(0, System.Windows.Forms.SortOrder.Ascending);

            // Update status bar
            updateStatusBar();
        }

        #region TreeView bold selection
        /* --- begin TreeView bold selection --- */
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.TreeView.SelectedNode != null)
            {
                e.Node.TreeView.SelectedNode.NodeFont = new System.Drawing.Font(e.Node.TreeView.SelectedNode.NodeFont, e.Node.TreeView.SelectedNode.NodeFont.Style ^ FontStyle.Bold);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.NodeFont = new System.Drawing.Font(tvCategories.SelectedNode.TreeView.Font, tvCategories.SelectedNode.TreeView.Font.Style ^ FontStyle.Bold);
            e.Node.Text = e.Node.Text;
            //e.Node.Expand();
        }
        /* --- end TreeView bold selection --- */
        #endregion

        public void addURLToTable(uint priority, String filename, String url)
        {
            // Create new cell variables
            XPTable.Models.Cell[] cells = new XPTable.Models.Cell[10];

            for (int i = 0; i < 10; ++i)
            {
                cells[i] = new XPTable.Models.Cell();
            }

            // Put the cell data together
            Uri uri = new Uri(url);
            cells[0].Data = priority;
            cells[1].Text = System.IO.Path.GetFileName(filename);
            cells[2].Text = "size";
            cells[3].Data = 0;
            cells[4].Text = "status";
            cells[5].Text = "speed";
            cells[6].Text = "eta";
            cells[7].Text = url;
            cells[8].Text = filename;

            // Put the cells together into a row
            XPTable.Models.Row row = new XPTable.Models.Row(
                cells
            );

            // Add the row to the table
            tableModel.Rows.Add(row);
        }

        public void addURLToTableAndUpdateStatusBar(uint priority, String filename, String url)
        {
            // Add URL to table
            addURLToTable(priority, filename, url);

            // Update status bar
            updateStatusBar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openAddURLForm();
        }

        private void openAddURLForm()
        {
            Form f = new frmAddURL(this);
            f.ShowDialog();
        }

        public void updateStatusBar()
        {
            toolStripStatusLabel1.Text = tableModel.Rows.Count.ToString() + " unfinished downloads.";
        }

        private void tsbWebsite_Click(object sender, EventArgs e)
        {
            string target = "http://www.reikooters.net";

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutLittleDownloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmAboutBox();
            f.ShowDialog();
        }
    }
}