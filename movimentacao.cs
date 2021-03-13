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
    public partial class movimentacao : Form
    {
        public movimentacao()
        {
            InitializeComponent();
        }

        conexaoBD bd = new conexaoBD();
        string sql;
        public void Listar()
        {
            sql = "select * from movimentacoes";
            dgv_resultado.DataSource = bd.ConsultarTabelas(sql);
        }

        public void cbxconta()
        {
            sql = "select * from movimentacoes";
            cbx_conta.DataSource = bd.ConsultarTabelas(sql);
            cbx_conta.DisplayMember = "nome";
            cbx_conta.ValueMember = "id";
        }

        private void movimentacao_Load(object sender, EventArgs e)
        {
            Listar();
            cbxconta();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into movimentacoes values(null,'{0}','{1}')"
    , cbx_conta.Text, txt_valor.Text);

            bd.AlterarTabelas(sql);
            MessageBox.Show("Movimentação realizada com sucesso...");
            Listar();
        }
    }
}
