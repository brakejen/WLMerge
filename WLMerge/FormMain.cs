using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WLMerge
{
    public partial class FormMain : Form
    {
        public const string AppName = "WLMerge";
        private InventoryItemList _itemList;
        private int _fileCount;


        public FormMain()
        {
            InitializeComponent();

            _itemList = new InventoryItemList();
            _itemList.ItemChanged += _itemList_ItemChanged;
            inventoryItemListBindingSource.DataSource = _itemList;
        }

        private void _itemList_ItemChanged(object sender, ItemChangedEventArgs e)
        {
            UpdateTitle();
        }

        private void ResetForm()
        {
            _itemList.Clear();
            _fileCount = 0;
            buttonExport.Enabled = false;
            buttonClear.Enabled = false;
            checkBoxHideEmptyColumns.Enabled = false;
            UpdateTitle();
        }

        private void UpdateTitle() => 
            Text = _itemList.Count == 0
                ? $"{AppName} - drag or browse file(s) to add Wanted Lists"
                : $"{AppName} - lots: {_itemList.Count}, pieces: {_itemList.PieceCount}, files: {_fileCount}";

        private void HandleXmlFiles(string[] files)
        {
            _fileCount += files.Count();

            foreach (var path in files)
            {
                var items = Inventory.FromXmlFile(path);
                _itemList.Insert(items.Items);
            }
        }

        private void ToggleEmptyColumnsVisible(bool hide)
        {
            foreach(int columnIndex in Enum.GetValues(typeof(Inventory.ItemProperty)))
            {
                var columnEmpty = true;

                if (hide)
                {
                    for (int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
                    {
                        columnEmpty &= dataGridViewItems[columnIndex, rowIndex].Value == null;
                    }
                }

                dataGridViewItems.Columns[columnIndex].Visible = !hide || !columnEmpty;
            }
        }

        private void ClearColumnValues(int columnIndex)
        {
            for(int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
            {
                dataGridViewItems[columnIndex, rowIndex].Value = null;
            }
        }

        private void SetColumnValues(int columnIndex, object newValue)
        {
            for (int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
            {
                dataGridViewItems[columnIndex, rowIndex].Value = newValue;
            }
        }

        private void TransformColumnValues(int columnIndex, ValueTransformer transformer)
        {
            for (int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
            {
                var t = dataGridViewItems.Columns[columnIndex].ValueType;
                var oldValue = dataGridViewItems[columnIndex, rowIndex].Value;
                var newValue = transformer.Transform(oldValue);

                dataGridViewItems[columnIndex, rowIndex].Value = newValue;
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        { 
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                var allXml = true;

                foreach(var f in files)
                {
                    var ext = Path.GetExtension(f).ToLower();
                    allXml = allXml && ext == ".xml";
                }

                e.Effect = allXml ? DragDropEffects.Copy : DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            HandleXmlFiles(files);
        }

        private void buttonBrowsForFile_Click(object sender, EventArgs e)
        {
            openFileDialogXml.ShowDialog();
        }

        private void openFileDialogXml_FileOk(object sender, CancelEventArgs e)
        {
            var files = openFileDialogXml.FileNames;
            HandleXmlFiles(files);
        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            dataGridViewItems.AutoResizeColumn((int)Inventory.ItemProperty.REMARKS, DataGridViewAutoSizeColumnMode.AllCells);

            buttonExport.Enabled = _itemList != null && _itemList.Count > 0;
            buttonClear.Enabled = buttonExport.Enabled;
            checkBoxHideEmptyColumns.Enabled = buttonExport.Enabled;

            UpdateTitle();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _itemList.Clear();
            ResetForm();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var xml =  _itemList.ToInventory().ToXml();
            Clipboard.SetText(xml);
            MessageBox.Show("All lots exported to clipboard! To import in Bricklink:\nWant > Upload > Upload BrickLink XML format", "Export", MessageBoxButtons.OK);
        }

        private void dataGridViewItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == (int)Inventory.ItemProperty.COLOR)
            {
                // Colorize cell
                var colorId = (int)e.Value;
                var cInfo = BricklinkColors.GetInfo(colorId);
                e.CellStyle.BackColor = BricklinkColors.FromString(cInfo.Bg);
                e.CellStyle.ForeColor = BricklinkColors.FromString(cInfo.Fg);

                // Also add a color description as tool tip for the cell
                dataGridViewItems[e.ColumnIndex, e.RowIndex].ToolTipText = cInfo.Name;
            }
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Don't react if it's the header that's been clicked
            if(e.RowIndex < 0)
            {
                return;
            }

            // If it's a cell with a link, launch the link
            if (dataGridViewItems[e.ColumnIndex, e.RowIndex].GetType() == typeof(DataGridViewLinkCell))
            {
                var itemNo = dataGridViewItems[0, e.RowIndex].Value.ToString();
                var url = $@"https://www.bricklink.com/v2/catalog/catalogitem.page?P={itemNo}#T=P";
                System.Diagnostics.Process.Start(url);
            }
        }

        private void checkBoxHideEmptyColumns_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle according to checkbox state... (checked = hide empty colums, unckecked = show all)
            ToggleEmptyColumnsVisible(((CheckBox)sender).Checked);
        }

        private void dataGridViewItems_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // No context menu if it's headers or if the column is read only
            if (e.RowIndex == -1 || e.ColumnIndex == -1 || dgv.Columns[e.ColumnIndex].ReadOnly)
            {
                return;
            }

            // Valid right click, show context menu
            e.ContextMenuStrip = contextMenuStripDgvRightClick;
        }

        private void dataGridViewItems_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Detect right click on cells (not headers) and select that clicked cell (ie reposition selection)
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
            }
        }

        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            var columnIndex = dataGridViewItems.SelectedCells[0].ColumnIndex;
            ClearColumnValues(columnIndex);
        }

        private void toolStripMenuItemSet_Click(object sender, EventArgs e)
        {
            var columnIndex = dataGridViewItems.SelectedCells[0].ColumnIndex;

            var fsv = new FormSetValue();
            fsv.NewValue += (snd, ea) => { SetColumnValues(columnIndex, ea.NewValue); };
            fsv.ShowDialog();
        }

        private void toolStripMenuItemTransform_Click(object sender, EventArgs e)
        {
            var columnIndex = dataGridViewItems.SelectedCells[0].ColumnIndex;
            var ftv = new FormTransformValue((Inventory.ItemProperty)columnIndex);
            ftv.TransformValue += (snd, ea) => { TransformColumnValues(columnIndex, ea.Transformer ); };
            ftv.ShowDialog();
        }
    }
}
