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
    public partial class formDocument : Form
    {
        UserRepository userRepository = new UserRepository();
        private string queryformular="";
        public formDocument()
        {
            InitializeComponent();
        }
        public formDocument(string a)
        {
            queryformular = a;
            InitializeComponent();
        }

        private void formDocument_Load(object sender, EventArgs e)
        {
            List<string> rates = userRepository.getRatesData(Globals.IdPoints);

            string id;
            id = userRepository.InsertId(queryformular);

            formularAcceptare a = userRepository.getFormularAcceptare(id);
            machetaAcceptare1.SetParameterValue("ppointname",a.pointname);
            machetaAcceptare1.SetParameterValue("padresa",a.adresa);
            machetaAcceptare1.SetParameterValue("pcreated_at",a.created_at);
            machetaAcceptare1.SetParameterValue("pnume",a.nume);
            machetaAcceptare1.SetParameterValue("pprenume",a.prenume);
            machetaAcceptare1.SetParameterValue("pserie",a.serie);
            machetaAcceptare1.SetParameterValue("psuma_tranz",a.suma_tranz);
            machetaAcceptare1.SetParameterValue("pcurs", a.curs);
            machetaAcceptare1.SetParameterValue("psuma_incasata", a.suma_incasata);
            machetaAcceptare1.SetParameterValue("pid", id);
            machetaAcceptare1.SetParameterValue("pnumar", a.numar);
            machetaAcceptare1.SetParameterValue("pmoneda_cump", a.moneda_cump);
            machetaAcceptare1.SetParameterValue("pmoneda_vand", a.moneda_vand);
            crystalReportViewer1.ReportSource = machetaAcceptare1;

          

        }
    }
}
