using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace mesadinha
{
    class conexaoBD
    {
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            conexao = new MySqlConnection("persist security info = false; server=localhost; database=mesadinha; uid=root; pwd=");
            conexao.Open();
        }

        public void AlterarTabelas(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ConsultarTabelas(string sql)
        {
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}
