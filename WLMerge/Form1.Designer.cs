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
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.checkBoxHideEmptyColumns = new System.Windows.Forms.CheckBox();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripDgvRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTransform = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyFilledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedShowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedListIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryItemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.contextMenuStripDgvRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowsForFile
            // 
            this.buttonBrowsForFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowsForFile.Location = new System.Drawing.Point(4, 485);
            this.buttonBrowsForFile.Name = "buttonBrowsForFile";
            this.buttonBrowsForFile.Size = new System.Drawing.Size(142, 37);
            this.buttonBrowsForFile.TabIndex = 2;
            this.buttonBrowsForFile.Text = "&Browse for file(s)";
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
            this.tableLayoutPanelMain.Controls.Add(this.buttonClear, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonBrowsForFile, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewItems, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExit, 4, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExport, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.checkBoxHideEmptyColumns, 2, 1);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(758, 529);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Location = new System.Drawing.Point(155, 485);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 37);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "&Clear";
            this.toolTipMain.SetToolTip(this.buttonClear, "Clear all items from list");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.AutoGenerateColumns = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemTypeDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.maxPriceDataGridViewTextBoxColumn,
            this.minQtyDataGridViewTextBoxColumn,
            this.qtyFilledDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.notifyDataGridViewTextBoxColumn,
            this.wantedShowDataGridViewTextBoxColumn,
            this.wantedListIdDataGridViewTextBoxColumn});
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewItems, 5);
            this.dataGridViewItems.DataSource = this.inventoryItemListBindingSource;
            this.dataGridViewItems.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.Size = new System.Drawing.Size(752, 473);
            this.dataGridViewItems.TabIndex = 1;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewItems.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridViewItems_CellContextMenuStripNeeded);
            this.dataGridViewItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewItems_CellFormatting);
            this.dataGridViewItems.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItems_CellMouseDown);
            this.dataGridViewItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewItems_RowsAdded);
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
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.Location = new System.Drawing.Point(457, 485);
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
            this.checkBoxHideEmptyColumns.Location = new System.Drawing.Point(306, 485);
            this.checkBoxHideEmptyColumns.Name = "checkBoxHideEmptyColumns";
            this.checkBoxHideEmptyColumns.Size = new System.Drawing.Size(142, 37);
            this.checkBoxHideEmptyColumns.TabIndex = 6;
            this.checkBoxHideEmptyColumns.Text = "&Hide Empty";
            this.checkBoxHideEmptyColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipMain.SetToolTip(this.checkBoxHideEmptyColumns, "Hide empty columns (or show if they are already hidden)");
            this.checkBoxHideEmptyColumns.UseVisualStyleBackColor = true;
            this.checkBoxHideEmptyColumns.CheckedChanged += new System.EventHandler(this.checkBoxHideEmptyColumns_CheckedChanged);
            // 
            // openFileDialogXml
            // 
            this.openFileDialogXml.Filter = "XML files|*.xml";
            this.openFileDialogXml.Multiselect = true;
            this.openFileDialogXml.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogXml_FileOk);
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
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxPriceDataGridViewTextBoxColumn
            // 
            this.maxPriceDataGridViewTextBoxColumn.DataPropertyName = "MaxPrice";
            this.maxPriceDataGridViewTextBoxColumn.HeaderText = "MaxPrice";
            this.maxPriceDataGridViewTextBoxColumn.Name = "maxPriceDataGridViewTextBoxColumn";
            // 
            // minQtyDataGridViewTextBoxColumn
            // 
            this.minQtyDataGridViewTextBoxColumn.DataPropertyName = "MinQty";
            this.minQtyDataGridViewTextBoxColumn.HeaderText = "MinQty";
            this.minQtyDataGridViewTextBoxColumn.Name = "minQtyDataGridViewTextBoxColumn";
            // 
            // qtyFilledDataGridViewTextBoxColumn
            // 
            this.qtyFilledDataGridViewTextBoxColumn.DataPropertyName = "QtyFilled";
            this.qtyFilledDataGridViewTextBoxColumn.HeaderText = "QtyFilled";
            this.qtyFilledDataGridViewTextBoxColumn.Name = "qtyFilledDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // notifyDataGridViewTextBoxColumn
            // 
            this.notifyDataGridViewTextBoxColumn.DataPropertyName = "Notify";
            this.notifyDataGridViewTextBoxColumn.HeaderText = "Notify";
            this.notifyDataGridViewTextBoxColumn.Name = "notifyDataGridViewTextBoxColumn";
            // 
            // wantedShowDataGridViewTextBoxColumn
            // 
            this.wantedShowDataGridViewTextBoxColumn.DataPropertyName = "WantedShow";
            this.wantedShowDataGridViewTextBoxColumn.HeaderText = "WantedShow";
            this.wantedShowDataGridViewTextBoxColumn.Name = "wantedShowDataGridViewTextBoxColumn";
            // 
            // wantedListIdDataGridViewTextBoxColumn
            // 
            this.wantedListIdDataGridViewTextBoxColumn.DataPropertyName = "WantedListId";
            this.wantedListIdDataGridViewTextBoxColumn.HeaderText = "WantedListId";
            this.wantedListIdDataGridViewTextBoxColumn.Name = "wantedListIdDataGridViewTextBoxColumn";
            // 
            // inventoryItemListBindingSource
            // 
            this.inventoryItemListBindingSource.DataSource = typeof(WLMerge.InventoryItemList);
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
            this.Text = "WL Merge: drop or browse XML-files";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.contextMenuStripDgvRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemListBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyFilledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedShowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedListIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDgvRightClick;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTransform;
    }
}

