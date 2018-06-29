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
    public partial class FormEnterValue : Form
    {
        string _property;

        public event EventHandler<NewValueEventArgs> NewValue;

        protected virtual void OnNewValue(NewValueEventArgs e)
        {
            NewValue?.Invoke(this, e);
        }

        public FormEnterValue(string property)
        {
            InitializeComponent();

            _property = property;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // Notify listeners we've got a new value
            OnNewValue(new NewValueEventArgs() { NewValue = textBoxNewValue.Text, Property = _property });
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class NewValueEventArgs : EventArgs
    {
        public string Property { get; set; }
        public string NewValue { get; set; }
    }
    }
