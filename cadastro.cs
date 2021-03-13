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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        conexaoBD bd = new conexaoBD();
        string sql;
        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(txt_senha.Text == txt_confirma.Text)
            {
                sql = string.Format("insert into usu values(null,'{0}','{1}','{2}','{3}','{4}')"
                    , txt_nome.Text, txt_tel.Text,txt_email.Text, txt_end.Text, txt_senha.Text);

                bd.AlterarTabelas(sql);
                MessageBox.Show("Usuário cadastrado com sucesso...");
                this.Close();
            }
            else
            {
                MessageBox.Show("Senhas não compatíveis...");
                txt_confirma.Clear();
                txt_senha.Clear();
                txt_senha.Focus();
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
