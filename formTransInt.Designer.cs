namespace proiect
{
    partial class formTransInt
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
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelMoneda = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.comboBoxPoints = new System.Windows.Forms.ComboBox();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.labelTransfer = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.labelMaxim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(478, 71);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(85, 13);
            this.labelPoints.TabIndex = 15;
            this.labelPoints.Text = "punct de schimb";
            // 
            // labelMoneda
            // 
            this.labelMoneda.AutoSize = true;
            this.labelMoneda.Location = new System.Drawing.Point(370, 71);
            this.labelMoneda.Name = "labelMoneda";
            this.labelMoneda.Size = new System.Drawing.Size(45, 13);
            this.labelMoneda.TabIndex = 14;
            this.labelMoneda.Text = "moneda";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(256, 71);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(45, 13);
            this.labelCantitate.TabIndex = 13;
            this.labelCantitate.Text = "cantiate";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(625, 104);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 12;
            this.btnTransfer.Text = "Transfera";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // comboBoxPoints
            // 
            this.comboBoxPoints.FormattingEnabled = true;
            this.comboBoxPoints.Location = new System.Drawing.Point(462, 104);
            this.comboBoxPoints.Name = "comboBoxPoints";
            this.comboBoxPoints.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPoints.TabIndex = 11;
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(335, 104);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMoneda.TabIndex = 10;
            this.comboBoxMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoneda_SelectedIndexChanged);
            // 
            // labelTransfer
            // 
            this.labelTransfer.AutoSize = true;
            this.labelTransfer.Location = new System.Drawing.Point(76, 107);
            this.labelTransfer.Name = "labelTransfer";
            this.labelTransfer.Size = new System.Drawing.Size(93, 13);
            this.labelTransfer.TabIndex = 9;
            this.labelTransfer.Text = "Creaza un transfer";
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(229, 104);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantitate.TabIndex = 8;
            // 
            // labelMaxim
            // 
            this.labelMaxim.AutoSize = true;
            this.labelMaxim.Location = new System.Drawing.Point(76, 144);
            this.labelMaxim.Name = "labelMaxim";
            this.labelMaxim.Size = new System.Drawing.Size(46, 13);
            this.labelMaxim.TabIndex = 16;
            this.labelMaxim.Text = "Maxim : ";
            // 
            // formTransInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 418);
            this.Controls.Add(this.labelMaxim);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelMoneda);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.comboBoxPoints);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.labelTransfer);
            this.Controls.Add(this.textBoxCantitate);
            this.Name = "formTransInt";
            this.Text = "formTransInt";
            this.Load += new System.EventHandler(this.formTransInt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelMoneda;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ComboBox comboBoxPoints;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.Label labelTransfer;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label labelMaxim;
    }
}