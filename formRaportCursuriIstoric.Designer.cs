namespace proiect
{
    partial class formRaportCursuriIstoric
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
            this.graficCursuri = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numemonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratamedieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursuriIstoricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursuriIstoricBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // graficCursuri
            // 
            this.graficCursuri.Location = new System.Drawing.Point(30, 38);
            this.graficCursuri.Name = "graficCursuri";
            this.graficCursuri.Size = new System.Drawing.Size(707, 346);
            this.graficCursuri.TabIndex = 0;
            this.graficCursuri.Text = "cartesianChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createdatDataGridViewTextBoxColumn,
            this.numemonedaDataGridViewTextBoxColumn,
            this.ratamedieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cursuriIstoricBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 122);
            this.dataGridView1.TabIndex = 1;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // numemonedaDataGridViewTextBoxColumn
            // 
            this.numemonedaDataGridViewTextBoxColumn.DataPropertyName = "nume_moneda";
            this.numemonedaDataGridViewTextBoxColumn.HeaderText = "nume_moneda";
            this.numemonedaDataGridViewTextBoxColumn.Name = "numemonedaDataGridViewTextBoxColumn";
            // 
            // ratamedieDataGridViewTextBoxColumn
            // 
            this.ratamedieDataGridViewTextBoxColumn.DataPropertyName = "rata_medie";
            this.ratamedieDataGridViewTextBoxColumn.HeaderText = "rata_medie";
            this.ratamedieDataGridViewTextBoxColumn.Name = "ratamedieDataGridViewTextBoxColumn";
            // 
            // cursuriIstoricBindingSource
            // 
            this.cursuriIstoricBindingSource.DataSource = typeof(proiect.CursuriIstoric);
            // 
            // formRaportCursuriIstoric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.graficCursuri);
            this.Name = "formRaportCursuriIstoric";
            this.Text = "formRaportCursuriIstoric";
            this.Load += new System.EventHandler(this.formRaportCursuriIstoric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursuriIstoricBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart graficCursuri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numemonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratamedieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cursuriIstoricBindingSource;
    }
}