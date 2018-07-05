namespace WLMerge
{
    partial class FormTransformValue
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelSetValue = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTransformValue = new System.Windows.Forms.TextBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.errorProviderTransformValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanelSetValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransformValue)).BeginInit();
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
            this.tableLayoutPanelSetValue.Controls.Add(this.buttonTransform, 1, 2);
            this.tableLayoutPanelSetValue.Controls.Add(this.buttonCancel, 0, 2);
            this.tableLayoutPanelSetValue.Controls.Add(this.textBoxTransformValue, 0, 1);
            this.tableLayoutPanelSetValue.Controls.Add(this.comboBoxOperation, 0, 0);
            this.tableLayoutPanelSetValue.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelSetValue.Name = "tableLayoutPanelSetValue";
            this.tableLayoutPanelSetValue.RowCount = 3;
            this.tableLayoutPanelSetValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSetValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.86275F));
            this.tableLayoutPanelSetValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.80392F));
            this.tableLayoutPanelSetValue.Size = new System.Drawing.Size(258, 98);
            this.tableLayoutPanelSetValue.TabIndex = 0;
            // 
            // buttonTransform
            // 
            this.buttonTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransform.Enabled = false;
            this.buttonTransform.Location = new System.Drawing.Point(132, 66);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(123, 29);
            this.buttonTransform.TabIndex = 4;
            this.buttonTransform.Text = "Set";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(3, 66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(123, 29);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxTransformValue
            // 
            this.textBoxTransformValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelSetValue.SetColumnSpan(this.textBoxTransformValue, 2);
            this.textBoxTransformValue.Location = new System.Drawing.Point(3, 36);
            this.textBoxTransformValue.Name = "textBoxTransformValue";
            this.textBoxTransformValue.Size = new System.Drawing.Size(221, 22);
            this.textBoxTransformValue.TabIndex = 2;
            this.textBoxTransformValue.TextChanged += new System.EventHandler(this.textBoxTransformValue_TextChanged);
            // 
            // comboBoxOperation
            // 
            this.tableLayoutPanelSetValue.SetColumnSpan(this.comboBoxOperation, 2);
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(3, 3);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(252, 24);
            this.comboBoxOperation.TabIndex = 5;
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // errorProviderTransformValue
            // 
            this.errorProviderTransformValue.ContainerControl = this;
            // 
            // FormTransformValue
            // 
            this.AcceptButton = this.buttonTransform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(282, 122);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelSetValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTransformValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transform values";
            this.tableLayoutPanelSetValue.ResumeLayout(false);
            this.tableLayoutPanelSetValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransformValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetValue;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.TextBox textBoxTransformValue;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.ErrorProvider errorProviderTransformValue;
    }
}