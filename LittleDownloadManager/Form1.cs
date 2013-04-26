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
            Form f = new AddURL();
            f.ShowDialog();
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
    }
}