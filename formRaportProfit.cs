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
    public partial class formRaportProfit : Form
    {
        private List<string> ProfitZile;
        public formRaportProfit()
        {
            InitializeComponent();
        }
        public formRaportProfit(List<string> a)
        {
            InitializeComponent();
            ProfitZile = a;
        }

        private void formRaportProfit_Load(object sender, EventArgs e)
        {

        }
    }
}
