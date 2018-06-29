using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WLMerge
{
    public partial class FormMain : Form
    {
        public const string AppName = "WLMerge";
        private SortableBindingList<InventoryItem> _allItems;
        private int _pieceCount;
        private int _fileCount;

        public FormMain()
        {
            _allItems = new SortableBindingList<InventoryItem>(new List<InventoryItem>());

            InitializeComponent();
        }

        private void ResetForm()
        {
            _pieceCount = 0;
            _fileCount = 0;
            iNVENTORYITEMBindingSource.DataSource = _allItems;
            buttonExport.Enabled = false;
            buttonClear.Enabled = false;
            UpdateTitle();
        }

        private void UpdateTitle() => 
            Text = _allItems.Count == 0
                ? $"{AppName} - drag or browse file(s) to add Wanted Lists"
                : $"{AppName} - lots: {_allItems.Count}, pieces: {_pieceCount}, files: {_fileCount}";

        private void FormMain_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void HandleXmlFiles(string[] files)
        {
            var formAdd = new FormAddFiles();
            formAdd.Files = files.Length;
            formAdd.ShowDialog();
            var multiplier = formAdd.Multiplier;

            int pieceCount = 0;

            foreach(var path in files)
            {
                var items = Inventory.FromXmlFile(path, multiplier);
                pieceCount += InventoryList.MergeItems(ref _allItems, items.Item);
            }

            _pieceCount += pieceCount;
            _fileCount += files.Count();
            iNVENTORYITEMBindingSource.ResetBindings(false);
        }

        private void UpdateAllValuesOfProperty(string property, string newValue)
        {
            for(int i = 0; i < _allItems.Count; i++)
            {
                switch (property)
                {
                    case  "NOTIFY": 
                        _allItems[i].Notify = newValue;
                        break;
                    case "REMARKS":
                        _allItems[i].Remarks = newValue;
                        break;
                    default:
                        break;
                }
            }

            iNVENTORYITEMBindingSource.ResetBindings(false);
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
            dataGridViewItems.AutoResizeColumn(5, DataGridViewAutoSizeColumnMode.AllCells);

            buttonExport.Enabled = _allItems != null &&_allItems.Count > 0;
            buttonClear.Enabled = _allItems != null && _allItems.Count > 0;

            UpdateTitle();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _allItems.Clear();
            iNVENTORYITEMBindingSource.ResetBindings(false);
            ResetForm();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var wl = new Inventory() { Item = _allItems.ToArray() };
            var xml = wl.ToXml();
            Clipboard.SetText(xml);
            MessageBox.Show("All lots exported to clipboard! To import in Bricklink:\nWant > Upload > Upload BrickLink XML format", "Export", MessageBoxButtons.OK);
        }

        private void dataGridViewItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                var colorId = (int)e.Value;
                var cInfo = BricklinkColors.GetInfo(colorId);
                e.CellStyle.BackColor = BricklinkColors.FromString(cInfo.Bg);
                e.CellStyle.ForeColor = BricklinkColors.FromString(cInfo.Fg);
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
                var url = string.Format(@"https://www.bricklink.com/v2/catalog/catalogitem.page?P={0}#T=P",itemNo);
                System.Diagnostics.Process.Start(url);

            }
        }
        private void dataGridViewItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    var property = dataGridViewItems.Columns[e.ColumnIndex].HeaderText;
                    var nvd = new FormEnterValue(property);
                    nvd.NewValue += Nvd_NewValue;
                    nvd.ShowDialog();
                }
            }

        }
        private void Nvd_NewValue(object sender, NewValueEventArgs e)
        {
            UpdateAllValuesOfProperty(e.Property, e.NewValue);
        }

    }
}
