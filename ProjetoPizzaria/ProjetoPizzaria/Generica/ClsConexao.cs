using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Generica
{
    class Cls_Conexao
    {

            public SqlConnection conexao = new SqlConnection();

            public void conectar()
            {
            conexao.ConnectionString = "Server=localhost; Database=bd_Pizzaria; Trusted_Connection=True;";
            conexao.Open();
            }

            public void desconectar()
            {
                conexao.Close();
            }
        
    }
}
