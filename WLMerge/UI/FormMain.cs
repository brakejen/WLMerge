using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WLMerge
{
    public partial class FormMain : Form
    {
        public const string AppName = "WLMerge";
        private const string BricklinkCatalogItemLink = "https://www.bricklink.com/v2/catalog/catalogitem.page?P={0}&C={1}";
        private InventoryItemList _itemList;
        private int _fileCount;

        /// <summary>
        /// Creates and initializes the main form of the app
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            _itemList = new InventoryItemList();
            _itemList.ItemChanged += _itemList_ItemChanged;
            inventoryItemListBindingSource.DataSource = _itemList;
        }

        // TODO: remove or update
        private void _itemList_ItemChanged(object sender, ItemChangedEventArgs e)
        {
            UpdateTitle();
        }

        // Reset the form to initial state
        private void ResetForm()
        {
            _itemList.Clear();
            _fileCount = 0;
            buttonExport.Enabled = false;
            buttonClear.Enabled = false;
            checkBoxHideEmptyColumns.Enabled = false;
            UpdateTitle();
        }

        // Update app title to reflect state
        private void UpdateTitle() => 
            Text = _itemList.Count == 0
                ? $"{AppName} - drag or browse file(s) to add Wanted Lists"
                : $"{AppName} - lots: {_itemList.Count}, pieces: {_itemList.PieceCount}, files: {_fileCount}";

        // Given an array of files (valid and complete file paths), handle them (ie load them into app)
        private void HandleXmlFiles(string[] files)
        {
            _fileCount += files.Count();

            foreach (var path in files)
            {
                // Load and parse the XML-file
                var items = Inventory.FromXmlFile(path);

                // Add the items of the Wanted List to our main list (ie merge)
                _itemList.Insert(items.Items);
            }
        }

        // Toggle the empty columns visible or invisible
        private void ToggleEmptyColumnsVisible(bool hide)
        {
            // Check all columns
            foreach(int columnIndex in Enum.GetValues(typeof(Inventory.ItemProperty)))
            {
                // Assume it's empty
                var columnEmpty = true;

                // Do we want to hide empty?
                if (hide)
                {
                    // Yes, check all rows in this column if they are empty or not
                    for (int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
                    {
                        // Column empty iff previous cells are empty and this cell is too
                        columnEmpty &= dataGridViewItems[columnIndex, rowIndex].Value == null;
                    }
                }

                // Show column if 'hide' is false OR column is not empty 
                dataGridViewItems.Columns[columnIndex].Visible = !hide || !columnEmpty;
            }
        }

        // Clear all cells in the given column
        private void ClearColumnValues(int columnIndex)
        {
            for(int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
            {
                dataGridViewItems[columnIndex, rowIndex].Value = null;
            }
        }

        // Set all cells in the given column to a new value
        private void SetColumnValues(int columnIndex, object newValue)
        {
            for (int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
            {
                dataGridViewItems[columnIndex, rowIndex].Value = newValue;
            }
        }

        // Transform all cells in the given column to a new value, using given 'transformer'
        private void TransformColumnValues(int columnIndex, ValueTransformer transformer)
        {
            for (int rowIndex = 0; rowIndex < dataGridViewItems.Rows.Count; rowIndex++)
            {
                var oldValue = dataGridViewItems[columnIndex, rowIndex].Value;
                var newValue = transformer.Transform(oldValue);

                dataGridViewItems[columnIndex, rowIndex].Value = newValue;
            }
        }

        // Event: tasks to do when form (ie app) is loaded after launch
        private void FormMain_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Event: determine if content being dragged onto form is of interest
        private void FormMain_DragEnter(object sender, DragEventArgs e)
        { 
            // Has to be files that will be dropped
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                var allXml = true;

                // Also has to be files with '.xml' extension, no exceptions
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

        // Event: act when XML-files have been dropped
        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            HandleXmlFiles(files);
        }

        // Event: browse for files button clicked
        private void buttonBrowsForFile_Click(object sender, EventArgs e)
        {
            openFileDialogXml.ShowDialog();
        }

        // Event: file (or files) in browse for file dialog have been successfully selected
        private void openFileDialogXml_FileOk(object sender, CancelEventArgs e)
        {
            var files = openFileDialogXml.FileNames;
            HandleXmlFiles(files);
        }

        // Event: Rows have been added to the table. Make adjustments to form and table as data have been added
        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Resize column widths
            dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            dataGridViewItems.AutoResizeColumn((int)Inventory.ItemProperty.REMARKS, DataGridViewAutoSizeColumnMode.AllCells);

            // Enable buttons if at least one item have been added
            buttonExport.Enabled = _itemList != null && _itemList.Count > 0;
            buttonClear.Enabled = buttonExport.Enabled;
            checkBoxHideEmptyColumns.Enabled = buttonExport.Enabled;

            UpdateTitle();
        }

        // Event: button to exit application have been clicked
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event: button to clear contents of table have been clicked
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Remove all items previously loaded/merged
            _itemList.Clear();

            // Reset form to initial state
            ResetForm();
        }

        // Event: button to export items to a Wanted List have been clicked
        private void buttonExport_Click(object sender, EventArgs e)
        {
            // First convert to Inventory, then serialize it to an XML-string
            var xml =  _itemList.ToInventory().ToXml();

            // Fill clipboard with the XML-string and notify user
            Clipboard.SetText(xml);
            MessageBox.Show("All lots exported to clipboard! To import in Bricklink:\nWant > Upload > Upload BrickLink XML format", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event: a cell in the table is being formatted. Do some adjustments and add tool tips along the way
        private void dataGridViewItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Item type will show a description as tooltip
            if(e.ColumnIndex == (int)Inventory.ItemProperty.ITEMTYPE)
            {
                var itemTypeDescription = BricklinkItems.BricklinkItemTypeDescription((string)e.Value);
                dataGridViewItems[e.ColumnIndex, e.RowIndex].ToolTipText = itemTypeDescription;
            }
            // Paint color column cells and show tooltip with color description
            else if(e.ColumnIndex == (int)Inventory.ItemProperty.COLOR)
            {
                // Colorize cell
                var color = (int)e.Value;
                var cInfo = BricklinkColors.GetInfo(color);
                e.CellStyle.BackColor = BricklinkColors.FromString(cInfo.Bg);
                e.CellStyle.ForeColor = BricklinkColors.FromString(cInfo.Fg);

                // Also add a color description as tool tip for the cell
                dataGridViewItems[e.ColumnIndex, e.RowIndex].ToolTipText = cInfo.Name;
            } 
            // Add a tool tip to item id's with URL that this cell will launch upon click
            else if(e.ColumnIndex == (int)Inventory.ItemProperty.ITEMID)
            {
                var itemId = (string)e.Value;
                var color = (int)dataGridViewItems[(int)Inventory.ItemProperty.COLOR, e.RowIndex].Value;
                var url = string.Format(BricklinkCatalogItemLink, itemId, color);
                dataGridViewItems[e.ColumnIndex, e.RowIndex].ToolTipText = url;
            }
            // All other cells, general instruction as tool tip
            else
            {
                var description = "Click to edit cell\nRight click to edit column";
                dataGridViewItems[e.ColumnIndex, e.RowIndex].ToolTipText = description;
            }
        }

        // Event: contents of a cell in the table have been clicked
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
                var itemNo = dataGridViewItems[(int)Inventory.ItemProperty.ITEMID, e.RowIndex].Value.ToString();
                var color = dataGridViewItems[(int)Inventory.ItemProperty.COLOR, e.RowIndex].Value.ToString();
                var url = string.Format(BricklinkCatalogItemLink, itemNo, color);
                System.Diagnostics.Process.Start(url);
            }
        }

        // Event: the checkbox to hide/show empty columns have been clicked. React accordingly
        private void checkBoxHideEmptyColumns_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle according to checkbox state... (checked = hide empty colums, unckecked = show all)
            ToggleEmptyColumnsVisible(((CheckBox)sender).Checked);
        }

        // Event: cell has been right clicked. Show context menu
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

        // Event: fix to ease right click menu: make right clicked cell the active one. By doing this, we can get row/column of active cell
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

        // Event: context menu option for clearing column has been selected
        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            var columnIndex = dataGridViewItems.SelectedCells[0].ColumnIndex;
            ClearColumnValues(columnIndex);
        }

        // Event: context menu option for setting column values has been selected
        private void toolStripMenuItemSet_Click(object sender, EventArgs e)
        {
            var columnIndex = dataGridViewItems.SelectedCells[0].ColumnIndex;

            var fsv = new FormSetValue();
            fsv.NewValue += (snd, ea) => { SetColumnValues(columnIndex, ea.NewValue); };
            fsv.ShowDialog();
        }

        // Event: context menu option for transforming column values has been selected
        private void toolStripMenuItemTransform_Click(object sender, EventArgs e)
        {
            var columnIndex = dataGridViewItems.SelectedCells[0].ColumnIndex;
            var ftv = new FormTransformValue((Inventory.ItemProperty)columnIndex);
            ftv.TransformValue += (snd, ea) => { TransformColumnValues(columnIndex, ea.Transformer ); };
            ftv.ShowDialog();
        }

        // Event: add row numbers to row headers
        private void dataGridViewItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            var rowNumber = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowNumber, Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        // Event: react upon key press (currently to catch delete button)
        private void dataGridViewItems_KeyDown(object sender, KeyEventArgs e)
        {
            // User pressed delete?
            if(e.KeyCode == Keys.Delete)
            {
                var dgv = (DataGridView)sender;
                var rowsSelected = dgv.SelectedRows.Count;

                // Any rows selected (means user wants to delete one or more rows)?
                if (rowsSelected > 0)
                {
                    // Prompt user to confirm
                    var dialogResult = MessageBox.Show($"Delete {rowsSelected} rows?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    // Cancel deletion depending on answer. If 'No', tell system keypress has been handled and deletion will not be performed
                    e.Handled = dialogResult == DialogResult.No;
                }
            }
        }
    }
}