namespace proiect
{
    partial class formRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email_register = new System.Windows.Forms.TextBox();
            this.password_register = new System.Windows.Forms.TextBox();
            this.username_register = new System.Windows.Forms.TextBox();
            this.TextBoxLicenta = new System.Windows.Forms.TextBox();
            this.labe_licenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(488, 269);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Username";
            // 
            // email_register
            // 
            this.email_register.Location = new System.Drawing.Point(470, 187);
            this.email_register.Margin = new System.Windows.Forms.Padding(4);
            this.email_register.Name = "email_register";
            this.email_register.Size = new System.Drawing.Size(132, 20);
            this.email_register.TabIndex = 16;
            // 
            // password_register
            // 
            this.password_register.Location = new System.Drawing.Point(470, 141);
            this.password_register.Margin = new System.Windows.Forms.Padding(4);
            this.password_register.Name = "password_register";
            this.password_register.Size = new System.Drawing.Size(132, 20);
            this.password_register.TabIndex = 15;
            // 
            // username_register
            // 
            this.username_register.Location = new System.Drawing.Point(470, 93);
            this.username_register.Margin = new System.Windows.Forms.Padding(4);
            this.username_register.Name = "username_register";
            this.username_register.Size = new System.Drawing.Size(132, 20);
            this.username_register.TabIndex = 14;
            // 
            // TextBoxLicenta
            // 
            this.TextBoxLicenta.Location = new System.Drawing.Point(470, 225);
            this.TextBoxLicenta.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLicenta.Name = "TextBoxLicenta";
            this.TextBoxLicenta.Size = new System.Drawing.Size(132, 20);
            this.TextBoxLicenta.TabIndex = 21;
            // 
            // labe_licenta
            // 
            this.labe_licenta.AutoSize = true;
            this.labe_licenta.Location = new System.Drawing.Point(382, 225);
            this.labe_licenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe_licenta.Name = "labe_licenta";
            this.labe_licenta.Size = new System.Drawing.Size(59, 13);
            this.labe_licenta.TabIndex = 22;
            this.labe_licenta.Text = "cod licenta";
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 418);
            this.Controls.Add(this.labe_licenta);
            this.Controls.Add(this.TextBoxLicenta);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_register);
            this.Controls.Add(this.password_register);
            this.Controls.Add(this.username_register);
            this.Name = "formRegister";
            this.Text = "formRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_register;
        private System.Windows.Forms.TextBox password_register;
        private System.Windows.Forms.TextBox username_register;
        private System.Windows.Forms.TextBox TextBoxLicenta;
        private System.Windows.Forms.Label labe_licenta;
    }
}