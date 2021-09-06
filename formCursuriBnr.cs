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
using System.Xml;


namespace proiect
{
    public partial class formCursuriBnr : Form
    {
        UserRepository user = new UserRepository();
        public formCursuriBnr()
        {
            InitializeComponent();

            XmlDocument doc1 = new XmlDocument();
            string URLString = "https://www.bnr.ro/nbrfxrates.xml";
            doc1.Load(URLString);

            // List<string> list = user.getCursuriBnr();
            string myXml = doc1.InnerText;
            MessageBox.Show(myXml);

           // for (int i = 0; i < list.Count; i++)
           // {
                //string[] words = list[i].Split('@');
               // dataGridView1.Rows.Add(words[0], words[1], words[2]);
          //  }
        }
    }
}
