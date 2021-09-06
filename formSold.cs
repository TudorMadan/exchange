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
    public partial class formSold : Form
    {
        UserRepository userRepository = new UserRepository();
        public formSold()
        {
            InitializeComponent();
        }

        private void formSold_Load(object sender, EventArgs e)
        {
            List<string> list = userRepository.getSold(Globals.IdPoints);
            for(int i=0;i<list.Count;i++)
            {
                string[] words = list[i].Split('@');
                dataGridView1.Rows.Add(words[0], words[1], words[2]);
            }

        }
       
    }
}
