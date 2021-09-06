using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class formLogin : Form
    {
        UserRepository userRepository = new UserRepository();
        Encryptor enc = new Encryptor();
        public formLogin()
        {
            InitializeComponent();
        }
        public void loginUser(string username, string password)
        {

            List<string>[] list = userRepository.getUser(username);
            List<string> idList = list[0];
            List<string> usernameList = list[1];
            List<string> pswList = list[2];
            List<string> firmaList = list[4];
            List<string> pointsList = list[5];


            if (usernameList.Count > 0)
            {
                string psw = pswList[0].ToString();
                if (psw == enc.MD5Hash(password))
                {
                    UserRepository user = new UserRepository();
                    Globals.UserId = int.Parse(idList[0]);
                    Globals.UserName = usernameList[0];
                    Globals.IdFirma = int.Parse(firmaList[0]);
                    Globals.IdPoints = int.Parse(pointsList[0]);
                    string[] adresapointname = user.getAdresaPointname();
                    Globals.PointName = adresapointname[0];
                    Globals.Adresa = adresapointname[1];
                    Globals.Cui = adresapointname[2];
                    Globals.NumeFirma = adresapointname[3];

                   // MessageBox.Show(Globals.UserId.ToString() + Globals.UserName + Globals.IdFirma.ToString() + Globals.IdPoints.ToString());

                }
                else
                {
                    MessageBox.Show("Parola gresita");
                }
            }
            else
            {
                MessageBox.Show("Acest user nu este inregistrat!");
            }

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.loginUser(username_login.Text, password_login.Text);
            if (Globals.UserId!=0)
            {
                this.Close();
                foreach (FormMenu oForm1 in Application.OpenForms.OfType<FormMenu>())
                {
                    if (Globals.UserId == 0)
                    {
                        oForm1.panelLog.Visible = true;
                        oForm1.panelMenu.Visible = false;
                    }
                    else
                    {
                        oForm1.panelLog.Visible = false;
                        oForm1.panelMenu.Visible = true;
                    }
                }
                
            }
          

        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu form1 = new FormMenu();
            
            
            
            form1.openChildForm(new formRegister());
        }
    }
}
