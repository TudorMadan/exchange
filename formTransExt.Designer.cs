namespace proiect
{
    partial class formTransExt
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
            this.tableTransfer = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableTransfer
            // 
            this.tableTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableTransfer.AutoScroll = true;
            this.tableTransfer.AutoSize = true;
            this.tableTransfer.BackColor = System.Drawing.SystemColors.Control;
            this.tableTransfer.ColumnCount = 2;
            this.tableTransfer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTransfer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTransfer.Location = new System.Drawing.Point(58, 73);
            this.tableTransfer.Name = "tableTransfer";
            this.tableTransfer.RowCount = 2;
            this.tableTransfer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTransfer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTransfer.Size = new System.Drawing.Size(0, 0);
            this.tableTransfer.TabIndex = 1;
            // 
            // formTransExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 418);
            this.Controls.Add(this.tableTransfer);
            this.Name = "formTransExt";
            this.Text = "formTransExt";
            this.Load += new System.EventHandler(this.formTransExt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableTransfer;
    }
}