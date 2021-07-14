using ProjetoPizzaria.Bean;
using ProjetoPizzaria.Generica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Acoes
{
    class Cls_ClienteAcoes
    {
        public string msg = "";
        public void Inserir(Cls_Cliente objCliente)
        {
            Cls_Conexao conec = new Cls_Conexao();
            conec.conectar();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_IncluirCliente", conec.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cliente_nome", objCliente.Nome).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_cadastro", objCliente.Cadastro).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_endereco", objCliente.Endereco.Endereco).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_bairro", objCliente.Endereco.Bairro).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_cep", objCliente.Endereco.Cep).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_cidade", objCliente.Endereco.Cidade).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_uf", objCliente.Endereco.Uf).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_telefone", objCliente.Telefone).Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("cliente_email", objCliente.Email).Direction = ParameterDirection.Input;
                cmd.ExecuteReader(CommandBehavior.SingleRow);

            }
            catch (Exception ex)
            {
                msg += ex.Message.ToString();
            }
            finally
            {
                conec.desconectar();
            }
        }

        public DataTable consultaCliente(string nome,string cadastro,int codigo)
        {
            string strSql = "";
            Cls_Conexao conec = new Cls_Conexao();
            conec.conectar();
            SqlCommand cmd;
            try
            {
                strSql = "SELECT cliente_codigo,cliente_nome,cliente_bairro,cliente_telefone,cliente_email,cliente_cadastro,cliente_cidade,cliente_cep,cliente_endereco,cliente_uf";
                strSql += " FROM TB_CLIENTE WHERE CLIENTE_CODIGO>0";

                if (codigo >0)
                {
                    strSql += " AND cliente_codigo=" + nome;
                }

                if (nome != "")
                {
                    strSql += " AND  cliente_nome like '%"+nome+"%";
                }

                if (cadastro != "")
                {
                    strSql += " AND  cliente_cadastro="+cadastro;
                }


                cmd = new SqlCommand(strSql, conec.conexao);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
                return null;
            }
            finally
            {
                conec.desconectar();
            }
        }


    }
}
