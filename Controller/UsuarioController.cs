using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {

        public bool AddUsuario(string nome, string usuario, string senha)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = $"INSERT INTO tbUsuarios (nome,usuario,senha) VALUES (@nome, @usuario, @senha)";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);


                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                //Executando no banco de dados
                int LinhasAfetadas = comando.ExecuteNonQuery();

                //Fecha a conexão com o banco
                conexao.Close();

                if (LinhasAfetadas > 0)
                {
                    string sql2 = $@"CREATE USER '{@usuario}'@'%' IDENTIFIED BY '{@senha}';
                    GRANT ALL PRIVILEGES ON dbagenda.* TO { usuario}'@'%';";
                    comando = new MySqlCommand(sql2, conexao);
                    return true;
                }
                else
                { 
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar: {erro.Message}","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool ValidarLogin(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                String sql = @"select * from tbUsuarios
                where usuario=@usuario 
                and binary senha=@senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Clone();
                    return true;
                }
                else
                {
                    conexao.Clone();
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao verificar usuário.");
                return false;
            }
           
        }
        public DataTable GetUsuario()
        {
            //Criando uma conexão vazia
            MySqlConnection conexao = null;

            try
            {
                // Inserindo a conexão usando a ConexaoDB que eu já havia criado
                conexao = ConexaoDB.CriarConexao();

                //Montei o SELECT que retorna todas as categorias
                string sql = @"select nome, usuario, senha 
                             from tbUsuarios;";

                //Abri Conexão
                conexao.Open();

                //Criei um adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criei uma tabela vazia
                DataTable tabela = new DataTable();

                //Pedindo para o adaptador prencher a tabela
                adaptador.Fill(tabela);

                //Retorna a tabela preenchida
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO EXCLUIR USUARIO: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool ExcluirUsuario(string usuario)
        {

            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "DELETE FROM tbUsuarios WHERE usuario = usuario;";


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("usuario", usuario);

                //Executando no banco de dados
                int LinhasAfetadas = comando.ExecuteNonQuery();

                //Fecha a conexão com o banco
                conexao.Close();

                if (LinhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir O Usuario: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        public bool AlteraSenha(string Senha, string usuario)
        {

            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "UPDATE tbusuarios SET Senha = @Senha WHERE usuario = @usuario;";
                


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@Senha", Senha);
                comando.Parameters.AddWithValue("@usuario", usuario);




                //Executando no banco de dados
                int LinhasAfetadas = comando.ExecuteNonQuery();

                //Fecha a conexão com o banco
                conexao.Close();

                if (LinhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao alterar a Senha: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
    }
}
