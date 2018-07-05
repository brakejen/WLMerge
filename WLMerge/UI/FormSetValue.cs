using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLMerge
{
    /// <summary>
    /// Represents a form that can be used to prompt user for new values.
    /// An event when value is entered is provided, to get the value to be used.
    /// </summary>
    public partial class FormSetValue : Form
    {
        /// <summary>
        /// Event raised when user enters a value and confirms
        /// </summary>
        public event EventHandler<NewValueEventArgs> NewValue;

        protected virtual void OnNewValue(object sender, NewValueEventArgs e)
        {
            var handler = NewValue; // Avoid race condition
            handler?.Invoke(sender, e); // Invoke handler
        }

        /// <summary>
        /// Creates a new form to enter new values in
        /// </summary>
        public FormSetValue()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            OnNewValue(this, new NewValueEventArgs(textBoxNewValue.Text));
            Close();
        }

        // Only allow to confirm if anything is entered in textbox for new value
        private void textBoxNewValue_TextChanged(object sender, EventArgs e)
        {
            buttonSet.Enabled = ((TextBox)sender).Text != string.Empty;
        }
    }

    public class NewValueEventArgs : EventArgs
    {
        private object _newValue;
        public NewValueEventArgs(object newValue)
        {
            _newValue = newValue;
        } 

        public object NewValue { get { return _newValue; } }
    }
}
