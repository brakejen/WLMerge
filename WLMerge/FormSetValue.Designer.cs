namespace WLMerge
{
    partial class FormSetValue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.tableLayoutPanelSetValue = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelSetValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSetValue
            // 
            this.tableLayoutPanelSetValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSetValue.ColumnCount = 2;
            this.tableLayoutPanelSetValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSetValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSetValue.Controls.Add(this.buttonSet, 1, 1);
            this.tableLayoutPanelSetValue.Controls.Add(this.buttonCancel, 0, 1);
            this.tableLayoutPanelSetValue.Controls.Add(this.textBoxNewValue, 0, 0);
            this.tableLayoutPanelSetValue.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelSetValue.Name = "tableLayoutPanelSetValue";
            this.tableLayoutPanelSetValue.RowCount = 2;
            this.tableLayoutPanelSetValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.79412F));
            this.tableLayoutPanelSetValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.20588F));
            this.tableLayoutPanelSetValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSetValue.Size = new System.Drawing.Size(258, 88);
            this.tableLayoutPanelSetValue.TabIndex = 0;
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSet.Enabled = false;
            this.buttonSet.Location = new System.Drawing.Point(132, 45);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(123, 40);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(3, 45);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(123, 40);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxNewValue
            // 
            this.textBoxNewValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSetValue.SetColumnSpan(this.textBoxNewValue, 2);
            this.textBoxNewValue.Location = new System.Drawing.Point(3, 10);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(252, 22);
            this.textBoxNewValue.TabIndex = 2;
            this.textBoxNewValue.TextChanged += new System.EventHandler(this.textBoxNewValue_TextChanged);
            // 
            // FormSetValue
            // 
            this.AcceptButton = this.buttonSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(282, 112);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelSetValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSetValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set values";
            this.tableLayoutPanelSetValue.ResumeLayout(false);
            this.tableLayoutPanelSetValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetValue;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.TextBox textBoxNewValue;
        private System.Windows.Forms.Button buttonCancel;
    }
}