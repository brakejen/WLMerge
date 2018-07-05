using System;
using System.Windows.Forms;

namespace WLMerge
{
    public partial class FormTransformValue : Form
    {
        Type _type;

        public event EventHandler<TransformValueEventArgs> TransformValue;

        protected virtual void OnTransformValue(object sender, TransformValueEventArgs e)
        {
            var handler = TransformValue; // Avoid race condition
            handler?.Invoke(sender, e); // Invoke handler
        }

        public FormTransformValue(Inventory.ItemProperty property)
        {
            _type = InventoryItem.ItemPropertyType(property);

            InitializeComponent();
            PopulateComboBoxOperation();
        }

        private void PopulateComboBoxOperation()
        {
            foreach (int i in Enum.GetValues(typeof(TransformValueOperation)))
            {
                var itemText = (TransformValueOperation)i;
                comboBoxOperation.Items.Add(itemText);
            }

            if (_type == typeof(string))
            {
                comboBoxOperation.SelectedIndex = (int)TransformValueOperation.Add;
                comboBoxOperation.Enabled = false;
            }

            comboBoxOperation.Text = "<Select operation in list>";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {
            var validValue = ValidateTransformValue();

            if(!validValue)
            {
                return;
            }

            var transformValue = textBoxTransformValue.Text;
            var operation = (TransformValueOperation)comboBoxOperation.SelectedIndex;
            var transformer = new ValueTransformer(_type, transformValue, operation);
            OnTransformValue(this, new TransformValueEventArgs(transformer));
            Close();
        }

        private void textBoxTransformValue_TextChanged(object sender, EventArgs e)
        {
            buttonTransform.Enabled = ((TextBox)sender).Text != string.Empty
                && comboBoxOperation.SelectedIndex >= 0;
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonTransform.Enabled = ((ComboBox)sender).SelectedIndex >= 0
                && textBoxTransformValue.Text != string.Empty;

        }

        private bool ValidateTransformValue()
        {
            if(_type == typeof(int))
            {
                try
                {
                    int x = int.Parse(textBoxTransformValue.Text);
                    errorProviderTransformValue.SetError(textBoxTransformValue, "");
                    return true;
                }
                catch //(Exception ex)
                {
                    errorProviderTransformValue.SetError(textBoxTransformValue, "Not an integer value.");
                    return false;
                }
            } 
            else if(_type == typeof(decimal))
            {
                try
                {
                    decimal x = decimal.Parse(textBoxTransformValue.Text);
                    errorProviderTransformValue.SetError(textBoxTransformValue, "");
                    return true;
                }
                catch //(Exception ex)
                {
                    errorProviderTransformValue.SetError(textBoxTransformValue, "Not a decimal value.");
                    return false;
                }
            }

            return true;
        }
    }
}
