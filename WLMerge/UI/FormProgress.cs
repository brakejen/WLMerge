using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLMerge
{
    // https://www.codeproject.com/Articles/160219/ProgressForm-A-simple-form-linked-to-a-BackgroundW


    /// <summary>
    /// Simple progress form. Register a worker delegate and let the form show progress,
    /// by calling UpdateProgress() from the worker delegate.
    /// Closes automatically when progress reach 100 (percent).
    /// </summary>
    public partial class FormProgress : Form
    {
        BackgroundWorker _bgw;


        public delegate void DoWorkEventHandler(FormProgress sender, DoWorkEventArgs e);
        public event DoWorkEventHandler DoWork;

        /// <summary>
        /// Creates a new form to show progress. It will have no border and no control box and will 
        /// only be closed when calling UpdateProgress with 100 as value.
        /// </summary>
        public FormProgress()
        {
            InitializeComponent();

            _bgw = new BackgroundWorker();
            _bgw.WorkerReportsProgress = true;
            _bgw.WorkerSupportsCancellation = false;
            _bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(_bgw_DoWork);
            _bgw.ProgressChanged += new ProgressChangedEventHandler(_bgw_ProgressChanged);
        }

        /// <summary>
        /// Optional argument for worker delegate
        /// </summary>
        public Object Argument{ get; set; }

        /// <summary>
        /// Message to show above progress bar
        /// </summary>
        public string Message
        {
            set
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { Message = value; }));
                }
                else
                {
                    labelProgress.Text = value;
                }
            }
        }

        /// <summary>
        /// Update progress bar with new value.
        /// </summary>
        /// <param name="percent">New value, in percent (1-100)</param>
        public void UpdateProgress(int percent)
        {
            // Only update if different from old
            if (progressBarProgress.Value != percent)
            {
                _bgw.ReportProgress(percent);
            }
        }
        
        /// <summary>
        /// Update progress bar with new value and new text above
        /// </summary>
        /// <param name="percent">New value, in percent (1-100)</param>
        /// <param name="message">New message</param>
        public void UpdateProgress(int percent, string message)
        {
            // Only update if different from old
            if (progressBarProgress.Value != percent)
            {
                Message = message;
                _bgw.ReportProgress(percent);
            }
        }

        // Event: when form is loaded, adjust position to owner and initalize
        private void FormProgress_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                Location = new Point(
                    Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
            }

            progressBarProgress.Maximum = 100;
            progressBarProgress.Value = progressBarProgress.Minimum = 0;
            progressBarProgress.Step = 1;
            _bgw.RunWorkerAsync(Argument);
        }

        // Event: worker of background worker object. Call delegate to do actual job
        private void _bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWork?.Invoke(this, e);
        }

        // Event: react upon progress change. Close if done (reached 100 percent) 
        // otherwise update progress bar.
        private void _bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 100)
            {
                Close();
            }

            progressBarProgress.Value = e.ProgressPercentage;
        }
    }
}
