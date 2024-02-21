using ControleDeEstoque.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace ControleDeEstoque.Repositorio
{
    internal class Usuario
    {
        public int idUsuario { get; set; }
        public string? user { get; set; }
        public string? senha { get; set; }
        public string? nivel { get; set; }



        public static DataTable GetUsuarios()
        {
            string sql = "SELECT idUsuario,user,nivel FROM  usuarios ORDER BY idUsuario";

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

        public void SalvarUsuario(string acao)
        {
            //Por padrão o SQL será para inclusão (Insert)
            string sql = "INSERT INTO usuarios (user,senha,nivel) VALUES " +
                "(@user,@senha,@nivel)";

            //Caso o parametro acao for diferente de novo, indica que uma alteracao
            //Alteração a variavel SQL é redefinida para update
            if (acao != "novo")
            {
                sql = "UPDATE usuarios SET user=@user,senha=@senha" +
                    ",nivel=@nivel WHERE idUsuario=@idUsuario";
            }

            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao);
                conexao.Open();
                var sqlCommand = new MySqlCommand(sql, conexao);
                sqlCommand.Parameters.AddWithValue("@idUsuario",idUsuario);
                sqlCommand.Parameters.AddWithValue("@user", user);
                sqlCommand.Parameters.AddWithValue("@senha", senha);
                sqlCommand.Parameters.AddWithValue("@nivel", nivel);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirUsuario(int? id)
        {
            string sql = "DELETE FROM usuarios WHERE idUsuario = @idUsuario";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    var sqlCommand = new MySqlCommand(sql, conexao);
                    sqlCommand.Parameters.AddWithValue("@idUsuario", id);
                    sqlCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //pega o usuario pelo id usado para excluir ou editar   
        public void GetUsuario(int? id)
        {
            string sql = "SELECT * FROM usuarios WHERE idUsuario = @idUsuario";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    var sqlCommand = new MySqlCommand(sql, conexao);
                    sqlCommand.Parameters.AddWithValue("@idUsuario", id);

                    var dr = sqlCommand.ExecuteReader();

                    if (dr.Read())
                    {
                        idUsuario = Convert.ToInt32(dr["idUsuario"]);
                        user = dr["user"].ToString();
                        senha = dr["senha"].ToString();
                        nivel = dr["nivel"].ToString();       
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
