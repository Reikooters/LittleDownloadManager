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
            XPTable.Models.Row row9 = new XPTable.Models.Row();
            XPTable.Models.Cell cell25 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle25 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell26 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle26 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell27 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle27 = new XPTable.Models.CellStyle();
            XPTable.Models.Row row10 = new XPTable.Models.Row();
            XPTable.Models.Cell cell28 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle28 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell29 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle29 = new XPTable.Models.CellStyle();
            XPTable.Models.Cell cell30 = new XPTable.Models.Cell();
            XPTable.Models.CellStyle cellStyle30 = new XPTable.Models.CellStyle();
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder1 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer1 = new XPTable.Renderers.DragDropRenderer();
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Incomplete");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Complete");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.table1 = new XPTable.Models.Table();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
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
            cellStyle25.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle25.BackColor = System.Drawing.Color.Empty;
            cellStyle25.Font = null;
            cellStyle25.ForeColor = System.Drawing.Color.Empty;
            cellStyle25.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle25.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle25.WordWrap = false;
            cell25.CellStyle = cellStyle25;
            cell25.ContentWidth = 49;
            cell25.Text = "2nd Row";
            cell25.ToolTipText = "";
            cell25.WordWrap = false;
            cellStyle26.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle26.BackColor = System.Drawing.Color.Empty;
            cellStyle26.Font = null;
            cellStyle26.ForeColor = System.Drawing.Color.Empty;
            cellStyle26.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle26.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle26.WordWrap = false;
            cell26.CellStyle = cellStyle26;
            cell26.ContentWidth = 64;
            cell26.Text = "Second row";
            cell26.ToolTipText = "";
            cell26.WordWrap = false;
            cellStyle27.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle27.BackColor = System.Drawing.Color.Empty;
            cellStyle27.Font = null;
            cellStyle27.ForeColor = System.Drawing.Color.Empty;
            cellStyle27.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle27.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle27.WordWrap = false;
            cell27.CellStyle = cellStyle27;
            cell27.ContentWidth = 0;
            cell27.Data = 33;
            cell27.WordWrap = false;
            row9.Cells.AddRange(new XPTable.Models.Cell[] {
            cell25,
            cell26,
            cell27});
            row9.ChildIndex = 0;
            row9.Editable = false;
            row9.ExpandSubRows = true;
            row9.Height = 22;
            cellStyle28.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle28.BackColor = System.Drawing.Color.Empty;
            cellStyle28.Font = null;
            cellStyle28.ForeColor = System.Drawing.Color.Empty;
            cellStyle28.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle28.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle28.WordWrap = false;
            cell28.CellStyle = cellStyle28;
            cell28.ContentWidth = 48;
            cell28.Data = "";
            cell28.Text = "Hello.jpg";
            cell28.WordWrap = false;
            cellStyle29.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle29.BackColor = System.Drawing.Color.Empty;
            cellStyle29.Font = null;
            cellStyle29.ForeColor = System.Drawing.Color.Empty;
            cellStyle29.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle29.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle29.WordWrap = false;
            cell29.CellStyle = cellStyle29;
            cell29.ContentWidth = 118;
            cell29.Data = "";
            cell29.Text = "http://website/Hello.jpg";
            cell29.WordWrap = false;
            cellStyle30.Alignment = XPTable.Models.ColumnAlignment.Left;
            cellStyle30.BackColor = System.Drawing.Color.Empty;
            cellStyle30.Font = null;
            cellStyle30.ForeColor = System.Drawing.Color.Empty;
            cellStyle30.LineAlignment = XPTable.Models.RowAlignment.Center;
            cellStyle30.Padding = new XPTable.Models.CellPadding(0, 0, 0, 0);
            cellStyle30.WordWrap = false;
            cell30.CellStyle = cellStyle30;
            cell30.ContentWidth = 0;
            cell30.Data = 25;
            cell30.Tag = "";
            cell30.Text = "";
            cell30.ToolTipText = "";
            cell30.WordWrap = false;
            row10.Cells.AddRange(new XPTable.Models.Cell[] {
            cell28,
            cell29,
            cell30});
            row10.ChildIndex = 0;
            row10.Editable = false;
            row10.ExpandSubRows = true;
            row10.Height = 22;
            this.tableModel1.Rows.AddRange(new XPTable.Models.Row[] {
            row9,
            row10});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(785, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
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
            this.table1.Size = new System.Drawing.Size(526, 449);
            this.table1.TabIndex = 0;
            this.table1.TableModel = this.tableModel1;
            this.table1.Text = "table1";
            this.table1.UnfocusedBorderColor = System.Drawing.Color.Black;
            // After table has been filled, sort it by filename (ascending)
            this.table1.Sort(0, System.Windows.Forms.SortOrder.Ascending);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Indent = 19;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            treeNode13.Name = "Node0";
            treeNode13.Text = "All";
            treeNode14.ForeColor = System.Drawing.Color.Red;
            treeNode14.Name = "Node1";
            treeNode14.Text = "Incomplete";
            treeNode15.ForeColor = System.Drawing.Color.Green;
            treeNode15.Name = "Node2";
            treeNode15.Text = "Complete";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(255, 449);
            this.treeView1.TabIndex = 6;
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
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDown);
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseUp);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

