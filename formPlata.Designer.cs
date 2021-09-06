namespace proiect
{
    partial class formPlata
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
            this.labelMaxim = new System.Windows.Forms.Label();
            this.labelObservatie = new System.Windows.Forms.Label();
            this.labelMoneda = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.btnPlata = new System.Windows.Forms.Button();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.labelTransfer = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.textBoxObservatii = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMaxim
            // 
            this.labelMaxim.AutoSize = true;
            this.labelMaxim.Location = new System.Drawing.Point(71, 114);
            this.labelMaxim.Name = "labelMaxim";
            this.labelMaxim.Size = new System.Drawing.Size(46, 13);
            this.labelMaxim.TabIndex = 25;
            this.labelMaxim.Text = "Maxim : ";
            // 
            // labelObservatie
            // 
            this.labelObservatie.AutoSize = true;
            this.labelObservatie.Location = new System.Drawing.Point(473, 41);
            this.labelObservatie.Name = "labelObservatie";
            this.labelObservatie.Size = new System.Drawing.Size(58, 13);
            this.labelObservatie.TabIndex = 24;
            this.labelObservatie.Text = "Observatie";
            // 
            // labelMoneda
            // 
            this.labelMoneda.AutoSize = true;
            this.labelMoneda.Location = new System.Drawing.Point(365, 41);
            this.labelMoneda.Name = "labelMoneda";
            this.labelMoneda.Size = new System.Drawing.Size(45, 13);
            this.labelMoneda.TabIndex = 23;
            this.labelMoneda.Text = "moneda";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(251, 41);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(45, 13);
            this.labelCantitate.TabIndex = 22;
            this.labelCantitate.Text = "cantiate";
            // 
            // btnPlata
            // 
            this.btnPlata.Location = new System.Drawing.Point(620, 74);
            this.btnPlata.Name = "btnPlata";
            this.btnPlata.Size = new System.Drawing.Size(75, 23);
            this.btnPlata.TabIndex = 21;
            this.btnPlata.Text = "Plata";
            this.btnPlata.UseVisualStyleBackColor = true;
            this.btnPlata.Click += new System.EventHandler(this.btnPlata_Click);
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(330, 74);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMoneda.TabIndex = 19;
            this.comboBoxMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoneda_SelectedIndexChanged);
            // 
            // labelTransfer
            // 
            this.labelTransfer.AutoSize = true;
            this.labelTransfer.Location = new System.Drawing.Point(71, 77);
            this.labelTransfer.Name = "labelTransfer";
            this.labelTransfer.Size = new System.Drawing.Size(75, 13);
            this.labelTransfer.TabIndex = 18;
            this.labelTransfer.Text = "Creaza o plata";
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(224, 74);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantitate.TabIndex = 17;
            // 
            // textBoxObservatii
            // 
            this.textBoxObservatii.Location = new System.Drawing.Point(467, 75);
            this.textBoxObservatii.Name = "textBoxObservatii";
            this.textBoxObservatii.Size = new System.Drawing.Size(100, 20);
            this.textBoxObservatii.TabIndex = 26;
            // 
            // formPlata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 418);
            this.Controls.Add(this.textBoxObservatii);
            this.Controls.Add(this.labelMaxim);
            this.Controls.Add(this.labelObservatie);
            this.Controls.Add(this.labelMoneda);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.btnPlata);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.labelTransfer);
            this.Controls.Add(this.textBoxCantitate);
            this.Name = "formPlata";
            this.Text = "formPlata";
            this.Load += new System.EventHandler(this.formPlata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaxim;
        private System.Windows.Forms.Label labelObservatie;
        private System.Windows.Forms.Label labelMoneda;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Button btnPlata;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.Label labelTransfer;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.TextBox textBoxObservatii;
    }
}