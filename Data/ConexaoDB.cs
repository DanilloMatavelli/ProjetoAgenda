using MySql.Data.MySqlClient;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    static internal class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            //string contendo as informações para conexão
            string stringconexao = "Server=localhost;Port=3307;Database=dbAgenda;User ID=root;Password=root;";

            //Criando a conexão
            MySqlConnection conexao = new MySqlConnection(stringconexao);

            return conexao;
        }

        static public MySqlConnection CriarConexao(string usuario, string senha)
        {
            //string contendo as informações para conexão
            string stringconexao = $"Server=localhost;Port=3307;Database=dbAgenda;User ID={usuario};Password={senha};";

            //Criando a conexão
            MySqlConnection conexao = new MySqlConnection(stringconexao);

            return conexao;

        }
    }
}
