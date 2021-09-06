namespace proiect
{
    partial class formCursuriBnr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nume_moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescurtare_moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(54, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 305);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nume_moneda,
            this.prescurtare_moneda,
            this.rata});
            this.dataGridView1.Location = new System.Drawing.Point(108, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(517, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // nume_moneda
            // 
            this.nume_moneda.HeaderText = "Nume Moneda";
            this.nume_moneda.Name = "nume_moneda";
            this.nume_moneda.ReadOnly = true;
            // 
            // prescurtare_moneda
            // 
            this.prescurtare_moneda.HeaderText = "Prescurtare Moneda";
            this.prescurtare_moneda.Name = "prescurtare_moneda";
            this.prescurtare_moneda.ReadOnly = true;
            // 
            // rata
            // 
            this.rata.HeaderText = "Rata de schimb BNR";
            this.rata.Name = "rata";
            this.rata.ReadOnly = true;
            // 
            // formCursuriBnr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 418);
            this.Controls.Add(this.panel1);
            this.Name = "formCursuriBnr";
            this.Text = "formCursuriBnr";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume_moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescurtare_moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn rata;
    }
}