namespace proiect
{
    partial class formIncasare
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
            this.textBoxSursa = new System.Windows.Forms.TextBox();
            this.labelMaxim = new System.Windows.Forms.Label();
            this.labelSursa = new System.Windows.Forms.Label();
            this.labelMoneda = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.btnIncasare = new System.Windows.Forms.Button();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.labelTransfer = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSursa
            // 
            this.textBoxSursa.Location = new System.Drawing.Point(479, 101);
            this.textBoxSursa.Name = "textBoxSursa";
            this.textBoxSursa.Size = new System.Drawing.Size(100, 20);
            this.textBoxSursa.TabIndex = 35;
            // 
            // labelMaxim
            // 
            this.labelMaxim.AutoSize = true;
            this.labelMaxim.Location = new System.Drawing.Point(83, 140);
            this.labelMaxim.Name = "labelMaxim";
            this.labelMaxim.Size = new System.Drawing.Size(34, 13);
            this.labelMaxim.TabIndex = 34;
            this.labelMaxim.Text = "Sold :";
            // 
            // labelSursa
            // 
            this.labelSursa.AutoSize = true;
            this.labelSursa.Location = new System.Drawing.Point(485, 67);
            this.labelSursa.Name = "labelSursa";
            this.labelSursa.Size = new System.Drawing.Size(80, 13);
            this.labelSursa.TabIndex = 33;
            this.labelSursa.Text = "Sursa fondurilor";
            // 
            // labelMoneda
            // 
            this.labelMoneda.AutoSize = true;
            this.labelMoneda.Location = new System.Drawing.Point(377, 67);
            this.labelMoneda.Name = "labelMoneda";
            this.labelMoneda.Size = new System.Drawing.Size(45, 13);
            this.labelMoneda.TabIndex = 32;
            this.labelMoneda.Text = "moneda";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(263, 67);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(45, 13);
            this.labelCantitate.TabIndex = 31;
            this.labelCantitate.Text = "cantiate";
            // 
            // btnIncasare
            // 
            this.btnIncasare.Location = new System.Drawing.Point(632, 100);
            this.btnIncasare.Name = "btnIncasare";
            this.btnIncasare.Size = new System.Drawing.Size(75, 23);
            this.btnIncasare.TabIndex = 30;
            this.btnIncasare.Text = "Incaseaza";
            this.btnIncasare.UseVisualStyleBackColor = true;
            this.btnIncasare.Click += new System.EventHandler(this.btnIncasare_Click);
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(342, 100);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMoneda.TabIndex = 29;
            this.comboBoxMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoneda_SelectedIndexChanged);
            // 
            // labelTransfer
            // 
            this.labelTransfer.AutoSize = true;
            this.labelTransfer.Location = new System.Drawing.Point(83, 103);
            this.labelTransfer.Name = "labelTransfer";
            this.labelTransfer.Size = new System.Drawing.Size(119, 13);
            this.labelTransfer.TabIndex = 28;
            this.labelTransfer.Text = "Inregistreaza o incasare";
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(236, 100);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantitate.TabIndex = 27;
            // 
            // formIncasare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 418);
            this.Controls.Add(this.textBoxSursa);
            this.Controls.Add(this.labelMaxim);
            this.Controls.Add(this.labelSursa);
            this.Controls.Add(this.labelMoneda);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.btnIncasare);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.labelTransfer);
            this.Controls.Add(this.textBoxCantitate);
            this.Name = "formIncasare";
            this.Text = "formIncasare";
            this.Load += new System.EventHandler(this.formIncasare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSursa;
        private System.Windows.Forms.Label labelMaxim;
        private System.Windows.Forms.Label labelSursa;
        private System.Windows.Forms.Label labelMoneda;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Button btnIncasare;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.Label labelTransfer;
        private System.Windows.Forms.TextBox textBoxCantitate;
    }
}