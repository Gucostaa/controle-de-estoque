using ControleDeEstoque.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace ControleDeEstoque.Repositorio
{
    internal class Produto
    {
        public int IdProduto { get; set; }
        public string? NomeProduto { get; set; }
        public string? Unidade { get; set; }
        public double Preco { get; set; }
        public double Imposto { get; set; }


        public static DataTable GetProdutos()
        {
            string sql = "SELECT * FROM  produtos ORDER BY idProduto";

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

        public void SalvarProduto(string acao)
        {
            //Por padrão o SQL será para inclusão (Insert)
            string sql = "INSERT INTO produtos (nomeProduto,unidade,preco,imposto) VALUES " +
                "(@nomeProduto,@unidade,@preco,@imposto)";

            //Caso o parametro acao for diferente de novo, indica que uma alteracao
            //Alteração a variavel SQL é redefinida para update
            if (acao != "novo")
            {
                sql = "UPDATE produtos SET nomeProduto=@nomeProduto,unidade=@unidade" +
                    ",preco=@preco,imposto=@imposto WHERE idProduto=@idProduto";
            }

            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao);
                conexao.Open();
                var sqlCommand = new MySqlCommand(sql, conexao);
                sqlCommand.Parameters.AddWithValue("@idProduto", IdProduto);
                sqlCommand.Parameters.AddWithValue("@nomeProduto", NomeProduto);
                sqlCommand.Parameters.AddWithValue("@unidade", Unidade);
                sqlCommand.Parameters.AddWithValue("@preco", Preco);
                sqlCommand.Parameters.AddWithValue("@imposto", Imposto);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirProduto(int? id)
        {
            string sql = "DELETE FROM produtos WHERE idProduto = @idProduto";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    var sqlCommand = new MySqlCommand(sql, conexao);
                    sqlCommand.Parameters.AddWithValue("@idProduto", id);
                    sqlCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //pega o produto pelo id usado para excluir ou editar   
        public void GetProduto(int? id)
        {
            string sql = "SELECT * FROM produtos WHERE idProduto = @idProduto";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    var sqlCommand = new MySqlCommand(sql, conexao);
                    sqlCommand.Parameters.AddWithValue("@idProduto", id);

                    var dr = sqlCommand.ExecuteReader();

                    if (dr.Read())
                    {
                        IdProduto = Convert.ToInt32(dr["idProduto"]);
                        NomeProduto = dr["nomeProduto"].ToString();
                        Unidade = dr["unidade"].ToString();
                        Preco = Convert.ToDouble(dr["preco"]);
                        Imposto = Convert.ToDouble(dr["imposto"]);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
