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
    public partial class formTransInt : Form
    {
        UserRepository user = new UserRepository();
        private string[] id_punct;
        private string[] id_moneda;
        private string[] cantitate;
        private float maxim;

        public formTransInt()
        {
            InitializeComponent();
        }


        private void formTransInt_Load(object sender, EventArgs e)
        {
            callonload();
        }

        private void callonload()
        {
            List<string> points = user.getUserPoints(Globals.IdFirma);

            populateComboBoxMoneda();
            populateComboBoxPoints();
            labelMaxim.Text = "Maxim: " + cantitate[comboBoxMoneda.SelectedIndex];
        }
        private void populateComboBoxMoneda()
        {
            List<string> points = user.getRatesData(Globals.IdPoints);
            string[] a = new string[points.Count];
            string[] b = new string[points.Count];
            for (int i = 0; i < points.Count; i++)
            {
                string[] words = points[i].Split('@');
                comboBoxMoneda.Items.Add(words[1]);
                a[i] = words[5];
                b[i] = words[2];
                
            }
            id_moneda = a;
            cantitate = b;
            comboBoxMoneda.SelectedIndex = 0;
            maxim = float.Parse(cantitate[0]);
        }

        private void populateComboBoxPoints()
        {
            List<string> points = user.getUserPoints(Globals.IdFirma);
            string[] a = new string[points.Count];
            int n = points.Count-1;
            int j = 0;
            for (int i = 0; i < points.Count; i++)
            {
                string[] words = points[i].Split('@');
                if (int.Parse(words[0]) != Globals.IdPoints)
                {
                    comboBoxPoints.Items.Add(words[1]);
                    a[j] = words[0];
                    j++;
                }

            }
            id_punct = a;
            comboBoxPoints.SelectedIndex = 0;

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(float.Parse(textBoxCantitate.Text)<=maxim)
            {
                string query = "insert into transferint (idpoint_trimis, idpoint_primit, idcurrency, cantitate) values (" + Globals.IdPoints + "," + id_punct[comboBoxPoints.SelectedIndex] + "," + id_moneda[comboBoxMoneda.SelectedIndex] + "," + textBoxCantitate.Text + ")";
                string query2 = " update currency_point" +
                        " set cantitate = cantitate -" + textBoxCantitate.Text +
                        " where idpoint=" + Globals.IdPoints.ToString() +
                        " and idcurrency=" + id_moneda[comboBoxMoneda.SelectedIndex];
                user.Insert(query);
                user.Insert(query2);
                MessageBox.Show("Succes!");
            }
            else
                MessageBox.Show("Suma este mai mare decat disponibilul!");
            int a = comboBoxMoneda.SelectedIndex;
            callonload();
            comboBoxMoneda.SelectedIndex = a;
        }

        private void comboBoxMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMaxim.Text = "Maxim: " + cantitate[comboBoxMoneda.SelectedIndex];
            maxim = float.Parse(cantitate[comboBoxMoneda.SelectedIndex]);
        }
    }
}
