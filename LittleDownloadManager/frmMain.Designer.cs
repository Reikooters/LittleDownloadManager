namespace LittleDownloadManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder2 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer2 = new XPTable.Renderers.DragDropRenderer();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Test");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Incomplete", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Complete");
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLittleDownloadManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnModel = new XPTable.Models.ColumnModel();
            this.textColumn1 = new XPTable.Models.TextColumn();
            this.textColumn2 = new XPTable.Models.TextColumn();
            this.progressBarColumn1 = new XPTable.Models.ProgressBarColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAddUrl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbForceDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbPriorityDown = new System.Windows.Forms.ToolStripButton();
            this.tsbPriorityUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbValidateLinks = new System.Windows.Forms.ToolStripButton();
            this.tsbCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOptions = new System.Windows.Forms.ToolStripButton();
            this.tsbScheduler = new System.Windows.Forms.ToolStripButton();
            this.tsbWebsite = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tstbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.table = new XPTable.Models.Table();
            this.tableModel = new XPTable.Models.TableModel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(785, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 497);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(785, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // columnModel
            // 
            this.columnModel.Columns.AddRange(new XPTable.Models.Column[] {
            this.textColumn1,
            this.textColumn2,
            this.progressBarColumn1,
            this.textColumn1,
            this.textColumn2,
            this.progressBarColumn1,
            this.textColumn1,
            this.textColumn2,
            this.progressBarColumn1});
            this.columnModel.HeaderHeight = 24;
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
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddUrl,
            this.toolStripSeparator1,
            this.tsbDownload,
            this.tsbForceDownload,
            this.tsbStop,
            this.tsbPriorityDown,
            this.tsbPriorityUp,
            this.toolStripSeparator5,
            this.tsbOpen,
            this.tsbDelete,
            this.toolStripSeparator2,
            this.tsbValidateLinks,
            this.tsbCopyToClipboard,
            this.toolStripSeparator4,
            this.tsbOptions,
            this.tsbScheduler,
            this.tsbWebsite,
            this.tsbSearch,
            this.tstbSearch});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(785, 37);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbAddUrl
            // 
            this.tsbAddUrl.AutoSize = false;
            this.tsbAddUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddUrl.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddUrl.Image")));
            this.tsbAddUrl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddUrl.Name = "tsbAddUrl";
            this.tsbAddUrl.Size = new System.Drawing.Size(36, 36);
            this.tsbAddUrl.Text = "Add URL";
            this.tsbAddUrl.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbDownload
            // 
            this.tsbDownload.AutoSize = false;
            this.tsbDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDownload.Image = ((System.Drawing.Image)(resources.GetObject("tsbDownload.Image")));
            this.tsbDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDownload.Name = "tsbDownload";
            this.tsbDownload.Size = new System.Drawing.Size(36, 36);
            this.tsbDownload.Text = "toolStripButton2";
            this.tsbDownload.ToolTipText = "Download/Queue";
            // 
            // tsbForceDownload
            // 
            this.tsbForceDownload.AutoSize = false;
            this.tsbForceDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForceDownload.Image = ((System.Drawing.Image)(resources.GetObject("tsbForceDownload.Image")));
            this.tsbForceDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbForceDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForceDownload.Name = "tsbForceDownload";
            this.tsbForceDownload.Size = new System.Drawing.Size(36, 36);
            this.tsbForceDownload.Text = "toolStripButton9";
            this.tsbForceDownload.ToolTipText = "Force Download";
            // 
            // tsbStop
            // 
            this.tsbStop.AutoSize = false;
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(36, 36);
            this.tsbStop.Text = "toolStripButton3";
            this.tsbStop.ToolTipText = "Stop";
            // 
            // tsbPriorityDown
            // 
            this.tsbPriorityDown.AutoSize = false;
            this.tsbPriorityDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPriorityDown.Image = ((System.Drawing.Image)(resources.GetObject("tsbPriorityDown.Image")));
            this.tsbPriorityDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPriorityDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPriorityDown.Name = "tsbPriorityDown";
            this.tsbPriorityDown.Size = new System.Drawing.Size(36, 36);
            this.tsbPriorityDown.Text = "toolStripButton13";
            this.tsbPriorityDown.ToolTipText = "Lower Priority";
            // 
            // tsbPriorityUp
            // 
            this.tsbPriorityUp.AutoSize = false;
            this.tsbPriorityUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPriorityUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbPriorityUp.Image")));
            this.tsbPriorityUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPriorityUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPriorityUp.Name = "tsbPriorityUp";
            this.tsbPriorityUp.Size = new System.Drawing.Size(36, 36);
            this.tsbPriorityUp.Text = "toolStripButton12";
            this.tsbPriorityUp.ToolTipText = "Raise Priority";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbOpen
            // 
            this.tsbOpen.AutoSize = false;
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(36, 36);
            this.tsbOpen.Text = "toolStripButton5";
            this.tsbOpen.ToolTipText = "Open File";
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(36, 36);
            this.tsbDelete.Text = "toolStripButton4";
            this.tsbDelete.ToolTipText = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbValidateLinks
            // 
            this.tsbValidateLinks.AutoSize = false;
            this.tsbValidateLinks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbValidateLinks.Image = ((System.Drawing.Image)(resources.GetObject("tsbValidateLinks.Image")));
            this.tsbValidateLinks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbValidateLinks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbValidateLinks.Name = "tsbValidateLinks";
            this.tsbValidateLinks.Size = new System.Drawing.Size(36, 36);
            this.tsbValidateLinks.Text = "toolStripButton10";
            this.tsbValidateLinks.ToolTipText = "Validate Links";
            // 
            // tsbCopyToClipboard
            // 
            this.tsbCopyToClipboard.AutoSize = false;
            this.tsbCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopyToClipboard.Image")));
            this.tsbCopyToClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyToClipboard.Name = "tsbCopyToClipboard";
            this.tsbCopyToClipboard.Size = new System.Drawing.Size(36, 36);
            this.tsbCopyToClipboard.Text = "toolStripButton8";
            this.tsbCopyToClipboard.ToolTipText = "Copy Links To Clipboard";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbOptions
            // 
            this.tsbOptions.AutoSize = false;
            this.tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptions.Image")));
            this.tsbOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Size = new System.Drawing.Size(36, 36);
            this.tsbOptions.Text = "toolStripButton6";
            this.tsbOptions.ToolTipText = "Options";
            // 
            // tsbScheduler
            // 
            this.tsbScheduler.AutoSize = false;
            this.tsbScheduler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScheduler.Image = ((System.Drawing.Image)(resources.GetObject("tsbScheduler.Image")));
            this.tsbScheduler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbScheduler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScheduler.Name = "tsbScheduler";
            this.tsbScheduler.Size = new System.Drawing.Size(36, 36);
            this.tsbScheduler.Text = "toolStripButton7";
            this.tsbScheduler.ToolTipText = "Scheduler";
            // 
            // tsbWebsite
            // 
            this.tsbWebsite.AutoSize = false;
            this.tsbWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWebsite.Image = ((System.Drawing.Image)(resources.GetObject("tsbWebsite.Image")));
            this.tsbWebsite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbWebsite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWebsite.Name = "tsbWebsite";
            this.tsbWebsite.Size = new System.Drawing.Size(36, 36);
            this.tsbWebsite.Text = "toolStripButton11";
            this.tsbWebsite.ToolTipText = "Visit Application\'s Website";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSearch.AutoSize = false;
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(36, 36);
            this.tsbSearch.Text = "Run Search";
            // 
            // tstbSearch
            // 
            this.tstbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstbSearch.Name = "tstbSearch";
            this.tstbSearch.Size = new System.Drawing.Size(150, 37);
            this.tstbSearch.ToolTipText = "Search Text";
            // 
            // table
            // 
            this.table.BorderColor = System.Drawing.Color.Black;
            this.table.ColumnModel = this.columnModel;
            this.table.DataMember = null;
            this.table.DataSourceColumnBinder = dataSourceColumnBinder2;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            dragDropRenderer2.ForeColor = System.Drawing.Color.Red;
            this.table.DragDropRenderer = dragDropRenderer2;
            this.table.FullRowSelect = true;
            this.table.GridLines = XPTable.Models.GridLines.Both;
            this.table.GridLinesContrainedToData = false;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.MultiSelect = true;
            this.table.Name = "table";
            this.table.NoItemsText = "There are no items in this list.";
            this.table.ShowSelectionRectangle = false;
            this.table.Size = new System.Drawing.Size(607, 433);
            this.table.TabIndex = 0;
            this.table.TableModel = this.tableModel;
            this.table.Text = "table1";
            this.table.UnfocusedBorderColor = System.Drawing.Color.Black;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvCategories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.table);
            this.splitContainer1.Size = new System.Drawing.Size(785, 433);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDown);
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseUp);
            // 
            // tvCategories
            // 
            this.tvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategories.FullRowSelect = true;
            this.tvCategories.HideSelection = false;
            this.tvCategories.ItemHeight = 22;
            this.tvCategories.Location = new System.Drawing.Point(0, 0);
            this.tvCategories.Name = "tvCategories";
            treeNode5.Name = "Node0";
            treeNode5.Text = "All";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Test";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Incomplete";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Complete";
            this.tvCategories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode8});
            this.tvCategories.ShowLines = false;
            this.tvCategories.Size = new System.Drawing.Size(174, 433);
            this.tvCategories.TabIndex = 0;
            this.tvCategories.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.tvCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Little Download Manager v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem addURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLittleDownloadManagerToolStripMenuItem;
        private XPTable.Models.ColumnModel columnModel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private XPTable.Models.Table table;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsbAddUrl;
        private System.Windows.Forms.TreeView tvCategories;
        private System.Windows.Forms.ToolStripButton tsbDownload;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbOptions;
        private System.Windows.Forms.ToolStripButton tsbCopyToClipboard;
        private System.Windows.Forms.ToolStripButton tsbScheduler;
        private System.Windows.Forms.ToolStripButton tsbForceDownload;
        private System.Windows.Forms.ToolStripButton tsbValidateLinks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbWebsite;
        private System.Windows.Forms.ToolStripButton tsbPriorityDown;
        private System.Windows.Forms.ToolStripButton tsbPriorityUp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripTextBox tstbSearch;
        private XPTable.Models.TextColumn textColumn1;
        private XPTable.Models.TextColumn textColumn2;
        private XPTable.Models.ProgressBarColumn progressBarColumn1;
        private XPTable.Models.TableModel tableModel;
    }
}

