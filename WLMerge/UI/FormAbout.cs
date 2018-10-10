using System;
using System.IO;
using System.Windows.Forms;

namespace WLMerge
{
    /// <summary>
    ///     The form about.
    /// </summary>
    public partial class FormAbout : Form
    {
        public enum SelectedView
        {
            ReadMe = 1,
            History = 2,
            ToDo = 3,
        }
        #region Constructors and Destructors
        public FormAbout() : this(SelectedView.ReadMe)
        {
            // Intentionally empty
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FormAbout" /> class.
        /// </summary>
        public FormAbout(SelectedView selectedView)
        {
            InitializeComponent();
            Text = $"About {Program.AssemblyTitle}";
            labelProductName.Text = Program.AssemblyProduct;
            labelVersion.Text =
                $"Version {Program.AssemblyVersionShort} (build {Program.AssemblyVersionBuild} compiled {Program.AssemblyCompileTime})";
            labelCopyright.Text = Program.AssemblyCopyright;
            textBoxDescription.Text = Program.AssemblyDescription;
            
            if(selectedView == SelectedView.ToDo)
            {
                radioButtonToDo.Checked = true;

            }
            else if (selectedView == SelectedView.History)
            {
                radioButtonHistory.Checked = true;
            }
            else
            {
                radioButtonReadMe.Checked = true;
            }
        }

        #endregion

        #region Public Properties
         
        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        public override sealed string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
            }
        }

        #endregion

        #region Fields

        /// <summary>
        ///     The future.
        /// </summary>
        private string _todo;

        /// <summary>
        ///     The history.
        /// </summary>
        private string _history;

        /// <summary>
        ///     The read me.
        /// </summary>
        private string _readMe;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the future. :)
        /// </summary>
        private string ToDo
        {
            get
            {
                if (string.IsNullOrEmpty(this._todo))
                {
                    _todo = LoadFileToShow("ToDo");
                }

                return _todo;
            }
        }

        /// <summary>
        ///     Gets the history.
        /// </summary>
        private string History
        {
            get
            {
                if (string.IsNullOrEmpty(this._history))
                {
                    _history = LoadFileToShow("History");
                }

                return _history;
            }
        }

        /// <summary>
        ///     Gets the read me.
        /// </summary>
        private string ReadMe
        {
            get
            {
                if (string.IsNullOrEmpty(_readMe))
                {
                    _readMe = LoadFileToShow("ReadMe");
                }

                return _readMe;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        ///     The load file to show.
        /// </summary>
        /// <param name="fileName">
        ///     The file name.
        /// </param>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        private static string LoadFileToShow(string fileName)
        {
            var fullPath = Path.Combine(Program.AssemblyPath, $"{fileName}.txt");

            try
            {
                return File.ReadAllText(fullPath);
            }
            catch (Exception ex)
            {
                return $"Could not read file '{fileName}'{Environment.NewLine}Reason: {ex.Message}";
            }
        }

        /// <summary>
        ///     The form about key down.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void FormAboutKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Close();
            }
        }

        /// <summary>
        ///     The form about load.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void FormAboutLoad(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     The radio button future checked changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void RadioButtonFutureCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonToDo.Checked)
            {
                textBoxDescription.Text = ToDo;
            } 
        }

        /// <summary>
        ///     The radio button history checked changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void RadioButtonHistoryCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHistory.Checked)
            {
                textBoxDescription.Text = History;
            }
        }

        /// <summary>
        ///     The radio button read me checked changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void RadioButtonReadMeCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonReadMe.Checked)
            {
                textBoxDescription.Text = ReadMe;
            }
        }

        #endregion
    }
}