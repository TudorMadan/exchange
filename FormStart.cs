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
    public partial class formStart : Form
    {
        private string[] idPoints;
        UserRepository user = new UserRepository();
        string data1;
        string data2;

        public formStart()
        {
            InitializeComponent();
        }

        private void formStart_Load(object sender, EventArgs e)
        {
            callonload();
            getSetari();
        }
        private void callonload()
        {
            populatecombobox();
        }

        private void populatecombobox()
        {
            List<string> points = user.getUserPoints(Globals.IdFirma);
            string[] a = new string[points.Count];
            int j = 0;
            for (int i = 0; i < points.Count; i++)
            {
                string[] words = points[i].Split('@');
                comboBoxPoint.Items.Add(words[1]);
                a[j] = words[0];
                j++;
                

            }
            idPoints = a;
            var index= Array.FindIndex(idPoints, x => x.Contains(Globals.IdPoints.ToString()));
            comboBoxPoint.SelectedIndex = index;
        }
        private void getSetari()
        {
            data1 = datePrim.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            data2 = dateSecund.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            
        }

        private void btnTranzactii_Click(object sender, EventArgs e)
        {
            List<string> tranzactii = new List<string>();
            getSetari();
            if (checkBoxFirma.Checked)
            {
                tranzactii = user.getTranzactii(data1, data2, idPoints[comboBoxPoint.SelectedIndex], Globals.IdFirma.ToString());
            }
            else
            {
                tranzactii = user.getTranzactii(data1, data2, idPoints[comboBoxPoint.SelectedIndex]);
            }
            formRaportTranzactii form = new formRaportTranzactii(tranzactii);
            form.Show();
            
        }

        private void btnCursuri_Click(object sender, EventArgs e)
        {
            getSetari();
            List<CursuriIstoric> cursuri = user.getRatesHistory(data1,data2,idPoints[comboBoxPoint.SelectedIndex]);
            formRaportCursuriIstoric form = new formRaportCursuriIstoric(cursuri);
            form.Show();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            List<string> profit = new List<string>();
            getSetari();
            if (checkBoxFirma.Checked)
            {
                profit = user.getProfit(data1, data2, idPoints[comboBoxPoint.SelectedIndex],Globals.IdFirma.ToString());
            }
            else
            {
                profit = user.getProfit(data1, data2, idPoints[comboBoxPoint.SelectedIndex]);
            }
            formRaportProfit form = new formRaportProfit(profit);
            form.Show();
        }

    }
}
