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


    public partial class FormProgress : Form
    {
        BackgroundWorker _bgw;


        public delegate void DoWorkEventHandler(FormProgress sender, DoWorkEventArgs e);
        public event DoWorkEventHandler DoWork;


        public FormProgress()
        {
            InitializeComponent();

            _bgw = new BackgroundWorker();
            _bgw.WorkerReportsProgress = true;
            _bgw.WorkerSupportsCancellation = false;
            _bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(_bgw_DoWork);
            _bgw.ProgressChanged += new ProgressChangedEventHandler(_bgw_ProgressChanged);
        }

        public Object Argument{ get; set; }

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

        public void UpdateProgress(int percent)
        {
            if (progressBarProgress.Value != percent)
            {
                _bgw.ReportProgress(percent);
            }
        }

        public void UpdateProgress(int percent, string message)
        {
            if (progressBarProgress.Value != percent)
            {
                Message = message;
                _bgw.ReportProgress(percent);
            }
        }

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

        private void _bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            DoWork?.Invoke(this, e);
        }

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
