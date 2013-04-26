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
            XPTable.Models.Row row3 = new XPTable.Models.Row();
            XPTable.Models.Cell cell7 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle7 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell8 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle8 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell9 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle9 = new XPTable.Models.CellStyle();
            XPTable.Models.Row row4 = new XPTable.Models.Row();
            XPTable.Models.Cell cell10 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle10 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell11 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle11 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell12 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle12 = new XPTable.Models.CellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder2 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer2 = new XPTable.Renderers.DragDropRenderer();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Test");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Incomplete", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Complete");
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
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.textColumn2 = new XPTable.Models.TextColumn();
            this.progressBarColumn1 = new XPTable.Models.ProgressBarColumn();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.table1 = new XPTable.Models.Table();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // columnModel1
            // 
            this.columnModel1.Columns.AddRange(new XPTable.Models.Column[] {
            this.textColumn1,
            this.textColumn2,
            this.progressBarColumn1});
            this.columnModel1.HeaderHeight = 24;
            // 
            // textColumn1
            // 
            this.textColumn1.Editable = false;
            this.textColumn1.IsTextTrimmed = false;
            this.textColumn1.Text = "Filename";
            this.textColumn1.Width = 215;
            // 
            // textColumn2
            // 
            this.textColumn2.Editable = false;
            this.textColumn2.IsTextTrimmed = false;
            this.textColumn2.Text = "URL";
            this.textColumn2.Width = 255;
            // 
            // progressBarColumn1
            // 
            this.progressBarColumn1.IsTextTrimmed = false;
            this.progressBarColumn1.Text = "Progress";
            this.progressBarColumn1.Width = 120;
            // 
            // tableModel1
            // 
            this.tableModel1.RowHeight = 22;
            cellStyle7.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle7.BackColor = System.Drawing.Color.Empty;
            cellStyle7.Font = null;
            cellStyle7.ForeColor = System.Drawing.Color.Empty;
            cellStyle7.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle7.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle7.WordWrap = false;
            cell7.CellStyle = cellStyle7;
            cell7.ContentWidth = 49;
            cell7.Text = "2nd Row";
            cell7.ToolTipText = "";
            cell7.WordWrap = false;
            cellStyle8.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle8.BackColor = System.Drawing.Color.Empty;
            cellStyle8.Font = null;
            cellStyle8.ForeColor = System.Drawing.Color.Empty;
            cellStyle8.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle8.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle8.WordWrap = false;
            cell8.CellStyle = cellStyle8;
            cell8.ContentWidth = 64;
            cell8.Text = "Second row";
            cell8.ToolTipText = "";
            cell8.WordWrap = false;
            cellStyle9.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle9.BackColor = System.Drawing.Color.Empty;
            cellStyle9.Font = null;
            cellStyle9.ForeColor = System.Drawing.Color.Empty;
            cellStyle9.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle9.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle9.WordWrap = false;
            cell9.CellStyle = cellStyle9;
            cell9.ContentWidth = 0;
            cell9.Data = 33;
            cell9.WordWrap = false;
            row3.Cells.AddRange(new XPTable.Models.Cell[] {
            cell7,
            cell8,
            cell9});
            row3.ChildIndex = 0;
            row3.Editable = false;
            row3.ExpandSubRows = true;
            row3.Height = 22;
            cellStyle10.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle10.BackColor = System.Drawing.Color.Empty;
            cellStyle10.Font = null;
            cellStyle10.ForeColor = System.Drawing.Color.Empty;
            cellStyle10.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle10.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle10.WordWrap = false;
            cell10.CellStyle = cellStyle10;
            cell10.ContentWidth = 48;
            cell10.Data = "";
            cell10.Text = "Hello.jpg";
            cell10.WordWrap = false;
            cellStyle11.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle11.BackColor = System.Drawing.Color.Empty;
            cellStyle11.Font = null;
            cellStyle11.ForeColor = System.Drawing.Color.Empty;
            cellStyle11.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle11.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle11.WordWrap = false;
            cell11.CellStyle = cellStyle11;
            cell11.ContentWidth = 118;
            cell11.Data = "";
            cell11.Text = "http://website/Hello.jpg";
            cell11.WordWrap = false;
            cellStyle12.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle12.BackColor = System.Drawing.Color.Empty;
            cellStyle12.Font = null;
            cellStyle12.ForeColor = System.Drawing.Color.Empty;
            cellStyle12.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle12.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle12.WordWrap = false;
            cell12.CellStyle = cellStyle12;
            cell12.ContentWidth = 0;
            cell12.Data = 25;
            cell12.Tag = "";
            cell12.Text = "";
            cell12.ToolTipText = "";
            cell12.WordWrap = false;
            row4.Cells.AddRange(new XPTable.Models.Cell[] {
            cell10,
            cell11,
            cell12});
            row4.ChildIndex = 0;
            row4.Editable = false;
            row4.ExpandSubRows = true;
            row4.Height = 22;
            this.tableModel1.Rows.AddRange(new XPTable.Models.Row[] {
            row3,
            row4});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(785, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add URL";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // table1
            // 
            this.table1.BorderColor = System.Drawing.Color.Black;
            this.table1.ColumnModel = this.columnModel1;
            this.table1.DataMember = null;
            this.table1.DataSourceColumnBinder = dataSourceColumnBinder2;
            this.table1.Dock = System.Windows.Forms.DockStyle.Fill;
            dragDropRenderer2.ForeColor = System.Drawing.Color.Red;
            this.table1.DragDropRenderer = dragDropRenderer2;
            this.table1.FullRowSelect = true;
            this.table1.GridLines = XPTable.Models.GridLines.Both;
            this.table1.GridLinesContrainedToData = false;
            this.table1.Location = new System.Drawing.Point(0, 0);
            this.table1.MultiSelect = true;
            this.table1.Name = "table1";
            this.table1.NoItemsText = "There are no items in this list.";
            this.table1.ShowSelectionRectangle = false;
            this.table1.Size = new System.Drawing.Size(607, 449);
            this.table1.TabIndex = 0;
            this.table1.TableModel = this.tableModel1;
            this.table1.Text = "table1";
            this.table1.UnfocusedBorderColor = System.Drawing.Color.Black;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table1);
            this.splitContainer1.Size = new System.Drawing.Size(785, 449);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDown);
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseUp);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ItemHeight = 22;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Node0";
            treeNode5.Text = "All";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Test";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Incomplete";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Complete";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode8});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(174, 449);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Little Download Manager v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private XPTable.Models.Table table1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

