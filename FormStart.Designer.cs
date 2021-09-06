namespace proiect
{
    partial class formStart
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
            this.btnTranzactii = new System.Windows.Forms.Button();
            this.datePrim = new System.Windows.Forms.DateTimePicker();
            this.dateSecund = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPoint = new System.Windows.Forms.ComboBox();
            this.checkBoxFirma = new System.Windows.Forms.CheckBox();
            this.btnCursuri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProfit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTranzactii
            // 
            this.btnTranzactii.Location = new System.Drawing.Point(298, 213);
            this.btnTranzactii.Name = "btnTranzactii";
            this.btnTranzactii.Size = new System.Drawing.Size(75, 23);
            this.btnTranzactii.TabIndex = 0;
            this.btnTranzactii.Text = "RAPORT";
            this.btnTranzactii.UseVisualStyleBackColor = true;
            this.btnTranzactii.Click += new System.EventHandler(this.btnTranzactii_Click);
            // 
            // datePrim
            // 
            this.datePrim.Location = new System.Drawing.Point(12, 85);
            this.datePrim.Name = "datePrim";
            this.datePrim.Size = new System.Drawing.Size(194, 20);
            this.datePrim.TabIndex = 1;
            // 
            // dateSecund
            // 
            this.dateSecund.Location = new System.Drawing.Point(12, 111);
            this.dateSecund.Name = "dateSecund";
            this.dateSecund.Size = new System.Drawing.Size(194, 20);
            this.dateSecund.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raport tranzactii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raport cursuri valutare punct";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alege perioada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alege punctul";
            // 
            // comboBoxPoint
            // 
            this.comboBoxPoint.FormattingEnabled = true;
            this.comboBoxPoint.Location = new System.Drawing.Point(276, 85);
            this.comboBoxPoint.Name = "comboBoxPoint";
            this.comboBoxPoint.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPoint.TabIndex = 7;
            // 
            // checkBoxFirma
            // 
            this.checkBoxFirma.AutoSize = true;
            this.checkBoxFirma.Location = new System.Drawing.Point(456, 86);
            this.checkBoxFirma.Name = "checkBoxFirma";
            this.checkBoxFirma.Size = new System.Drawing.Size(79, 17);
            this.checkBoxFirma.TabIndex = 8;
            this.checkBoxFirma.Text = "Toata firma";
            this.checkBoxFirma.UseVisualStyleBackColor = true;
            // 
            // btnCursuri
            // 
            this.btnCursuri.Location = new System.Drawing.Point(298, 251);
            this.btnCursuri.Name = "btnCursuri";
            this.btnCursuri.Size = new System.Drawing.Size(75, 23);
            this.btnCursuri.TabIndex = 9;
            this.btnCursuri.Text = "RAPORT";
            this.btnCursuri.UseVisualStyleBackColor = true;
            this.btnCursuri.Click += new System.EventHandler(this.btnCursuri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Raport profit";
            // 
            // btnProfit
            // 
            this.btnProfit.Location = new System.Drawing.Point(298, 287);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(75, 23);
            this.btnProfit.TabIndex = 11;
            this.btnProfit.Text = "RAPORT";
            this.btnProfit.UseVisualStyleBackColor = true;
            this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);
            // 
            // formStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 418);
            this.Controls.Add(this.btnProfit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCursuri);
            this.Controls.Add(this.checkBoxFirma);
            this.Controls.Add(this.comboBoxPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSecund);
            this.Controls.Add(this.datePrim);
            this.Controls.Add(this.btnTranzactii);
            this.Name = "formStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.formStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranzactii;
        private System.Windows.Forms.DateTimePicker datePrim;
        private System.Windows.Forms.DateTimePicker dateSecund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPoint;
        private System.Windows.Forms.CheckBox checkBoxFirma;
        private System.Windows.Forms.Button btnCursuri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProfit;
    }
}