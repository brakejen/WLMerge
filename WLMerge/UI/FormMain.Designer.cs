namespace WLMerge
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonBrowsForFile = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyFilled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WantedShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WantedListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryItemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.checkBoxHideEmptyColumns = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDownloadImages = new System.Windows.Forms.Button();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripDgvRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransform = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemListBindingSource)).BeginInit();
            this.contextMenuStripDgvRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowsForFile
            // 
            this.buttonBrowsForFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowsForFile.Location = new System.Drawing.Point(4, 6);
            this.buttonBrowsForFile.Name = "buttonBrowsForFile";
            this.buttonBrowsForFile.Size = new System.Drawing.Size(142, 37);
            this.buttonBrowsForFile.TabIndex = 2;
            this.buttonBrowsForFile.Text = "&Browse file(s)";
            this.toolTipMain.SetToolTip(this.buttonBrowsForFile, "Select XML-files to merge (or drop them into empty table above)");
            this.buttonBrowsForFile.UseVisualStyleBackColor = true;
            this.buttonBrowsForFile.Click += new System.EventHandler(this.buttonBrowsForFile_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 5;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewItems, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExit, 4, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonAbout, 3, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonBrowsForFile, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExport, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.checkBoxHideEmptyColumns, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonClear, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonDownloadImages, 4, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(758, 529);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.AutoGenerateColumns = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemType,
            this.Image,
            this.ItemId,
            this.Color,
            this.MaxPrice,
            this.MinQty,
            this.QtyFilled,
            this.Condition,
            this.Remarks,
            this.Notify,
            this.WantedShow,
            this.WantedListId});
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewItems, 5);
            this.dataGridViewItems.DataSource = this.inventoryItemListBindingSource;
            this.dataGridViewItems.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.Size = new System.Drawing.Size(752, 423);
            this.dataGridViewItems.TabIndex = 1;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewItems.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridViewItems_CellContextMenuStripNeeded);
            this.dataGridViewItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewItems_CellFormatting);
            this.dataGridViewItems.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItems_CellMouseDown);
            this.dataGridViewItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellValueChanged);
            this.dataGridViewItems.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewItems_RowPostPaint);
            this.dataGridViewItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewItems_RowsAdded);
            this.dataGridViewItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewItems_KeyDown);
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "ItemType";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            this.ItemType.ToolTipText = "[Read Only Column] Click to sort";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.ToolTipText = "[Read Only Column] Click to sort";
            // 
            // MaxPrice
            // 
            this.MaxPrice.DataPropertyName = "MaxPrice";
            this.MaxPrice.HeaderText = "MaxPrice";
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.ToolTipText = "Click to sort";
            // 
            // MinQty
            // 
            this.MinQty.DataPropertyName = "MinQty";
            this.MinQty.HeaderText = "MinQty";
            this.MinQty.Name = "MinQty";
            this.MinQty.ToolTipText = "Click to sort";
            // 
            // QtyFilled
            // 
            this.QtyFilled.DataPropertyName = "QtyFilled";
            this.QtyFilled.HeaderText = "QtyFilled";
            this.QtyFilled.Name = "QtyFilled";
            this.QtyFilled.ToolTipText = "Click to sort";
            // 
            // Condition
            // 
            this.Condition.DataPropertyName = "Condition";
            this.Condition.HeaderText = "Condition";
            this.Condition.Name = "Condition";
            this.Condition.ToolTipText = "Click to sort";
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ToolTipText = "Click to sort";
            // 
            // Notify
            // 
            this.Notify.DataPropertyName = "Notify";
            this.Notify.HeaderText = "Notify";
            this.Notify.Name = "Notify";
            this.Notify.ToolTipText = "Click to sort";
            // 
            // WantedShow
            // 
            this.WantedShow.DataPropertyName = "WantedShow";
            this.WantedShow.HeaderText = "WantedShow";
            this.WantedShow.Name = "WantedShow";
            this.WantedShow.ToolTipText = "Click to sort";
            // 
            // WantedListId
            // 
            this.WantedListId.DataPropertyName = "WantedListId";
            this.WantedListId.HeaderText = "WantedListId";
            this.WantedListId.Name = "WantedListId";
            this.WantedListId.ToolTipText = "Click to sort";
            // 
            // inventoryItemListBindingSource
            // 
            this.inventoryItemListBindingSource.DataSource = typeof(WLMerge.InventoryItemList);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(610, 485);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(142, 37);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAbout.Location = new System.Drawing.Point(457, 485);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(142, 37);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "&About";
            this.toolTipMain.SetToolTip(this.buttonAbout, "Clear all items from list");
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.Location = new System.Drawing.Point(155, 6);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(142, 37);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "&Export";
            this.toolTipMain.SetToolTip(this.buttonExport, "Export current list to XML (will be copied to clipbook)");
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // checkBoxHideEmptyColumns
            // 
            this.checkBoxHideEmptyColumns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxHideEmptyColumns.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxHideEmptyColumns.Location = new System.Drawing.Point(457, 6);
            this.checkBoxHideEmptyColumns.Name = "checkBoxHideEmptyColumns";
            this.checkBoxHideEmptyColumns.Size = new System.Drawing.Size(142, 37);
            this.checkBoxHideEmptyColumns.TabIndex = 6;
            this.checkBoxHideEmptyColumns.Text = "&Hide Empty";
            this.checkBoxHideEmptyColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipMain.SetToolTip(this.checkBoxHideEmptyColumns, "Hide empty columns (or show if they are already hidden)");
            this.checkBoxHideEmptyColumns.UseVisualStyleBackColor = true;
            this.checkBoxHideEmptyColumns.CheckedChanged += new System.EventHandler(this.checkBoxHideEmptyColumns_CheckedChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Location = new System.Drawing.Point(306, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 37);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "&Clear";
            this.toolTipMain.SetToolTip(this.buttonClear, "Clear all items from list");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDownloadImages
            // 
            this.buttonDownloadImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDownloadImages.Enabled = false;
            this.buttonDownloadImages.Location = new System.Drawing.Point(610, 6);
            this.buttonDownloadImages.Name = "buttonDownloadImages";
            this.buttonDownloadImages.Size = new System.Drawing.Size(142, 37);
            this.buttonDownloadImages.TabIndex = 8;
            this.buttonDownloadImages.Text = "&Download Images";
            this.toolTipMain.SetToolTip(this.buttonDownloadImages, "Download images for items");
            this.buttonDownloadImages.UseVisualStyleBackColor = true;
            this.buttonDownloadImages.Click += new System.EventHandler(this.buttonDownloadImages_Click);
            // 
            // openFileDialogXml
            // 
            this.openFileDialogXml.Filter = "XML files|*.xml";
            this.openFileDialogXml.Multiselect = true;
            // 
            // contextMenuStripDgvRightClick
            // 
            this.contextMenuStripDgvRightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDgvRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemClear,
            this.toolStripMenuItemSet,
            this.toolStripMenuItemTransform});
            this.contextMenuStripDgvRightClick.Name = "contextMenuStripDgvRightClick";
            this.contextMenuStripDgvRightClick.Size = new System.Drawing.Size(199, 76);
            // 
            // toolStripMenuItemClear
            // 
            this.toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            this.toolStripMenuItemClear.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItemClear.Text = "Clear column";
            this.toolStripMenuItemClear.Click += new System.EventHandler(this.toolStripMenuItemClear_Click);
            // 
            // toolStripMenuItemSet
            // 
            this.toolStripMenuItemSet.Name = "toolStripMenuItemSet";
            this.toolStripMenuItemSet.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItemSet.Text = "Set values...";
            this.toolStripMenuItemSet.Click += new System.EventHandler(this.toolStripMenuItemSet_Click);
            // 
            // toolStripMenuItemTransform
            // 
            this.toolStripMenuItemTransform.Name = "toolStripMenuItemTransform";
            this.toolStripMenuItemTransform.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItemTransform.Text = "Transform values...";
            this.toolStripMenuItemTransform.Click += new System.EventHandler(this.toolStripMenuItemTransform_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WL Merge: drop or browse XML-files";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemListBindingSource)).EndInit();
            this.contextMenuStripDgvRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowsForFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.BindingSource inventoryItemListBindingSource;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxHideEmptyColumns;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDgvRightClick;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransform;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonDownloadImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewLinkColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyFilled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notify;
        private System.Windows.Forms.DataGridViewTextBoxColumn WantedShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn WantedListId;
    }
}

