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
    public partial class frm_gerenciamento : Form
    {
        public frm_gerenciamento()
        {
            InitializeComponent();
        }

        conexaoBD bd = new conexaoBD();
        string sql;

        public void Listar()
        {
            sql = "select * from usu";
            dgv_resultado.DataSource = bd.ConsultarTabelas(sql);
        }

        public void limpar()
        {
            txt_senha.Clear();
            txt_confirma.Clear();
            txt_nome.Clear();
            txt_tel.Clear();
            txt_end.Clear();
            txt_email.Clear();
            txt_id.Clear();
            txt_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_senha.Text == txt_confirma.Text)
            {
                sql = string.Format("insert into usu values(null,'{0}','{1}','{2}','{3}','{4}')"
                    , txt_nome.Text, txt_tel.Text, txt_email.Text, txt_end.Text, txt_senha.Text);

                bd.AlterarTabelas(sql);
                Listar();
                limpar();
            }
            else
            {
                MessageBox.Show("Senhas não compatíveis...");
                txt_confirma.Clear();
                txt_senha.Clear();
                txt_senha.Focus();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from usu where id = {0}", txt_id.Text);

            bd.AlterarTabelas(sql);
            Listar();
            limpar();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update usu set nome = '{0}', email = '{1}', telefone = '{2}', endereco = '{3}', senha = '{4}'",
                txt_nome.Text, txt_email.Text, txt_tel.Text, txt_end.Text, txt_senha.Text);

            bd.AlterarTabelas(sql);
            Listar();
            limpar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            sql = string.Format("select * from usu where id = '{0}' ", txt_id.Text);
            resultado = bd.ConsultarTabelas(sql);

            if (resultado.Rows.Count > 0)
            {
                txt_id.Text = resultado.Rows[0]["id"].ToString();
                txt_nome.Text = resultado.Rows[0]["nome"].ToString();
                txt_email.Text = resultado.Rows[0]["email"].ToString();
                txt_tel.Text = resultado.Rows[0]["sexo"].ToString();
                txt_end.Text = resultado.Rows[0]["endereco"].ToString();
                txt_senha.Text = resultado.Rows[0]["senha"].ToString();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_gerenciamento_Load(object sender, EventArgs e)
        {

        }
    } 
}
