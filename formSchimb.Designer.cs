namespace proiect
{
    partial class formSchimb
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
            this.panelOptiune = new System.Windows.Forms.Panel();
            this.labelRataVanzare = new System.Windows.Forms.Label();
            this.labelRataCumparare = new System.Windows.Forms.Label();
            this.labelLei = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.comboBoxOptiune = new System.Windows.Forms.ComboBox();
            this.panelTranzactie = new System.Windows.Forms.Panel();
            this.textBoxCursLeu = new System.Windows.Forms.TextBox();
            this.comboBoxTipCurs = new System.Windows.Forms.ComboBox();
            this.labelPlatit = new System.Windows.Forms.Label();
            this.labelCumparat = new System.Windows.Forms.Label();
            this.textBoxPlata = new System.Windows.Forms.TextBox();
            this.btnDePlata = new System.Windows.Forms.Button();
            this.labelMaxim = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.panelClient = new System.Windows.Forms.Panel();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnFormular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInformatie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.btnUltimul = new System.Windows.Forms.Button();
            this.btnResetare = new System.Windows.Forms.Button();
            this.btnCautaId = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxObservatie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.btnCautaNume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.panelOptiune.SuspendLayout();
            this.panelTranzactie.SuspendLayout();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptiune
            // 
            this.panelOptiune.Controls.Add(this.labelRataVanzare);
            this.panelOptiune.Controls.Add(this.labelRataCumparare);
            this.panelOptiune.Controls.Add(this.labelLei);
            this.panelOptiune.Controls.Add(this.labelCantitate);
            this.panelOptiune.Controls.Add(this.btnStart);
            this.panelOptiune.Controls.Add(this.comboBoxMoneda);
            this.panelOptiune.Controls.Add(this.comboBoxOptiune);
            this.panelOptiune.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptiune.Location = new System.Drawing.Point(0, 0);
            this.panelOptiune.Name = "panelOptiune";
            this.panelOptiune.Size = new System.Drawing.Size(920, 136);
            this.panelOptiune.TabIndex = 0;
            // 
            // labelRataVanzare
            // 
            this.labelRataVanzare.AutoSize = true;
            this.labelRataVanzare.Location = new System.Drawing.Point(194, 32);
            this.labelRataVanzare.Name = "labelRataVanzare";
            this.labelRataVanzare.Size = new System.Drawing.Size(105, 13);
            this.labelRataVanzare.TabIndex = 6;
            this.labelRataVanzare.Text = "Rata locala vanzare:";
            // 
            // labelRataCumparare
            // 
            this.labelRataCumparare.AutoSize = true;
            this.labelRataCumparare.Location = new System.Drawing.Point(194, 10);
            this.labelRataCumparare.Name = "labelRataCumparare";
            this.labelRataCumparare.Size = new System.Drawing.Size(117, 13);
            this.labelRataCumparare.TabIndex = 5;
            this.labelRataCumparare.Text = "Rata locala cumparare:";
            // 
            // labelLei
            // 
            this.labelLei.AutoSize = true;
            this.labelLei.Location = new System.Drawing.Point(16, 50);
            this.labelLei.Name = "labelLei";
            this.labelLei.Size = new System.Drawing.Size(63, 13);
            this.labelLei.TabIndex = 4;
            this.labelLei.Text = "CantitateLei";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(16, 63);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(85, 13);
            this.labelCantitate.TabIndex = 3;
            this.labelCantitate.Text = "Cantitate Valuta:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(64, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "initiaza";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Location = new System.Drawing.Point(100, 15);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(72, 21);
            this.comboBoxMoneda.TabIndex = 1;
            this.comboBoxMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoneda_SelectedIndexChanged);
            // 
            // comboBoxOptiune
            // 
            this.comboBoxOptiune.FormattingEnabled = true;
            this.comboBoxOptiune.Location = new System.Drawing.Point(19, 15);
            this.comboBoxOptiune.Name = "comboBoxOptiune";
            this.comboBoxOptiune.Size = new System.Drawing.Size(75, 21);
            this.comboBoxOptiune.TabIndex = 0;
            // 
            // panelTranzactie
            // 
            this.panelTranzactie.Controls.Add(this.textBoxCursLeu);
            this.panelTranzactie.Controls.Add(this.comboBoxTipCurs);
            this.panelTranzactie.Controls.Add(this.labelPlatit);
            this.panelTranzactie.Controls.Add(this.labelCumparat);
            this.panelTranzactie.Controls.Add(this.textBoxPlata);
            this.panelTranzactie.Controls.Add(this.btnDePlata);
            this.panelTranzactie.Controls.Add(this.labelMaxim);
            this.panelTranzactie.Controls.Add(this.textBoxCantitate);
            this.panelTranzactie.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTranzactie.Location = new System.Drawing.Point(0, 136);
            this.panelTranzactie.Name = "panelTranzactie";
            this.panelTranzactie.Size = new System.Drawing.Size(920, 123);
            this.panelTranzactie.TabIndex = 1;
            // 
            // textBoxCursLeu
            // 
            this.textBoxCursLeu.Location = new System.Drawing.Point(437, 39);
            this.textBoxCursLeu.Name = "textBoxCursLeu";
            this.textBoxCursLeu.ReadOnly = true;
            this.textBoxCursLeu.Size = new System.Drawing.Size(100, 20);
            this.textBoxCursLeu.TabIndex = 7;
            this.textBoxCursLeu.TextChanged += new System.EventHandler(this.textBoxCursLeu_TextChanged);
            // 
            // comboBoxTipCurs
            // 
            this.comboBoxTipCurs.FormattingEnabled = true;
            this.comboBoxTipCurs.Location = new System.Drawing.Point(322, 38);
            this.comboBoxTipCurs.Name = "comboBoxTipCurs";
            this.comboBoxTipCurs.Size = new System.Drawing.Size(109, 21);
            this.comboBoxTipCurs.TabIndex = 6;
            this.comboBoxTipCurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipCurs_SelectedIndexChanged);
            // 
            // labelPlatit
            // 
            this.labelPlatit.AutoSize = true;
            this.labelPlatit.Location = new System.Drawing.Point(142, 21);
            this.labelPlatit.Name = "labelPlatit";
            this.labelPlatit.Size = new System.Drawing.Size(52, 13);
            this.labelPlatit.TabIndex = 5;
            this.labelPlatit.Text = "labelPlatit";
            // 
            // labelCumparat
            // 
            this.labelCumparat.AutoSize = true;
            this.labelCumparat.Location = new System.Drawing.Point(36, 21);
            this.labelCumparat.Name = "labelCumparat";
            this.labelCumparat.Size = new System.Drawing.Size(74, 13);
            this.labelCumparat.TabIndex = 4;
            this.labelCumparat.Text = "labelCumparat";
            // 
            // textBoxPlata
            // 
            this.textBoxPlata.Location = new System.Drawing.Point(145, 37);
            this.textBoxPlata.Name = "textBoxPlata";
            this.textBoxPlata.ReadOnly = true;
            this.textBoxPlata.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlata.TabIndex = 3;
            // 
            // btnDePlata
            // 
            this.btnDePlata.Location = new System.Drawing.Point(251, 37);
            this.btnDePlata.Name = "btnDePlata";
            this.btnDePlata.Size = new System.Drawing.Size(30, 20);
            this.btnDePlata.TabIndex = 2;
            this.btnDePlata.Text = "🔍";
            this.btnDePlata.UseVisualStyleBackColor = true;
            this.btnDePlata.Click += new System.EventHandler(this.btnDePlata_Click);
            // 
            // labelMaxim
            // 
            this.labelMaxim.AutoSize = true;
            this.labelMaxim.Location = new System.Drawing.Point(36, 60);
            this.labelMaxim.Name = "labelMaxim";
            this.labelMaxim.Size = new System.Drawing.Size(59, 13);
            this.labelMaxim.TabIndex = 1;
            this.labelMaxim.Text = "labelMaxim";
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(39, 37);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantitate.TabIndex = 0;
            this.textBoxCantitate.TextChanged += new System.EventHandler(this.textBoxCantitate_TextChanged);
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.btnInregistrare);
            this.panelClient.Controls.Add(this.btnFormular);
            this.panelClient.Controls.Add(this.label7);
            this.panelClient.Controls.Add(this.textBoxInformatie);
            this.panelClient.Controls.Add(this.label6);
            this.panelClient.Controls.Add(this.textBoxCNP);
            this.panelClient.Controls.Add(this.btnUltimul);
            this.panelClient.Controls.Add(this.btnResetare);
            this.panelClient.Controls.Add(this.btnCautaId);
            this.panelClient.Controls.Add(this.label5);
            this.panelClient.Controls.Add(this.textBoxNumar);
            this.panelClient.Controls.Add(this.label4);
            this.panelClient.Controls.Add(this.textBoxSerie);
            this.panelClient.Controls.Add(this.label3);
            this.panelClient.Controls.Add(this.textBoxObservatie);
            this.panelClient.Controls.Add(this.label2);
            this.panelClient.Controls.Add(this.textBoxPrenume);
            this.panelClient.Controls.Add(this.btnCautaNume);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Controls.Add(this.textBoxNume);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClient.Location = new System.Drawing.Point(0, 259);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(920, 203);
            this.panelClient.TabIndex = 2;
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Location = new System.Drawing.Point(510, 162);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(72, 24);
            this.btnInregistrare.TabIndex = 23;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnFormular
            // 
            this.btnFormular.Location = new System.Drawing.Point(407, 162);
            this.btnFormular.Name = "btnFormular";
            this.btnFormular.Size = new System.Drawing.Size(66, 24);
            this.btnFormular.TabIndex = 22;
            this.btnFormular.Text = "Formular";
            this.btnFormular.UseVisualStyleBackColor = true;
            this.btnFormular.Click += new System.EventHandler(this.btnFormular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Informatii despre client";
            // 
            // textBoxInformatie
            // 
            this.textBoxInformatie.Location = new System.Drawing.Point(543, 114);
            this.textBoxInformatie.Name = "textBoxInformatie";
            this.textBoxInformatie.Size = new System.Drawing.Size(215, 20);
            this.textBoxInformatie.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CNP:";
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(342, 113);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(195, 20);
            this.textBoxCNP.TabIndex = 18;
            // 
            // btnUltimul
            // 
            this.btnUltimul.Location = new System.Drawing.Point(681, 19);
            this.btnUltimul.Name = "btnUltimul";
            this.btnUltimul.Size = new System.Drawing.Size(61, 20);
            this.btnUltimul.TabIndex = 17;
            this.btnUltimul.Text = "Ultimul";
            this.btnUltimul.UseVisualStyleBackColor = true;
            this.btnUltimul.Click += new System.EventHandler(this.btnUltimul_Click);
            // 
            // btnResetare
            // 
            this.btnResetare.Location = new System.Drawing.Point(596, 19);
            this.btnResetare.Name = "btnResetare";
            this.btnResetare.Size = new System.Drawing.Size(61, 20);
            this.btnResetare.TabIndex = 16;
            this.btnResetare.Text = "Resetare";
            this.btnResetare.UseVisualStyleBackColor = true;
            this.btnResetare.Click += new System.EventHandler(this.btnResetare_Click);
            // 
            // btnCautaId
            // 
            this.btnCautaId.Location = new System.Drawing.Point(266, 113);
            this.btnCautaId.Name = "btnCautaId";
            this.btnCautaId.Size = new System.Drawing.Size(61, 20);
            this.btnCautaId.TabIndex = 15;
            this.btnCautaId.Text = "🔍 Cauta";
            this.btnCautaId.UseVisualStyleBackColor = true;
            this.btnCautaId.Click += new System.EventHandler(this.btnCautaId_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Numar ID";
            // 
            // textBoxNumar
            // 
            this.textBoxNumar.Location = new System.Drawing.Point(160, 113);
            this.textBoxNumar.Name = "textBoxNumar";
            this.textBoxNumar.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Serie ID";
            // 
            // textBoxSerie
            // 
            this.textBoxSerie.Location = new System.Drawing.Point(39, 113);
            this.textBoxSerie.Name = "textBoxSerie";
            this.textBoxSerie.Size = new System.Drawing.Size(71, 20);
            this.textBoxSerie.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Observatii despre tranzactie";
            // 
            // textBoxObservatie
            // 
            this.textBoxObservatie.Location = new System.Drawing.Point(322, 35);
            this.textBoxObservatie.Name = "textBoxObservatie";
            this.textBoxObservatie.Size = new System.Drawing.Size(215, 20);
            this.textBoxObservatie.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(211, 35);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenume.TabIndex = 7;
            // 
            // btnCautaNume
            // 
            this.btnCautaNume.Location = new System.Drawing.Point(142, 34);
            this.btnCautaNume.Name = "btnCautaNume";
            this.btnCautaNume.Size = new System.Drawing.Size(61, 20);
            this.btnCautaNume.TabIndex = 6;
            this.btnCautaNume.Text = "🔍 Cauta";
            this.btnCautaNume.UseVisualStyleBackColor = true;
            this.btnCautaNume.Click += new System.EventHandler(this.btnCautaNume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume (de familie)";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(39, 34);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 20);
            this.textBoxNume.TabIndex = 1;
            // 
            // formSchimb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 527);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.panelTranzactie);
            this.Controls.Add(this.panelOptiune);
            this.Name = "formSchimb";
            this.Text = "formSchimb";
            this.Load += new System.EventHandler(this.formSchimb_Load);
            this.panelOptiune.ResumeLayout(false);
            this.panelOptiune.PerformLayout();
            this.panelTranzactie.ResumeLayout(false);
            this.panelTranzactie.PerformLayout();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptiune;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.ComboBox comboBoxOptiune;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Label labelLei;
        private System.Windows.Forms.Label labelRataVanzare;
        private System.Windows.Forms.Label labelRataCumparare;
        private System.Windows.Forms.Panel panelTranzactie;
        private System.Windows.Forms.TextBox textBoxPlata;
        private System.Windows.Forms.Button btnDePlata;
        private System.Windows.Forms.Label labelMaxim;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label labelPlatit;
        private System.Windows.Forms.Label labelCumparat;
        private System.Windows.Forms.TextBox textBoxCursLeu;
        private System.Windows.Forms.ComboBox comboBoxTipCurs;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Button btnCautaNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxObservatie;
        private System.Windows.Forms.Button btnCautaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumar;
        private System.Windows.Forms.Button btnUltimul;
        private System.Windows.Forms.Button btnResetare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInformatie;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnFormular;
    }
}