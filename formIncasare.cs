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
    public partial class formIncasare : Form
    {
        private string[] id_moneda;
        private string[] cantitate;
        private float maxim;

        UserRepository user = new UserRepository();
        public formIncasare()
        {
            InitializeComponent();
        }

        private void formIncasare_Load(object sender, EventArgs e)
        {
            callonload();
        }
        private void callonload()
        {
            List<string> points = user.getUserPoints(Globals.IdFirma);
            textBoxSursa.Text = "";

            populateComboBoxMoneda();
            labelMaxim.Text = "Sold: " + cantitate[comboBoxMoneda.SelectedIndex];

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
        private void btnIncasare_Click(object sender, EventArgs e)
        {
            string query = "insert into incasare (idcurrency, idpoint, cantitate, observatii) values (" + id_moneda[comboBoxMoneda.SelectedIndex] + "," + Globals.IdPoints.ToString() + "," + textBoxCantitate.Text + "," + "'" + textBoxSursa.Text + "' " + ")";
            string query2 = "update currency_point set cantitate=cantitate+" + textBoxCantitate.Text + " WHERE idpoint=" + Globals.IdPoints.ToString() + " AND idcurrency=" + id_moneda[comboBoxMoneda.SelectedIndex];
            user.Insert(query);
            user.Insert(query2);
            int a = comboBoxMoneda.SelectedIndex;
            callonload();
            comboBoxMoneda.SelectedIndex = a;
            MessageBox.Show("Incasare inregistrata cu succes!");
        }

        private void comboBoxMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMaxim.Text = "Sold: " + cantitate[comboBoxMoneda.SelectedIndex];
        }
    }
}
