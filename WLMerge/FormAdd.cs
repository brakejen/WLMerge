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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        public int Files { set { labelFilesCount.Text = value.ToString(); } }
        public int Multiplier { get { return int.Parse(textBoxMultiplier.Text);  } }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
