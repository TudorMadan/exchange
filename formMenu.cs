using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace proiect
{


    public partial class FormMenu : Form
    {

        #region functii

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        UserRepository userRepository = new UserRepository();
        Encryptor enc = new Encryptor();

        public FormMenu()
        {
            InitializeComponent();
            customizeDesign();
            panel1.Visible = true;
            panelSideMenu.Visible = false;


        }
        public void verificareLogare()
        {
            foreach (FormMenu oForm1 in Application.OpenForms.OfType<FormMenu>())
            {
                if (Globals.UserId == 0)
                {
                    oForm1.panelLog.Visible = true;
                    oForm1.panelMenu.Visible = false;
                }
                else
                {
                    oForm1.panelLog.Visible = false;
                    oForm1.panelMenu.Visible = true;
                }
            }
        }
        private void customizeDesign()
        {
            panelCasaSubmenu.Visible = false;
            panelValuteSubMenu.Visible = false;
            panelAjutorSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelCasaSubmenu.Visible == true)
                panelCasaSubmenu.Visible = false;
            if (panelValuteSubMenu.Visible == true)
                panelValuteSubMenu.Visible = false;
            if (panelAjutorSubMenu.Visible == true)
                panelAjutorSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        #region getset

        public Panel PanelChildForm { get { return panelChildForm; } set { panelChildForm = value; } }
        public Button butonValute { get { return btnValute; } set { btnValute=value; } }
        public Button butonCasa { get { return btnCasa; } }
        public Button butonStart { get { return btnStart; } }
        public Button butonAjutor { get { return btnAjutor; } }
        public Button butonLogin { get { return btnLogin; } }
        public Button butonRegister { get { return btnRegister; } }

        public Panel panelLog { get { return panel1; } set { panel1 = value; } }
        public Panel panelMenu { get { return panelSideMenu; } set { panelSideMenu = value; } }


        #endregion


        #region lista_puncte
        private void PopulateList(ComboBox boxToPopulate, string pointsList)
        {
            string[] words = pointsList.Split('@');
            boxToPopulate.Items.Add(words[1]);
        }

        public void populateComboBoxPoints(int id)
        {
            List<string> pointsList = userRepository.getUserPoints(id);
            comboBox1.Items.Clear();
            for (int i = 0; i < pointsList.Count; i++)
            {

                PopulateList(comboBox1, pointsList[i]);
            }
        }

        #endregion

        #region butoane

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void button_adauga_point_Click(object sender, EventArgs e)
        {


            string pointname = textbox_pointname.Text;

            string query = "INSERT INTO points (pointname, iduser) VALUES('" + pointname + "', '" + Globals.UserId + "')";

            userRepository.Insert(query);

            this.populateComboBoxPoints(Globals.UserId);

            panel3.BringToFront();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            openChildForm(new formLogin());
            hideSubMenu();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            openChildForm(new formRegister());
            hideSubMenu();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            openChildForm(new formStart());
            //
            //code here
            //
            hideSubMenu();
        }

        private void buttonCasaSubmenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCasaSubmenu);

        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            openChildForm(new formSold());//
            //code here
            //
            hideSubMenu();
        }

        private void btnSchimb_Click(object sender, EventArgs e)
        {
            openChildForm(new formSchimb());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnTransInt_Click(object sender, EventArgs e)
        {
            openChildForm(new formTransInt());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnTransExt_Click(object sender, EventArgs e)
        {
            openChildForm(new formTransExt());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnPlata_Click(object sender, EventArgs e)
        {
            openChildForm(new formPlata());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnIncasare_Click(object sender, EventArgs e)
        {
            openChildForm(new formIncasare());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnCursuriBNR_Click(object sender, EventArgs e)
        {
            openChildForm(new formCursuriBnr());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnCursuriAgentie_Click(object sender, EventArgs e)
        {
            openChildForm(new formCursuriAgentie());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            openChildForm(new formManual());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnSuport_Click(object sender, EventArgs e)
        {
            openChildForm(new formSuport());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnTermeni_Click(object sender, EventArgs e)
        {
            openChildForm(new formTermeni());
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnDespre_Click(object sender, EventArgs e)
        {
            openChildForm(new formDespre());
            //
            //code here
            //
            hideSubMenu();
        }

        private void buttonValuteSubMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelValuteSubMenu);
        }

        

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
            //
            //code here
            //
            hideSubMenu();
        }

        private void btnAjutor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAjutorSubMenu);
        }




        #endregion

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

