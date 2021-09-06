using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class formTransExt : Form
    {
        UserRepository user = new UserRepository();
      
        public formTransExt()
        {
            InitializeComponent();
        }

        private void formTransExt_Load(object sender, EventArgs e)
        {
            callonload();
        }
        private void callonload()
        {
            List<string> transfer = user.getTransferInt(Globals.IdPoints);
            tableTransfer.Controls.Clear();
            tableTransfer.ColumnCount = 4;
            tableTransfer.RowCount = transfer.Count;
            if (transfer.Count != 0)
            {
                for (int i = 0; i < transfer.Count; i++)
                {

                    string[] words = transfer[i].Split('@');
                    string idTransfer = words[0];
                    string idcurr = words[3];

                    Label pointname = new Label();
                    pointname.Text = words[7];

                    Label cantitate = new Label();
                    cantitate.Text = words[4];

                    Label prescurtare_moneda = new Label();
                    prescurtare_moneda.Text = words[8];

                    Button button = new Button();
                    button.Tag = i;
                    button.Text = "Incaseaza";
                    button.AutoSize = true;
                    button.Click += delegate (object sender2, EventArgs e2)
                    {
                        test(sender2, e2, idTransfer, idcurr);
                    };

                    tableTransfer.Controls.Add(pointname, 0, i);
                    tableTransfer.Controls.Add(cantitate, 1, i);
                    tableTransfer.Controls.Add(prescurtare_moneda, 2, i);
                    tableTransfer.Controls.Add(button, 3, i);



                }
            }
            else
                MessageBox.Show("Niciun transfer detectat!");
        }

        public void test(object sender, EventArgs e, string idTransf, string idcurrency)
        {
            object tagValue = ((Button)sender).Tag;
            string[] valori = new string[3];
            int i = 0;
            

            for (int r = 0; r < 1 + tableTransfer.RowCount; r++)
            {
                if (r == (int)tagValue)
                {
                    for (int j = 0; j < 1 + tableTransfer.ColumnCount; j++)
                    {

                        Control c = this.tableTransfer.GetControlFromPosition(j, r);

                        if (c is Label) 
                        {

                            valori[i] = c.Text;
                            i++;
                        }
                        
                    }
                }

            }
            string query = "update transferint set incasat=1 where id=" + idTransf;//seteaza transferint drept incasat=1
            string query1 = "update currency_point set cantitate=cantitate + " + valori[1] + " WHERE idpoint=" + Globals.IdPoints + " AND idcurrency= " + idcurrency;//incaseaza suma in sold
            user.Insert(query);
            user.Insert(query1);
            callonload();
            MessageBox.Show("Incasat!");
        }

    }
}
