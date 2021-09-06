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
    public partial class formSchimb : Form
    {
        UserRepository userRepository = new UserRepository();
        string cantitateLei;
        string[] listaId = new string[25];
        string[] listaMonezi = new string[25];
        string[] listaCantitati = new string[25];
        string[] listaRata_c = new string[25];
        string[] listaRata_v = new string[25];
        int id_selectat;
        int id_client;
        public formSchimb()
        {
            InitializeComponent();
        }

        private void formSchimb_Load(object sender, EventArgs e)
        {
            callonload();
        }


        private void callonload()
        {
            textBoxObservatie.Text = "";
            textBoxInformatie.Text = "";
            textBoxCantitate.Text = "0";
            panelClient.Visible = false;
            panelTranzactie.Visible = false;
            List<string> listaRates = userRepository.getRatesData(Globals.IdPoints);

            List<string> listaCantitate = userRepository.getSoldList(Globals.IdPoints);



            comboBoxOptiune.Items.Add("Cumparare");
            comboBoxOptiune.Items.Add("Vanzare");
            comboBoxOptiune.SelectedIndex = 0;
         
            for (int i = 0; i < listaCantitate.Count; i++)
            {
                string[] words = listaCantitate[i].Split('@');
                if (words[1] == "Leu romanesc")
                {
                    this.cantitateLei = words[2];
                }

            }
            int c = 0;
            for (int i = 0; i < listaRates.Count; i++)
            {


                string[] words = listaRates[i].Split('@');
                if(words[1]!= "Leu romanesc")
                {
                    listaMonezi[i] = words[1];
                    listaCantitati[i] = words[2];
                    listaRata_c[i] = words[3];
                    listaRata_v[i] = words[4];
                    listaId[i] = words[5];
                    c++;
                }
                
            }


            PopulateComboboxMoneda(comboBoxMoneda, listaRates.Count);

            label();

        }

        private void PopulateComboboxMoneda(ComboBox boxToPopulate, int n)
        {
            boxToPopulate.Items.Clear();
            for (int i = 0; i < (n - 1); i++)
            {
                
                    boxToPopulate.Items.Add(listaMonezi[i]);
            }

        }


        private void comboBoxMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_selectat = int.Parse(listaId[comboBoxMoneda.Items.IndexOf(comboBoxMoneda.SelectedItem)]) - 1;
            label();
        }

        private void label()
        {
            if (comboBoxMoneda.SelectedIndex != -1)
            {
                labelCantitate.Text = "Cantitate " + listaMonezi[id_selectat] + ": " + listaCantitati[id_selectat];
                labelRataCumparare.Text = "Rata locala cumparare: " + listaRata_c[id_selectat];
                labelRataVanzare.Text = "Rata locala vanzare: " + listaRata_v[id_selectat];
            }
            labelLei.Text = "Cantitate lei : " + cantitateLei;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((comboBoxMoneda.SelectedIndex != -1) && (comboBoxOptiune.SelectedIndex != -1))
            {
                panelOptiune.Visible = false;
                popularePanel();
                panelTranzactie.Visible = true;
                panelClient.Visible = true;
            }

        }

        private void popularePanel()
        {

            comboBoxTipCurs.Items.Add("Fix");
            comboBoxTipCurs.Items.Add("Negociat");
            comboBoxTipCurs.SelectedIndex = 0;

            if (comboBoxOptiune.SelectedIndex == 0)//cumpara
            {
                textBoxCursLeu.Text = listaRata_c[id_selectat];

            }
            else if (comboBoxOptiune.SelectedIndex == 1)//vinde
            {
                textBoxCursLeu.Text = listaRata_v[id_selectat];

            }

            labelTranzactie();



        }


        private void labelTranzactie()
        {
            labelCumparat.Text = listaMonezi[id_selectat] + " " + comboBoxOptiune.SelectedItem;


            if (comboBoxOptiune.SelectedIndex == 0)//cumpara
            {
                labelPlatit.Text = "LEI de platit";
                labelMaxim.Text = "maxim : " + (float.Parse(cantitateLei) / float.Parse(textBoxCursLeu.Text)).ToString() + listaMonezi[id_selectat];

            }
            else if (comboBoxOptiune.SelectedIndex == 1)//vinde
            {
                labelPlatit.Text = "LEI de primit";
                labelMaxim.Text = "maxim : " + listaCantitati[id_selectat] + " " + listaMonezi[id_selectat];

            }


        }

        private void comboBoxTipCurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipCurs.SelectedIndex == 0)//fix
            {
                textBoxCursLeu.ReadOnly = true;
                if (comboBoxOptiune.SelectedIndex == 0)//cumpara
                {
                    textBoxCursLeu.Text = listaRata_c[id_selectat];

                }
                else if (comboBoxOptiune.SelectedIndex == 1)//vinde
                {
                    textBoxCursLeu.Text = listaRata_v[id_selectat];

                }

            }
            else if (comboBoxTipCurs.SelectedIndex == 1)//negociat
            {
                textBoxCursLeu.ReadOnly = false;
                if (comboBoxOptiune.SelectedIndex == 0)//cumpara
                {
                    textBoxCursLeu.Text = listaRata_c[id_selectat];

                }
                else if (comboBoxOptiune.SelectedIndex == 1)//vinde
                {
                    textBoxCursLeu.Text = listaRata_v[id_selectat];
                }

            }
        }

        private void btnDePlata_Click(object sender, EventArgs e)
        {
            textBoxPlata.Text = (float.Parse(textBoxCantitate.Text) * float.Parse(textBoxCursLeu.Text)).ToString();
        }



        private void btnResetare_Click(object sender, EventArgs e)
        {
            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            textBoxObservatie.Text = "";
            textBoxInformatie.Text = "";
            textBoxSerie.Text = "";
            textBoxNumar.Text = "";
            textBoxCNP.Text = "";
        }

        private void btnUltimul_Click(object sender, EventArgs e)
        {

            List<string> list = userRepository.getClientsUltimul(Globals.IdFirma, Globals.IdPoints);

            if (list.Count != 0)
            {
                string[] client_info;
                client_info = list[0].Split('@');
                textBoxNume.Text = client_info[0];
                textBoxPrenume.Text = client_info[1];
                textBoxInformatie.Text = client_info[2];
                textBoxSerie.Text = client_info[3];
                textBoxNumar.Text = client_info[4];
                textBoxCNP.Text = client_info[5];
                id_client = int.Parse(client_info[6]);
            }

        }

        private void btnCautaNume_Click(object sender, EventArgs e)
        {
            List<string> list = userRepository.getClientsNume(Globals.IdFirma, textBoxNume.Text);

            if (list.Count != 0)
            {
                string[] client_info;
                client_info = list[0].Split('@');
                textBoxNume.Text = client_info[0];
                textBoxPrenume.Text = client_info[1];
                textBoxInformatie.Text = client_info[2];
                textBoxSerie.Text = client_info[3];
                textBoxNumar.Text = client_info[4];
                textBoxCNP.Text = client_info[5];
                id_client = int.Parse(client_info[6]);
            }

        }

        private void btnCautaId_Click(object sender, EventArgs e)
        {
            List<string> list = userRepository.getClientsId(Globals.IdFirma, textBoxNumar.Text);
            if (list.Count != 0)
            {
                string[] client_info = list[0].Split('@');
                textBoxNume.Text = client_info[0];
                textBoxPrenume.Text = client_info[1];
                textBoxInformatie.Text = client_info[2];
                textBoxSerie.Text = client_info[3];
                textBoxNumar.Text = client_info[4];
                textBoxCNP.Text = client_info[5];
                id_client = int.Parse(client_info[6]);

            }
            
        }

        private void textBoxCursLeu_TextChanged(object sender, EventArgs e)
        {
            labelTranzactie();
            textBoxPlata.Text = (float.Parse(textBoxCantitate.Text) * float.Parse(textBoxCursLeu.Text)).ToString();
        }

        private void textBoxCantitate_TextChanged(object sender, EventArgs e)
        {
            labelTranzactie();

        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            insertTranzactiei();
        }
        private float cantitate;
        public void insertTranzactiei()
        {
            List<string> list = userRepository.getClientsId(Globals.IdFirma, textBoxNumar.Text);
            string query_client = "insert into clients (firstname,lastname,CNP,serie,numar,idfirma,informatii) values (" + "'" + textBoxNume.Text + "'" + "," + "'" + textBoxPrenume.Text + "'" + "," + "'" + textBoxCNP.Text + "'" + "," + "'" + textBoxSerie.Text + "'" + "," + "'" + textBoxNumar.Text + "'" + "," + Globals.IdFirma.ToString() + "," + "'" + textBoxInformatie.Text + "'" + ")";
            if (list.Count==0)
            {
                userRepository.Insert(query_client);
            }

            List<string> list1 = userRepository.getClientsId(Globals.IdFirma, textBoxNumar.Text);
            string[] client_info=list1[0].Split('@');
            id_client = int.Parse(client_info[6]);
            string numecump="";
            string numevand="";
            if(comboBoxOptiune.SelectedIndex==0)
            {
                numecump = listaMonezi[id_selectat];
                numevand = "RON";
            }
            
            if(comboBoxOptiune.SelectedIndex == 1)
            {
                numevand = listaMonezi[id_selectat];
                numecump = "RON";
            }
            cantitate = float.Parse(textBoxCantitate.Text) * float.Parse(textBoxCursLeu.Text);
            string query_transactions = "insert into transactions (cantitate,idclient,idpoint,rata_schimb,nume_moneda_cumparata,nume_moneda_vanduta,observatii,idfirma) values (" + cantitate.ToString() + "," + id_client.ToString() + "," + Globals.IdPoints.ToString() + "," + "'" + textBoxCursLeu.Text + "'" + "," + "'" + numecump + "'" + "," + "'" + numevand + "'" + "," + "'" + textBoxObservatie.Text + "'" + "," + Globals.IdFirma + ")";

            userRepository.Insert(query_transactions);


            string query_cantitati_cump = "";
            string query_cantitati_vand = "";


            if (comboBoxOptiune.SelectedIndex == 0)
            {
                cantitate = float.Parse(textBoxCantitate.Text)*float.Parse(textBoxCursLeu.Text);
                string id_leu = "";
                List<string> listaCantitate = userRepository.getSoldList(Globals.IdPoints);
                for (int i = 0; i < listaCantitate.Count; i++)
                {
                    string[] words = listaCantitate[i].Split('@');
                    if (words[1] == "Leu romanesc")
                    {
                        id_leu = words[0];
                    }

                }
                query_cantitati_cump = " update currency_point"  +
                    " set cantitate = cantitate +" + textBoxCantitate.Text +
                    " where idpoint=" + Globals.IdPoints.ToString() +
                    " and idcurrency=" + listaId[id_selectat];
                 query_cantitati_vand = " update currency_point" +
                    " set cantitate = cantitate -" + cantitate.ToString() +
                    " where idpoint=" + Globals.IdPoints.ToString() +
                    " and idcurrency=" + id_leu;
            }

            if (comboBoxOptiune.SelectedIndex == 1)
            {
                cantitate = float.Parse(textBoxCantitate.Text) * float.Parse(textBoxCursLeu.Text);
                string id_leu="";
                List<string> listaCantitate = userRepository.getSoldList(Globals.IdPoints);
                for (int i = 0; i < listaCantitate.Count; i++)
                {
                    string[] words = listaCantitate[i].Split('@');
                    if (words[1] == "Leu romanesc")
                    {
                        id_leu = words[0];
                    }

                }
                query_cantitati_cump = " update currency_point" +
                    " set cantitate = cantitate + " + cantitate.ToString() +
                    " where idpoint=" + Globals.IdPoints.ToString() +
                    " and idcurrency=" + id_leu;
                query_cantitati_vand = " update currency_point" +
                    " set cantitate = cantitate - " + textBoxCantitate.Text +
                    " where idpoint=" + Globals.IdPoints.ToString() +
                    " and idcurrency=" + listaId[id_selectat];
            }
            userRepository.Insert(query_cantitati_cump);
            userRepository.Insert(query_cantitati_vand);
            MessageBox.Show("Inregistrat!");
        }

        private void btnFormular_Click(object sender, EventArgs e)
        {
            string suma_tranz="";
            string suma_incasata="";
            string moneda_cump = "";
            string moneda_vand = "";
            if (comboBoxOptiune.SelectedIndex == 0)
            {
                cantitate = float.Parse(textBoxCantitate.Text) * float.Parse(textBoxCursLeu.Text);

                suma_incasata = textBoxCantitate.Text;
                suma_tranz = cantitate.ToString();
                moneda_vand = listaMonezi[id_selectat];
                moneda_cump = "RON";
            }

            if (comboBoxOptiune.SelectedIndex == 1)
            {
                cantitate = float.Parse(textBoxCantitate.Text) * float.Parse(textBoxCursLeu.Text);

                suma_tranz = textBoxCantitate.Text;
                suma_incasata = cantitate.ToString();
                moneda_cump = listaMonezi[id_selectat];
                moneda_vand = "RON";

            }

            string query = "insert into formulare (pointname,adresa,nume,prenume,serie,numar,suma_tranz,curs,suma_incasata,moneda_cump,moneda_vand) values('" + Globals.PointName + "', '" + Globals.Adresa + "', '" + textBoxNume.Text + "', '" + textBoxPrenume.Text + "', '" + textBoxSerie.Text + "', '" + textBoxNumar.Text + "', '" + suma_tranz + "', '" + textBoxCursLeu.Text + "', '" + suma_incasata + "', '" + moneda_cump + "', '" + moneda_vand + "')";

            formDocument form = new formDocument(query);
            form.Show();
            
        }
    }
}
