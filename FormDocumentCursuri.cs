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
    public partial class FormDocumentCursuri : Form
    {
        UserRepository userRepository = new UserRepository();
        public FormDocumentCursuri()
        {
            InitializeComponent();
        }

        private void FormDocumentCursuri_Load(object sender, EventArgs e)
        {
            List<string> ratesList = userRepository.getRatesData(Globals.IdPoints);
            string[] informatii = userRepository.getMachetaCursuri();
            DataTable cursuri = new DataTable();
            MachetaCursuri macheta = new MachetaCursuri();
            cursuri.Columns.Add("NumeMoneda", typeof(string));
            cursuri.Columns.Add("PrescurtareMoneda", typeof(string));
            cursuri.Columns.Add("Cumparare", typeof(string));
            cursuri.Columns.Add("Vanzare", typeof(string));

            for(int i=0;i<ratesList.Count;i++)
            {
                string[] words = ratesList[i].Split('@');
                if(words[1]!="RON")
                    cursuri.Rows.Add(words[0],words[1],words[3],words[4]);
                
            }
            macheta.Database.Tables["cursuri"].SetDataSource(cursuri);

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
