using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class formCursuriAgentie : Form
    {
        UserRepository user = new UserRepository();

        public formCursuriAgentie()
        {
            InitializeComponent();
        }
        private void formCursuriAgentie_Load(object sender, EventArgs e)
        {

            callonload();


        }

        private void callonload()
        {
            List<string> ratesList = user.getRatesData(Globals.IdPoints);

            tableCursuri.Controls.Clear();
            tableCursuri.ColumnCount = 6;
            tableCursuri.RowCount = ratesList.Count-1;
            int j = 0;
            
            for (int i = 0; i < ratesList.Count; i++)
            {
                
                string[] words = ratesList[i].Split('@');
                if (words[0] != "Leu romanesc")
                {

                    string c_id = words[5];
                    string id_rates2 = words[6];

                    Label nume_moneda = new Label();
                    nume_moneda.Text = words[0];
                    nume_moneda.AutoSize = true;

                    Label prescurtare_moneda = new Label();
                    prescurtare_moneda.Text = words[1];


                    Label cantitate = new Label();
                    cantitate.Text = words[2];

                    TextBox rata_cumparare = new TextBox();

                    rata_cumparare.Text = words[3];
                    rata_cumparare.Size = new Size(200, 30);

                    TextBox rata_vanzare = new TextBox();

                    rata_vanzare.Text = words[4];
                    rata_vanzare.Size = new Size(200, 30);

                    Button button = new Button();
                    button.Tag = j;
                    button.Text = "Salveaza";
                    button.Click += delegate (object sender2, EventArgs e2)
                    {
                        test(sender2, e2, c_id, id_rates2);
                    };

                    tableCursuri.Controls.Add(nume_moneda, 0, j);
                    tableCursuri.Controls.Add(prescurtare_moneda, 1, j);
                    tableCursuri.Controls.Add(cantitate, 2, j);
                    tableCursuri.Controls.Add(rata_cumparare, 3, j);
                    tableCursuri.Controls.Add(rata_vanzare, 4, j);
                    tableCursuri.Controls.Add(button, 5, j);
                    j++;
                }

            }
        }
        

        public void test(object sender, EventArgs e, string id_curr, string id_rates)
        {
            object tagValue = ((Button)sender).Tag;
            string rata1="";
            string rata2="";
            int check = 0;

            for (int r = 0; r < 1+ tableCursuri.RowCount; r++)
            {
                if (r == (int) tagValue)
                {
                    for (int j = 0; j < 1+ tableCursuri.ColumnCount; j++)
                    {
                        
                        Control c = this.tableCursuri.GetControlFromPosition(j, r);
                        
                        if ((c is TextBox)&&(check==0)) {

                            rata1 = c.Text;
                            check = 1;
                        }
                        else if ((c is TextBox)&&(check==1))
                        {
                            rata2 = c.Text;
                        }
                    }
                }

            }
            string query = "insert into rates_history SELECT * FROM rates where id= " + id_rates;
            string query1 = "delete from rates where id=" + id_rates;
            string query2 = "insert into rates (idpoints,idcurrency,rata_cumparare,rata_vanzare) values (" + Globals.IdPoints.ToString() + "," + id_curr + "," + rata1 + "," + rata2 + ")";
            user.Insert(query);
            user.Insert(query1);
            user.Insert(query2);
            callonload();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            
           FormDocumentCursuri form = new FormDocumentCursuri();
           form.Show();
        }
    }
}
