namespace WLMerge
{
    partial class FormAdd
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
            this.tableLayoutPanelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.labelFilesCount = new System.Windows.Forms.Label();
            this.labelFiles = new System.Windows.Forms.Label();
            this.labelMultiplier = new System.Windows.Forms.Label();
            this.textBoxMultiplier = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAdd
            // 
            this.tableLayoutPanelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAdd.ColumnCount = 2;
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdd.Controls.Add(this.labelFilesCount, 1, 0);
            this.tableLayoutPanelAdd.Controls.Add(this.labelFiles, 0, 0);
            this.tableLayoutPanelAdd.Controls.Add(this.labelMultiplier, 0, 1);
            this.tableLayoutPanelAdd.Controls.Add(this.textBoxMultiplier, 1, 1);
            this.tableLayoutPanelAdd.Controls.Add(this.buttonAdd, 0, 2);
            this.tableLayoutPanelAdd.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            this.tableLayoutPanelAdd.RowCount = 3;
            this.tableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAdd.Size = new System.Drawing.Size(255, 101);
            this.tableLayoutPanelAdd.TabIndex = 0;
            // 
            // labelFilesCount
            // 
            this.labelFilesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilesCount.AutoSize = true;
            this.labelFilesCount.Location = new System.Drawing.Point(130, 0);
            this.labelFilesCount.Name = "labelFilesCount";
            this.labelFilesCount.Size = new System.Drawing.Size(122, 30);
            this.labelFilesCount.TabIndex = 9;
            this.labelFilesCount.Text = "0";
            this.labelFilesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFiles
            // 
            this.labelFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(3, 0);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(121, 30);
            this.labelFiles.TabIndex = 8;
            this.labelFiles.Text = "Files selected:";
            this.labelFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMultiplier
            // 
            this.labelMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMultiplier.AutoSize = true;
            this.labelMultiplier.Location = new System.Drawing.Point(3, 30);
            this.labelMultiplier.Name = "labelMultiplier";
            this.labelMultiplier.Size = new System.Drawing.Size(121, 30);
            this.labelMultiplier.TabIndex = 3;
            this.labelMultiplier.Text = "Piece multiplier:";
            this.labelMultiplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMultiplier
            // 
            this.textBoxMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMultiplier.Location = new System.Drawing.Point(130, 33);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.Size = new System.Drawing.Size(122, 22);
            this.textBoxMultiplier.TabIndex = 6;
            this.textBoxMultiplier.Text = "1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAdd.SetColumnSpan(this.buttonAdd, 2);
            this.buttonAdd.Location = new System.Drawing.Point(3, 63);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(249, 35);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 125);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelAdd);
            this.Name = "FormAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add XML files";
            this.tableLayoutPanelAdd.ResumeLayout(false);
            this.tableLayoutPanelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdd;
        private System.Windows.Forms.Label labelFilesCount;
        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.Label labelMultiplier;
        private System.Windows.Forms.TextBox textBoxMultiplier;
        private System.Windows.Forms.Button buttonAdd;
    }
}