using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class formRaportCursuriIstoric : Form
    {
        private List<CursuriIstoric> cursuri = new List<CursuriIstoric>();

        public formRaportCursuriIstoric()
        {
            InitializeComponent();
        }
        public formRaportCursuriIstoric(List<CursuriIstoric> a)
        {
            InitializeComponent();
            cursuri = a;
        }

        private void formRaportCursuriIstoric_Load(object sender, EventArgs e)
        {
            callonload();
        }

        private void callonload()
        {
            cursuriIstoricBindingSource.DataSource = cursuri;
            dataGridView1.Visible = false;
            string[] created_at = new string[cursuri.Count];
            string[] rata_medie = new string[cursuri.Count];
            string test = "";int j = 0;
            for(int i=0;i<cursuri.Count;i++)
            {
                if(cursuri[i].created_at!=test)
                {
                    created_at[j] = cursuri[i].created_at;
                    
                    test = created_at[j];

                    j++;

                }
                
                rata_medie[i] = cursuri[i].rata_medie.ToString();
            }
            created_at = created_at.Take(j).ToArray();
            graficCursuri.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title="Data",
                Labels=created_at

            });
            graficCursuri.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title="Rata medie",
                LabelFormatter=value=>value.ToString("C")
            });
            graficCursuri.LegendLocation = LiveCharts.LegendLocation.Right;
            
            
            

            graficCursuri.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var nume_moneda = (from o in cursuriIstoricBindingSource.DataSource as List<CursuriIstoric>
                               select new { Nume_moneda = o.nume_moneda }).Distinct();
            foreach(var nume in nume_moneda )
            {
                List<float> values = new List<float>();
                float value = 0;
                for (int i=0;i<created_at.Length;i++ )
                {
                    
                    var data = from o in cursuriIstoricBindingSource.DataSource as List<CursuriIstoric>
                               where o.nume_moneda.Equals(nume.Nume_moneda) && o.created_at.Equals(created_at[i])
                               orderby o.created_at ascending
                               select new { o.rata_medie, o.created_at };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().rata_medie;
                    values.Add(value);

                }
                series.Add(new LineSeries() { Title = nume.Nume_moneda.ToString(), Values = new ChartValues<float>(values)});
            }
            graficCursuri.Series = series;
            
        }
    }
}
