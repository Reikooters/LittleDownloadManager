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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // After table has been filled, sort it by filename (ascending)
            this.table1.Sort(0, System.Windows.Forms.SortOrder.Ascending);

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
            e.Node.NodeFont = new System.Drawing.Font(treeView1.SelectedNode.TreeView.Font, treeView1.SelectedNode.TreeView.Font.Style ^ FontStyle.Bold);
            e.Node.Text = e.Node.Text;
            //e.Node.Expand();
        }
        /* --- end TreeView bold selection --- */
        #endregion

        public void addURLToTable(String filename, String url)
        {
            // Create new cell variables
            XPTable.Models.Cell cell1 = new XPTable.Models.Cell();
            XPTable.Models.Cell cell2 = new XPTable.Models.Cell();
            XPTable.Models.Cell cell3 = new XPTable.Models.Cell();

            // Put the cell data together
            Uri uri = new Uri(url);
            cell1.Text = System.IO.Path.GetFileName(uri.LocalPath);
            cell2.Text = url;
            cell3.Data = 0;

            // Put the cells together into a row
            XPTable.Models.Row row = new XPTable.Models.Row(
                new XPTable.Models.Cell[] {
                    cell1,
                    cell2,
                    cell3
                }
            );

            // Add the row to the table
            tableModel1.Rows.Add(row);

            // Update status bar
            updateStatusBar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openAddURLForm();
        }

        private void openAddURLForm()
        {
            Form f = new AddURL(this);
            f.ShowDialog();
        }

        private void updateStatusBar()
        {
            toolStripStatusLabel1.Text = tableModel1.Rows.Count.ToString() + " unfinished downloads.";
        }
    }
}