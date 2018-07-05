using System;
using System.Windows.Forms;

namespace WLMerge
{
    /// <summary>
    /// Represents a form that can be used to prompt user for transformation of values.
    /// An event when value is entered is provided, to get the transformer object customized to transform data according to selections made.
    /// </summary>
    public partial class FormTransformValue : Form
    {
        Type _type;

        /// <summary>
        /// Event raised when user selects transformation data and confirms
        /// </summary>
        public event EventHandler<TransformValueEventArgs> TransformValue;

        protected virtual void OnTransformValue(object sender, TransformValueEventArgs e)
        {
            var handler = TransformValue; // Avoid race condition
            handler?.Invoke(sender, e); // Invoke handler
        }

        /// <summary>
        /// Creates a new form to select transformation in.
        /// The form needs to know what kind of Inventory Item Property it will work on, 
        /// in ordet to create a 'transformer' object for the selected data.
        /// </summary>
        /// <param name="property">The Item Property to transform</param>
        public FormTransformValue(Inventory.ItemProperty property)
        {
            _type = InventoryItem.ItemPropertyType(property);

            InitializeComponent();
            PopulateComboBoxOperation();
        }

        // Fill combobox with values
        private void PopulateComboBoxOperation()
        {
            // First add all possible operations (transformation) supported
            foreach (int i in Enum.GetValues(typeof(TransformValueOperation)))
            {
                var itemText = (TransformValueOperation)i;
                comboBoxOperation.Items.Add(itemText);
            }

            // If it's strings that will be transformed, only add is supported (add as in concatenate). Preselect and disable user selection.
            if (_type == typeof(string))
            {
                comboBoxOperation.SelectedIndex = (int)TransformValueOperation.Add;
                comboBoxOperation.Enabled = false;
            }

            // Add descriptive text to help user
            comboBoxOperation.Text = "<Select operation in list>";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Create a 'transform' object to send along with event, so receiver(s) can transform values with it
        private void buttonTransform_Click(object sender, EventArgs e)
        {
            // First validate the value entered
            var validValue = ValidateTransformValue();

            if(!validValue)
            {
                // Not a valid value
                return;
            }

            // Create transformer
            var transformValue = textBoxTransformValue.Text;
            var operation = (TransformValueOperation)comboBoxOperation.SelectedIndex;
            var transformer = new ValueTransformer(_type, transformValue, operation);

            // Notify listeners
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

        // Validate the value entered. Validation depends on what type of values to transform.
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
