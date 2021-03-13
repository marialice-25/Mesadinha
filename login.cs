using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace mesadinha
{
    class login
    {
        public bool validar(string usuario, string senha)
        {
            conexaoBD bd = new conexaoBD();
            DataTable resultado = new DataTable();
            string sql = string.Format("select * from usu where email='{0}' and senha='{1}'"
                , usuario, senha);

            resultado = bd.ConsultarTabelas(sql);
            if(resultado.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
