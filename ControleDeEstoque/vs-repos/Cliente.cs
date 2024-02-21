using ControleDeEstoque.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Repositorio
{
    internal class Cliente
    {
        public int idCliente { get; set; }
        public string? nomeCliente { get; set; }
        public string? endereco { get; set; }
        public string? cnpj { get; set; }
        public string? bairro { get; set; }
        public string? cidade { get; set; }
        public string? uf { get; set; }
        public bool ativo { get; set; }

        public static DataTable GetClientes()
        {
            string sql = "SELECT * FROM  clientes ORDER BY nomeCliente";

            //Cria o objeto que ira conter os dados
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao);
                conexao.Open();
                var sqlCommand = new MySqlCommand(sql, conexao);

                //Cria o objeto DataReader que executara o SQL no banco
                var dr = sqlCommand.ExecuteReader();

                //Atribui o DataReader ao DataTable
                dt.Load(dr);


                //Fecha a conexao
                dr.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public void SalvarCliente(string acao)
        {
            //Por padrão o SQL será para inclusão (Insert)
            string sql = "INSERT INTO clientes (nomeCliente,endereco,cnpj,bairro,cidade,uf,ativo) VALUES " +
                "(@nomeCliente,@endereco,@cnpj,@bairro,@cidade,@uf,@ativo)";

            //Caso o parametro acao for diferente de novo, indica que uma alteracao
            //Alteração a variavel SQL é redefinida para update
            if (acao != "novo")
            {
                sql = "UPDATE clientes SET nomeCliente=@nomeCliente,endereco=@endereco" +
                    ",cnpj=@cnpj,bairro=@bairro,cidade=@cidade,uf=@uf,ativo=@ativo WHERE idCliente=@idCliente";
            }

            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao);
                conexao.Open();
                var sqlCommand = new MySqlCommand(sql, conexao);
                sqlCommand.Parameters.AddWithValue("@idCliente", idCliente);
                sqlCommand.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                sqlCommand.Parameters.AddWithValue("@endereco", endereco);
                sqlCommand.Parameters.AddWithValue("@cnpj", cnpj);
                sqlCommand.Parameters.AddWithValue("@bairro", bairro);
                sqlCommand.Parameters.AddWithValue("@cidade", cidade);
                sqlCommand.Parameters.AddWithValue("@uf", uf);
                sqlCommand.Parameters.AddWithValue("@ativo", ativo);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GetCliente(int? id)
        {
            string sql = "SELECT * FROM clientes WHERE idCliente = @idCliente";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    var sqlCommand = new MySqlCommand(sql, conexao);
                    sqlCommand.Parameters.AddWithValue("@idCliente", id);

                    var dr = sqlCommand.ExecuteReader();

                    if (dr.Read())
                    {
                        idCliente = Convert.ToInt32(dr["idCliente"]);
                        nomeCliente = dr["nomeCliente"].ToString();
                        endereco = dr["endereco"].ToString();
                        bairro = dr["bairro"].ToString();
                        uf = dr["uf"].ToString();
                        cnpj = dr["cnpj"].ToString();
                        cidade = dr["cidade"].ToString();
                        ativo = Convert.ToBoolean(dr["ativo"]);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCliente(int? id)
        {
            string sql = "DELETE FROM clientes WHERE idCliente = @idCliente";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    var sqlCommand = new MySqlCommand(sql, conexao);
                    sqlCommand.Parameters.AddWithValue("@idCliente", id);
                    sqlCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
