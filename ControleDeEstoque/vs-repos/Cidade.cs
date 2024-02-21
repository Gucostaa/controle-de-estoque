using ControleDeEstoque.Data;
using MySql.Data.MySqlClient;
using System.Data;

internal class Cidade
{
    public static DataTable GetCidades(string busca, string populacaoDe, string populacaoAte, string uf)
    {
        // Cria o complemento da consulta SQL
        string complemento = "";

        // Verifica se a população foi informada
        if (!string.IsNullOrEmpty(populacaoDe) && !string.IsNullOrEmpty(populacaoAte))
        {
            complemento += $" and (pop2021 between {populacaoDe} and {populacaoAte})";
        }

        if (!string.IsNullOrEmpty(uf))
        {
            complemento += $" and uf='{uf}'";
        }

        string sql = $"SELECT * FROM  cidades WHERE cidade like '%{busca}%' {complemento} ORDER BY cidade";

        //Uteis.msgInformacao(sql);

        // Cria o objeto que irá conter os dados
        DataTable dt = new DataTable();

        try
        {
            MySqlConnection conexao = new MySqlConnection(Conexao.stringConexao);
            conexao.Open();
            var sqlCommand = new MySqlCommand(sql, conexao);

            // Cria o objeto DataReader que executará o SQL no banco
            var dr = sqlCommand.ExecuteReader();

            // Atribui o DataReader ao DataTable
            dt.Load(dr);

            // Fecha a conexão
            dr.Close();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return dt;
    }
}
