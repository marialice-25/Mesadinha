using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesadinha
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           frm_controle controle = new frm_controle();
            controle.ShowDialog();
            this.Visible = true;
            this.Close();
        }
    }
}
