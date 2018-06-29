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
            this.buttonBrowsForFile = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mINQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTIFYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTORYITEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYITEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowsForFile
            // 
            this.buttonBrowsForFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowsForFile.AutoSize = true;
            this.buttonBrowsForFile.Location = new System.Drawing.Point(10, 271);
            this.buttonBrowsForFile.Name = "buttonBrowsForFile";
            this.buttonBrowsForFile.Size = new System.Drawing.Size(142, 37);
            this.buttonBrowsForFile.TabIndex = 2;
            this.buttonBrowsForFile.Text = "Browse for file(s)";
            this.buttonBrowsForFile.UseVisualStyleBackColor = true;
            this.buttonBrowsForFile.Click += new System.EventHandler(this.buttonBrowsForFile_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonExit, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonExport, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonClear, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonBrowsForFile, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewItems, 0, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(649, 315);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.AutoSize = true;
            this.buttonExit.Location = new System.Drawing.Point(496, 271);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(142, 37);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.AutoSize = true;
            this.buttonExport.Location = new System.Drawing.Point(334, 271);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(142, 37);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.AutoSize = true;
            this.buttonClear.Location = new System.Drawing.Point(172, 271);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 37);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
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
            this.iTEMIDDataGridViewTextBoxColumn,
            this.cOLORDataGridViewTextBoxColumn,
            this.mINQTYDataGridViewTextBoxColumn,
            this.iTEMTYPEDataGridViewTextBoxColumn,
            this.nOTIFYDataGridViewTextBoxColumn,
            this.rEMARKSDataGridViewTextBoxColumn});
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewItems, 4);
            this.dataGridViewItems.DataSource = this.iNVENTORYITEMBindingSource;
            this.dataGridViewItems.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.Size = new System.Drawing.Size(643, 259);
            this.dataGridViewItems.TabIndex = 1;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellDoubleClick);
            this.dataGridViewItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewItems_CellFormatting);
            this.dataGridViewItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewItems_RowsAdded);
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEMID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEMID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            this.iTEMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iTEMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cOLORDataGridViewTextBoxColumn
            // 
            this.cOLORDataGridViewTextBoxColumn.DataPropertyName = "COLOR";
            this.cOLORDataGridViewTextBoxColumn.HeaderText = "COLOR";
            this.cOLORDataGridViewTextBoxColumn.Name = "cOLORDataGridViewTextBoxColumn";
            // 
            // mINQTYDataGridViewTextBoxColumn
            // 
            this.mINQTYDataGridViewTextBoxColumn.DataPropertyName = "MINQTY";
            this.mINQTYDataGridViewTextBoxColumn.HeaderText = "MINQTY";
            this.mINQTYDataGridViewTextBoxColumn.Name = "mINQTYDataGridViewTextBoxColumn";
            // 
            // iTEMTYPEDataGridViewTextBoxColumn
            // 
            this.iTEMTYPEDataGridViewTextBoxColumn.DataPropertyName = "ITEMTYPE";
            this.iTEMTYPEDataGridViewTextBoxColumn.HeaderText = "ITEMTYPE";
            this.iTEMTYPEDataGridViewTextBoxColumn.Name = "iTEMTYPEDataGridViewTextBoxColumn";
            // 
            // nOTIFYDataGridViewTextBoxColumn
            // 
            this.nOTIFYDataGridViewTextBoxColumn.DataPropertyName = "NOTIFY";
            this.nOTIFYDataGridViewTextBoxColumn.HeaderText = "NOTIFY";
            this.nOTIFYDataGridViewTextBoxColumn.Name = "nOTIFYDataGridViewTextBoxColumn";
            // 
            // rEMARKSDataGridViewTextBoxColumn
            // 
            this.rEMARKSDataGridViewTextBoxColumn.DataPropertyName = "REMARKS";
            this.rEMARKSDataGridViewTextBoxColumn.HeaderText = "REMARKS";
            this.rEMARKSDataGridViewTextBoxColumn.Name = "rEMARKSDataGridViewTextBoxColumn";
            // 
            // iNVENTORYITEMBindingSource
            // 
            this.iNVENTORYITEMBindingSource.DataSource = typeof(WLMerge.InventoryItem);
            // 
            // openFileDialogXml
            // 
            this.openFileDialogXml.Filter = "XML files|*.xml";
            this.openFileDialogXml.Multiselect = true;
            this.openFileDialogXml.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogXml_FileOk);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 339);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FormMain";
            this.Text = "WL Merge: drop or browse XML-files";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYITEMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBrowsForFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.BindingSource iNVENTORYITEMBindingSource;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewLinkColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTIFYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKSDataGridViewTextBoxColumn;
    }
}

