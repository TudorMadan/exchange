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
    public partial class formRegister : Form
    {
        UserRepository userRepository = new UserRepository();
        Encryptor enc = new Encryptor();
        public formRegister()
        {
            InitializeComponent();
        }
        public void registerUser(string username, string password, string email)
        {
            string cod_licenta = TextBoxLicenta.Text;
            string[] rezultat = userRepository.getRegister(cod_licenta);

            string md5Psw = enc.MD5Hash(password);
            string query = "INSERT INTO users (username, password, email, idfirma, idpoints) VALUES('" + username + "', '" + md5Psw + "', '" + email + "'," + rezultat[0] + "," + rezultat[1] + ")";
            

            userRepository.Insert(query);



            List<string>[] list = userRepository.getUser(username);
            List<string> pointsList = list[5];
            
            
            string[] cantitate = new string[10];
            string[] rata_cumparare = new string[10];
            string[] rata_vanzare = new string[10];
            List<string> rates = userRepository.getRatesData(int.Parse(pointsList[0]));
            for(int i=1;i<=9;i++)
            {
                cantitate[i] = "0";
                rata_cumparare[i] = "1";
                rata_vanzare[i] = "1";
            }
            for(int i=0;i<rates.Count;i++)
            {
                string[] words = rates[i].Split('@');
                cantitate[int.Parse(words[5])] = words[2];
                rata_cumparare[int.Parse(words[5])] = words[3];
                rata_vanzare[int.Parse(words[5])] = words[4];

            }
            string query3 = "DELETE FROM currency_point WHERE idpoint=" + pointsList[0];
            string query2 = "INSERT INTO currency_point (idpoint,idcurrency,cantitate) VALUES " 
                + "(" + pointsList[0] + "," + 1.ToString() + "," + cantitate[1] + "),"
                + "(" + pointsList[0] + "," + 2.ToString() + "," + cantitate[2] + "),"
                + "(" + pointsList[0] + "," + 3.ToString() + "," + cantitate[3] + "),"
                + "(" + pointsList[0] + "," + 4.ToString() + "," + cantitate[4] + "),"
                + "(" + pointsList[0] + "," + 5.ToString() + "," + cantitate[5] + "),"
                + "(" + pointsList[0] + "," + 6.ToString() + "," + cantitate[6] + "),"
                + "(" + pointsList[0] + "," + 7.ToString() + "," + cantitate[7] + "),"
                + "(" + pointsList[0] + "," + 8.ToString() + "," + cantitate[8] + "), "
                + "(" + pointsList[0] + "," + 9.ToString() + "," + cantitate[9] + ") "
                ;
            userRepository.Insert(query3);
            userRepository.Insert(query2);
            string query4 = "DELETE FROM rates WHERE idpoints=" + pointsList[0];
            string query1 = "INSERT INTO rates (idpoints,idcurrency,rata_cumparare,rata_vanzare) VALUES "
                + "(" + pointsList[0] + "," + 1 + "," + rata_cumparare[1] + "," + rata_vanzare[1] + "),"
                + "(" + pointsList[0] + "," + 2 + "," + rata_cumparare[2] + "," + rata_vanzare[2] + "),"
                + "(" + pointsList[0] + "," + 3 + "," + rata_cumparare[3] + "," + rata_vanzare[3] + "),"
                + "(" + pointsList[0] + "," + 4 + "," + rata_cumparare[4] + "," + rata_vanzare[4] + "),"
                + "(" + pointsList[0] + "," + 5 + "," + rata_cumparare[5] + "," + rata_vanzare[5] + "),"
                + "(" + pointsList[0] + "," + 6 + "," + rata_cumparare[6] + "," + rata_vanzare[6] + "),"
                + "(" + pointsList[0] + "," + 7 + "," + rata_cumparare[7] + "," + rata_vanzare[7] + "),"
                + "(" + pointsList[0] + "," + 8 + "," + rata_cumparare[8] + "," + rata_vanzare[8] + "),"
                + "(" + pointsList[0] + "," + 9 + "," + rata_cumparare[9] + "," + rata_vanzare[9] + ")"
                ;
            userRepository.Insert(query4);
            userRepository.Insert(query1);
            MessageBox.Show("Succes!");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.registerUser(username_register.Text, password_register.Text, email_register.Text);
        }

    }
}
