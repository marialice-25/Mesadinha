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
    public partial class frm_controle : Form
    {
        public frm_controle()
        {
            InitializeComponent();
        }

        conexaoBD bd = new conexaoBD();
        string sql;

        public void combo_boxcat()
        {
            sql = "select * from categorias";
            cbx_cat.DataSource = bd.ConsultarTabelas(sql);
            cbx_cat.DisplayMember = "categoria";
            cbx_cat.ValueMember = "id";
        }
        public void Listar()
        {
            sql = "select id,nome,tipo from conta";
            dgv_resultado.DataSource = bd.ConsultarTabelas(sql);
        }

        private void frm_controle_Load(object sender, EventArgs e)
        {
            Listar();
            combo_boxcat();
        }

        private void mnu_controle_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            movimentacao controle = new movimentacao();
            controle.ShowDialog();
            this.Visible = true;
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_gerenciamento controle = new frm_gerenciamento();
            controle.ShowDialog();
            this.Visible = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into conta(id,nome,tipo) values(null,'{0}','{1}')", txt_nomeconta.Text, cbx_tipo.Text);

            bd.AlterarTabelas(sql);
            MessageBox.Show("Conta cadastrada com sucesso...");
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Categorias controle = new Categorias();
            controle.ShowDialog();
            this.Visible = true;
        }
    }
}
