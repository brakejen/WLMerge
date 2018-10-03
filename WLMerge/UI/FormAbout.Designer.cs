namespace WLMerge
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonToDo = new System.Windows.Forms.RadioButton();
            this.radioButtonHistory = new System.Windows.Forms.RadioButton();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.radioButtonReadMe = new System.Windows.Forms.RadioButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.radioButtonToDo, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.radioButtonHistory, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonClose, 3, 5);
            this.tableLayoutPanel.Controls.Add(this.radioButtonReadMe, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(556, 361);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // radioButtonToDo
            // 
            this.radioButtonToDo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonToDo.AutoSize = true;
            this.radioButtonToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonToDo.Location = new System.Drawing.Point(282, 324);
            this.radioButtonToDo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonToDo.Name = "radioButtonToDo";
            this.radioButtonToDo.Size = new System.Drawing.Size(131, 33);
            this.radioButtonToDo.TabIndex = 4;
            this.radioButtonToDo.TabStop = true;
            this.radioButtonToDo.Text = "&ToDo";
            this.radioButtonToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonToDo.UseVisualStyleBackColor = true;
            this.radioButtonToDo.CheckedChanged += new System.EventHandler(this.RadioButtonFutureCheckedChanged);
            // 
            // radioButtonHistory
            // 
            this.radioButtonHistory.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonHistory.AutoSize = true;
            this.radioButtonHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonHistory.Location = new System.Drawing.Point(143, 324);
            this.radioButtonHistory.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHistory.Name = "radioButtonHistory";
            this.radioButtonHistory.Size = new System.Drawing.Size(131, 33);
            this.radioButtonHistory.TabIndex = 3;
            this.radioButtonHistory.TabStop = true;
            this.radioButtonHistory.Text = "&History";
            this.radioButtonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonHistory.UseVisualStyleBackColor = true;
            this.radioButtonHistory.CheckedChanged += new System.EventHandler(this.RadioButtonHistoryCheckedChanged);
            // 
            // labelProductName
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelProductName, 3);
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(147, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 21);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(405, 21);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelVersion, 3);
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(147, 31);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 21);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(405, 21);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelCopyright, 3);
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(147, 62);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 21);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(405, 21);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxDescription, 4);
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(8, 128);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(544, 188);
            this.textBoxDescription.TabIndex = 1;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.Location = new System.Drawing.Point(421, 324);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(131, 33);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "&Close";
            // 
            // radioButtonReadMe
            // 
            this.radioButtonReadMe.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonReadMe.AutoSize = true;
            this.radioButtonReadMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonReadMe.Location = new System.Drawing.Point(4, 324);
            this.radioButtonReadMe.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonReadMe.Name = "radioButtonReadMe";
            this.radioButtonReadMe.Size = new System.Drawing.Size(131, 33);
            this.radioButtonReadMe.TabIndex = 2;
            this.radioButtonReadMe.TabStop = true;
            this.radioButtonReadMe.Text = "&ReadMe";
            this.radioButtonReadMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonReadMe.UseVisualStyleBackColor = true;
            this.radioButtonReadMe.CheckedChanged += new System.EventHandler(this.RadioButtonReadMeCheckedChanged);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.tableLayoutPanel.SetRowSpan(this.pictureBoxLogo, 4);
            this.pictureBoxLogo.Size = new System.Drawing.Size(133, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 22;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormAbout
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 383);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(394, 420);
            this.Name = "FormAbout";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAboutLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAboutKeyDown);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RadioButton radioButtonToDo;
        private System.Windows.Forms.RadioButton radioButtonHistory;
        private System.Windows.Forms.RadioButton radioButtonReadMe;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
