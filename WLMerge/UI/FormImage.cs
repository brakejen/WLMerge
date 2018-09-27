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
    /// Form to show a simple, borderless image that will be closed immediately when clicked
    /// </summary>
    /// <param name="image"></param>
    public partial class FormImage : Form
    {
        /// <summary>
        /// Create a new form with the given image as content
        /// </summary>
        /// <param name="image"></param>
        public FormImage(Image image)
        {
            InitializeComponent();
            pictureBoxImage.Image = image;
        }

        // Event: form is loaded. Position it at mouse pointer and adjust size to image size
        private void FormImage_Load(object sender, EventArgs e)
        {
            Size = new Size(pictureBoxImage.Image.Width + 2, pictureBoxImage.Image.Height + 2);
            Location = new Point(Cursor.Position.X, Cursor.Position.Y);
        }

        // Event: form is clicked. Close it.
        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event: form has lost focus. Close it.
        private void FormImage_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
