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
    public partial class formRaportTranzactii : Form
    {
        private List<string> Tranzactii;
        UserRepository user = new UserRepository();
        public formRaportTranzactii()
        {
            InitializeComponent();
        }
        public formRaportTranzactii(List<string> a)
        {
            InitializeComponent();
            Tranzactii =a;
        }

        private void formRaportTranzactii_Load(object sender, EventArgs e)
        {
            callonload();
        }

        private void callonload()
        {
            string[] informatii = user.getMachetaCursuri();
            DataTable tranzactii = new DataTable();
            machetaTranzactii macheta = new machetaTranzactii();
            tranzactii.Columns.Add("name", typeof(string));
            tranzactii.Columns.Add("pointname", typeof(string));
            tranzactii.Columns.Add("rata_schimb", typeof(string));
            tranzactii.Columns.Add("created_at", typeof(string));
            tranzactii.Columns.Add("nume_moneda_cumparata", typeof(string));
            tranzactii.Columns.Add("nume_moneda_vanduta", typeof(string));
            tranzactii.Columns.Add("cantitate", typeof(string));
            tranzactii.Columns.Add("observatii", typeof(string));

            for (int i = 0; i < Tranzactii.Count; i++)
            {
                string[] words = Tranzactii[i].Split('@');
                tranzactii.Rows.Add(words[10]+" "+ words[11], words[9], words[3], words[4], words[5], words[6], words[8], words[7]);

            }
            macheta.Database.Tables["tranzactii"].SetDataSource(tranzactii);

            macheta.SetParameterValue("pNumeFirma", informatii[0]);
            macheta.SetParameterValue("pCui", informatii[1]);
            macheta.SetParameterValue("pAdresa", informatii[2]);
            macheta.SetParameterValue("pData", informatii[3]);
            macheta.SetParameterValue("pPointName", informatii[4]);










            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = macheta;
        }
    }
}
