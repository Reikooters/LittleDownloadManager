namespace LittleDownloadManager
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Incomplete");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Complete");
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder1 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer1 = new XPTable.Renderers.DragDropRenderer();
            XPTable.Models.Row row1 = new XPTable.Models.Row();
            XPTable.Models.Cell cell1 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle1 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell2 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle2 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell3 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle3 = new XPTable.Models.CellStyle();
            XPTable.Models.Row row2 = new XPTable.Models.Row();
            XPTable.Models.Cell cell4 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle4 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell5 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle5 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell6 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle6 = new XPTable.Models.CellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLittleDownloadManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.table1 = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.textColumn2 = new XPTable.Models.TextColumn();
            this.progressBarColumn1 = new XPTable.Models.ProgressBarColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addURLToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // addURLToolStripMenuItem
            // 
            this.addURLToolStripMenuItem.Name = "addURLToolStripMenuItem";
            this.addURLToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.addURLToolStripMenuItem.Text = "Add URL";
            this.addURLToolStripMenuItem.Click += new System.EventHandler(this.addURLToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.helloToolStripMenuItem.Text = "Hello";
            this.helloToolStripMenuItem.Click += new System.EventHandler(this.helloToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutLittleDownloadManagerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutLittleDownloadManagerToolStripMenuItem
            // 
            this.aboutLittleDownloadManagerToolStripMenuItem.Name = "aboutLittleDownloadManagerToolStripMenuItem";
            this.aboutLittleDownloadManagerToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.aboutLittleDownloadManagerToolStripMenuItem.Text = "About Little Download Manager";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table1);
            this.splitContainer1.Size = new System.Drawing.Size(785, 473);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDown);
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseUp);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Indent = 19;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            treeNode1.Name = "Node0";
            treeNode1.Text = "All";
            treeNode2.ForeColor = System.Drawing.Color.Red;
            treeNode2.Name = "Node1";
            treeNode2.Text = "Incomplete";
            treeNode3.ForeColor = System.Drawing.Color.Green;
            treeNode3.Name = "Node2";
            treeNode3.Text = "Complete";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(255, 473);
            this.treeView1.TabIndex = 6;
            // 
            // table1
            // 
            this.table1.BorderColor = System.Drawing.Color.Black;
            this.table1.ColumnModel = this.columnModel1;
            this.table1.DataMember = null;
            this.table1.DataSourceColumnBinder = dataSourceColumnBinder1;
            this.table1.Dock = System.Windows.Forms.DockStyle.Fill;
            dragDropRenderer1.ForeColor = System.Drawing.Color.Red;
            this.table1.DragDropRenderer = dragDropRenderer1;
            this.table1.FullRowSelect = true;
            this.table1.GridLines = XPTable.Models.GridLines.Both;
            this.table1.GridLinesContrainedToData = false;
            this.table1.Location = new System.Drawing.Point(0, 0);
            this.table1.MultiSelect = true;
            this.table1.Name = "table1";
            this.table1.NoItemsText = "There are no items in this list.";
            this.table1.ShowSelectionRectangle = false;
            this.table1.Size = new System.Drawing.Size(526, 473);
            this.table1.TabIndex = 0;
            this.table1.TableModel = this.tableModel1;
            this.table1.Text = "table1";
            this.table1.UnfocusedBorderColor = System.Drawing.Color.Black;
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.textColumn1,
            this.textColumn2,
            this.progressBarColumn1});
            this.columnModel1.HeaderHeight = 24;
            // Sort the table by Filename (0th column)
            this.table1.Sort(0, System.Windows.Forms.SortOrder.Ascending);
            // 
            // textColumn1
            // 
            this.textColumn1.Editable = false;
            this.textColumn1.IsTextTrimmed = false;
            this.textColumn1.Text = "Filename";
            this.textColumn1.Width = 175;
            // 
            // textColumn2
            // 
            this.textColumn2.Editable = false;
            this.textColumn2.IsTextTrimmed = false;
            this.textColumn2.Text = "URL";
            this.textColumn2.Width = 175;
            // 
            // progressBarColumn1
            // 
            this.progressBarColumn1.IsTextTrimmed = false;
            this.progressBarColumn1.Text = "Progress";
            this.progressBarColumn1.Width = 100;
            // 
            // tableModel1
            // 
            this.tableModel1.RowHeight = 22;
            cellStyle1.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle1.BackColor = System.Drawing.Color.Empty;
            cellStyle1.Font = null;
            cellStyle1.ForeColor = System.Drawing.Color.Empty;
            cellStyle1.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle1.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle1.WordWrap = false;
            cell1.CellStyle = cellStyle1;
            cell1.ContentWidth = 48;
            cell1.Data = "";
            cell1.Text = "Hello.jpg";
            cell1.WordWrap = false;
            cellStyle2.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle2.BackColor = System.Drawing.Color.Empty;
            cellStyle2.Font = null;
            cellStyle2.ForeColor = System.Drawing.Color.Empty;
            cellStyle2.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle2.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle2.WordWrap = false;
            cell2.CellStyle = cellStyle2;
            cell2.ContentWidth = 118;
            cell2.Data = "";
            cell2.Text = "http://website/Hello.jpg";
            cell2.WordWrap = false;
            cellStyle3.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle3.BackColor = System.Drawing.Color.Empty;
            cellStyle3.Font = null;
            cellStyle3.ForeColor = System.Drawing.Color.Empty;
            cellStyle3.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle3.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle3.WordWrap = false;
            cell3.CellStyle = cellStyle3;
            cell3.ContentWidth = 0;
            cell3.Data = 25;
            cell3.Tag = "";
            cell3.Text = "";
            cell3.ToolTipText = "";
            cell3.WordWrap = false;
            row1.Cells.AddRange(new XPTable.Models.Cell[] {
            cell1,
            cell2,
            cell3});
            row1.ChildIndex = 0;
            row1.Editable = false;
            row1.ExpandSubRows = true;
            row1.Height = 22;
            cellStyle4.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle4.BackColor = System.Drawing.Color.Empty;
            cellStyle4.Font = null;
            cellStyle4.ForeColor = System.Drawing.Color.Empty;
            cellStyle4.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle4.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle4.WordWrap = false;
            cell4.CellStyle = cellStyle4;
            cell4.ContentWidth = 49;
            cell4.Text = "2nd Row";
            cell4.ToolTipText = "";
            cell4.WordWrap = false;
            cellStyle5.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle5.BackColor = System.Drawing.Color.Empty;
            cellStyle5.Font = null;
            cellStyle5.ForeColor = System.Drawing.Color.Empty;
            cellStyle5.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle5.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle5.WordWrap = false;
            cell5.CellStyle = cellStyle5;
            cell5.ContentWidth = 64;
            cell5.Text = "Second row";
            cell5.ToolTipText = "";
            cell5.WordWrap = false;
            cellStyle6.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle6.BackColor = System.Drawing.Color.Empty;
            cellStyle6.Font = null;
            cellStyle6.ForeColor = System.Drawing.Color.Empty;
            cellStyle6.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle6.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle6.WordWrap = false;
            cell6.CellStyle = cellStyle6;
            cell6.ContentWidth = 0;
            cell6.Data = 33;
            cell6.WordWrap = false;
            row2.Cells.AddRange(new XPTable.Models.Cell[] {
            cell4,
            cell5,
            cell6});
            row2.ChildIndex = 0;
            row2.Editable = false;
            row2.ExpandSubRows = true;
            row2.Height = 22;
            this.tableModel1.Rows.AddRange(new XPTable.Models.Row[] {
            row1,
            row2});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Little Download Manager v0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem addURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLittleDownloadManagerToolStripMenuItem;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TableModel tableModel1;
        private XPTable.Models.TextColumn textColumn1;
        private XPTable.Models.TextColumn textColumn2;
        private XPTable.Models.ProgressBarColumn progressBarColumn1;
        private XPTable.Models.Table table1;
    }
}

