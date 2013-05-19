using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace LittleDownloadManager
{
    public partial class frmMain : Form
    {
        public QueueManager queueManager = null;

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

        public void addURLToTable(String filename, String url)
        {
            // Create new cell variables
            XPTable.Models.Cell[] cells = new XPTable.Models.Cell[10];

            for (int i = 0; i < 10; ++i)
            {
                cells[i] = new XPTable.Models.Cell();
            }

            // Put the cell data together
            Uri uri = new Uri(url);
            cells[0].Data = table.RowCount + 1;
            cells[1].Text = cells[1].ToolTipText = System.IO.Path.GetFileName(filename);
            cells[2].Text = "size";
            cells[3].Data = 0;
            cells[4].Text = "status";
            cells[5].Text = "speed";
            cells[6].Text = "eta";
            cells[7].Text = cells[7].ToolTipText = url;
            cells[8].Text = cells[8].ToolTipText = filename;

            // Put the cells together into a row
            XPTable.Models.Row row = new XPTable.Models.Row(
                cells
            );
            row.Height = 18;

            // Add the row to the table
            tableModel.Rows.Add(row);
        }

        public void addURLToTableAndUpdateStatusBar(String filename, String url)
        {
            // Add URL to table
            addURLToTable(filename, url);

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
                    MessageBox.Show("A web browser could not be detected on your computer, so the site could not be loaded.\r\n\r\nYou can visit the website manually at: " + target + "\r\n\r\n\r\nError Info: " + noBrowser.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception other)
            {
                MessageBox.Show("An error occured when trying to access the site in your default web browser.\r\n\r\nYou can visit the website manually at: " + target + "\r\n\r\n\r\nError Info: " + other.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutLittleDownloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmAboutBox();
            f.ShowDialog();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            // Make sure there are items in the list
            if (table.RowCount == 0)
                return;

            // Get selected rows
            int[] rows = table.SelectedIndicies;

            for (int i = 0; i < rows.Length; ++i)
            {
                // Delete from queue manager
                queueManager.delItem("Default", rows[i] - i);

                // Delete from table
                table.TableModel.Rows.RemoveAt(rows[i] - i);
            }

            // Save queue manager data to file.
            queueManager.save();

            // Now we need to fix up all the priority numbers in the table
            resortPriority();

            // Update the status bar.
            updateStatusBar();
        }

        private void resortPriority()
        {
            // First store the current sorting method of the table
            int currSortIdx = table.SortingColumn;
            SortOrder currSortOrder = table.ColumnModel.Columns[table.SortingColumn].SortOrder;

            // Now we change the sorting to priority (ascending)
            table.Sort(0, SortOrder.Ascending);

            // Now we loop through and reassign all the priorities based on
            // their new index.
            for (int i = 0; i < table.RowCount; ++i)
            {
                table.TableModel.Rows[i].Cells[0].Data = i + 1;
            }

            // Lastly, put back the sort method to how it was.
            table.Sort(currSortIdx, currSortOrder);
        }

        private void tsbPriorityUp_Click(object sender, EventArgs e)
        {
            changePriorityOfSelected(true);
        }

        private void tsbPriorityDown_Click(object sender, EventArgs e)
        {
            changePriorityOfSelected(false);
        }

        // moveUp should be false if we want to move down.
        private void changePriorityOfSelected(bool moveUp)
        {
            // Make sure there are at least 2 items in the list
            if (table.RowCount < 2)
                return;

            // First store the current sorting method of the table
            int currSortIdx = table.SortingColumn;
            SortOrder currSortOrder = table.ColumnModel.Columns[table.SortingColumn].SortOrder;

            // Now we change the sorting to priority (ascending)
            table.Sort(0, SortOrder.Ascending);

            // Next, make sure the first item isn't selected if moving up,
            // or the last item selected if moving down.
            int moveValue;

            if (moveUp)
            {
                // Make sure first item is not selected.
                if (table.TableModel.Rows[0].AnyCellsSelected)
                {
                    // Don't move.
                    // Put back the sort method to how it was.
                    table.Sort(currSortIdx, currSortOrder);
                    return;
                }
                moveValue = -1;
            }
            else
            {
                // Make sure last item is not selected.
                if (table.TableModel.Rows[table.RowCount - 1].AnyCellsSelected)
                {
                    // Don't move.
                    // Put back the sort method to how it was.
                    table.Sort(currSortIdx, currSortOrder);
                    return;
                }
                moveValue = 1;
            }

            // If the check was ok, we loop through to do the work
            int currIdx;
            int[] selected = table.SelectedIndicies;
            object tmpData;
            string tmpText;
            string tmpToolTipText;

            // I feel this part could be more concise (lots of repeated code).
            // However, I can't seem to work out how to get both directions in
            // one loop, and I don't want to spend any more time on it now.
            if (moveUp)
            {
                for (int i = 0; i < selected.Length; ++i)
                {
                    currIdx = selected[i];

                    // Swap items in Queue Manager
                    queueManager.swap("Default", currIdx, currIdx + moveValue);

                    // Swap items in table
                    table.TableModel.Rows[currIdx + moveValue].Cells[0].Data = (int)(table.TableModel.Rows[currIdx + moveValue].Cells[0].Data) + 1;
                    table.TableModel.Rows[currIdx].Cells[0].Data = (int)(table.TableModel.Rows[currIdx].Cells[0].Data) - 1;

                    for (int j = 0; j < table.TableModel.Rows[currIdx].Cells.Count; ++j)
                    {
                        // Make backup copy of cell data
                        tmpData = table.TableModel.Rows[currIdx].Cells[j].Data;
                        tmpText = table.TableModel.Rows[currIdx].Cells[j].Text;
                        tmpToolTipText = table.TableModel.Rows[currIdx].Cells[j].ToolTipText;

                        // Copy second cell data to first cell data
                        table.TableModel.Rows[currIdx].Cells[j].Data = table.TableModel.Rows[currIdx + moveValue].Cells[j].Data;
                        table.TableModel.Rows[currIdx].Cells[j].Text = table.TableModel.Rows[currIdx + moveValue].Cells[j].Text;
                        table.TableModel.Rows[currIdx].Cells[j].ToolTipText = table.TableModel.Rows[currIdx + moveValue].Cells[j].ToolTipText;

                        // Set second cell data to first cell data (from backup)
                        table.TableModel.Rows[currIdx + moveValue].Cells[j].Data = tmpData;
                        table.TableModel.Rows[currIdx + moveValue].Cells[j].Text = tmpText;
                        table.TableModel.Rows[currIdx + moveValue].Cells[j].ToolTipText = tmpToolTipText;
                    }
                }
            }
            else
            {
                for (int i = selected.Length - 1; i >= 0; --i)
                {
                    currIdx = selected[i];

                    // Swap items in Queue Manager
                    queueManager.swap("Default", currIdx, currIdx + moveValue);

                    // Swap items in table
                    table.TableModel.Rows[currIdx + moveValue].Cells[0].Data = (int)(table.TableModel.Rows[currIdx + moveValue].Cells[0].Data) - 1;
                    table.TableModel.Rows[currIdx].Cells[0].Data = (int)(table.TableModel.Rows[currIdx].Cells[0].Data) + 1;

                    for (int j = 0; j < table.TableModel.Rows[currIdx].Cells.Count; ++j)
                    {
                        // Make backup copy of cell data
                        tmpData = table.TableModel.Rows[currIdx].Cells[j].Data;
                        tmpText = table.TableModel.Rows[currIdx].Cells[j].Text;
                        tmpToolTipText = table.TableModel.Rows[currIdx].Cells[j].ToolTipText;

                        // Copy second cell data to first cell data
                        table.TableModel.Rows[currIdx].Cells[j].Data = table.TableModel.Rows[currIdx + moveValue].Cells[j].Data;
                        table.TableModel.Rows[currIdx].Cells[j].Text = table.TableModel.Rows[currIdx + moveValue].Cells[j].Text;
                        table.TableModel.Rows[currIdx].Cells[j].ToolTipText = table.TableModel.Rows[currIdx + moveValue].Cells[j].ToolTipText;

                        // Set second cell data to first cell data (from backup)
                        table.TableModel.Rows[currIdx + moveValue].Cells[j].Data = tmpData;
                        table.TableModel.Rows[currIdx + moveValue].Cells[j].Text = tmpText;
                        table.TableModel.Rows[currIdx + moveValue].Cells[j].ToolTipText = tmpToolTipText;
                    }
                }
            }

            // Put back the original selections
            table.TableModel.Selections.Clear();

            XPTable.Models.CellPos cp = new XPTable.Models.CellPos();

            for (int i = 0; i < selected.Length; ++i)
            {
                cp.Row = selected[i] + moveValue;
                table.TableModel.Selections.AddCell(cp);
            }

            // Save queue manager data to file.
            queueManager.save();

            // Put back the sort method to how it was.
            table.Sort(currSortIdx, currSortOrder);
        }

        private void tsbCopyToClipboard_Click(object sender, EventArgs e)
        {
            copyLinksToClipboard();
        }

        private void mnuTableCopyLinksToClipboard_Click(object sender, EventArgs e)
        {
            copyLinksToClipboard();
        }

        private void copyLinksToClipboard()
        {
            // Make sure there is at least one link selected
            if (table.SelectedIndicies.Length == 0)
            {
                // Give an error message
                MessageBox.Show("No items were selected, so no links were copied.\r\nPlease select one or more items first.",
                    "Little Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Concatenate all the selected links into a string
            string links = "";

            for (int i = 0; i < table.SelectedIndicies.Length; ++i)
            {
                links += table.TableModel.Rows[table.SelectedIndicies[i]].Cells[7].Text + "\r\n";
            }

            // Put the string onto the clipboard
            Clipboard.SetText(links, TextDataFormat.UnicodeText);

            // Give a confirmation message
            string message;

            if (table.SelectedIndicies.Length > 1)
                message = "The URLs for the selected " + table.SelectedIndicies.Length.ToString() + " items were copied to the clipboard.";
            else
                message = "The URL for the selected item was copied to the clipboard.";

            MessageBox.Show(message, "Little Download Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This function written by Anuraj P and taken from:
        // http://www.dotnetthoughts.net/how-to-check-remote-file-exists-using-c/
        private bool remoteFileExists(string url, out long filesize)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    long contentLength;
                    if (long.TryParse(response.Headers.Get("Content-Length"), out contentLength))
                    {
                        filesize = contentLength;
                    }
                    else
                    {
                        filesize = -1;
                    }
                    //Returns TRUE if the Status code == 200
                    return (response.StatusCode == HttpStatusCode.OK);
                }
            }
            catch
            {
                //Any exception will returns false.
                filesize = -1;
                return false;
            }
        }

        private void tsbValidateLinks_Click(object sender, EventArgs e)
        {
            long filesize;
            bool exists;

            for (int i = 0; i < table.RowCount; ++i)
            {
                // Check exists + filesize
                exists = remoteFileExists(table.TableModel.Rows[i].Cells[7].Text, out filesize);

                // Set status
                if (exists)
                    table.TableModel.Rows[i].Cells[4].Text = "OK";
                else
                    table.TableModel.Rows[i].Cells[4].Text = "Error";

                // Set filesize
                if (filesize != -1)
                    table.TableModel.Rows[i].Cells[2].Text = filesize.ToString();
                else
                    table.TableModel.Rows[i].Cells[2].Text = "?";

                // Repaint the window after each URL is checked
                Application.DoEvents();
            }

            /*
            System.Net.WebRequest req = System.Net.HttpWebRequest.Create("http://stackoverflow.com/robots.txt");
            req.Method = "HEAD";
            using (System.Net.WebResponse resp = req.GetResponse())
            {
                int ContentLength;
                if (int.TryParse(resp.Headers.Get("Content-Length"), out ContentLength))
                {
                    //Do something useful with ContentLength here 
                }
            }
            */
        }
    }
}