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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        conexaoBD bd = new conexaoBD();
        string sql;

        public void Listar()
        {
            sql = "select * from categorias";
            dgv_resultado.DataSource = bd.ConsultarTabelas(sql);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into categorias values(null,'{0}')", txt_categoria.Text);

            bd.AlterarTabelas(sql);
            MessageBox.Show("Categoria cadastrada com sucesso...");
            Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_controle controle = new frm_controle();
            controle.Show();
            this.Close();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
