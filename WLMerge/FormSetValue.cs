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
    public partial class FormSetValue : Form
    {
        public event EventHandler<NewValueEventArgs> NewValue;

        protected virtual void OnNewValue(object sender, NewValueEventArgs e)
        {
            var handler = NewValue; // Avoid race condition
            handler?.Invoke(sender, e); // Invoke handler
        }

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
