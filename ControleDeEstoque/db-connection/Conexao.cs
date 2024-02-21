using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Data
{
    static class Conexao
    {
        const string servidor = "localhost";
        const string banco = "controleestoque";
        const string usuario = "root";
        const string senha = "";

        public static string stringConexao = $"Server={servidor};Database={banco};User id={usuario};Password={senha}";
    }
}
