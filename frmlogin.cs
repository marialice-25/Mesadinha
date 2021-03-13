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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        login obj_login = new login();
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(obj_login.validar(txt_email.Text, txt_senha.Text))
            {
                this.Visible = false;
                menu menu = new menu();
                menu.ShowDialog();
                this.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto...");
            }
        }
    }
}
