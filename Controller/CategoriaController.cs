using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
           
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);
                

                //Comando SQL que será executado
                string sql = "INSERT INTO tbCategoria (categoria) VALUES (@categoria);";


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@categoria", categoria);
                


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
                MessageBox.Show($"Erro ao inserir categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          
        }

        public DataTable GetCategorias()
        {
            //Criando uma conexão vazia
            MySqlConnection conexao = null;

            try
            {
                // Inserindo a conexão usando a ConexaoDB que eu já havia criado
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Montei o SELECT que retorna todas as categorias
                //Alterar select para o usuario so conseguir ver suas categorias 
                string sql = @"SELECT cod_categoria AS 'Código', categoria AS 'Categoria'
                             FROM tbCategoria
                             WHERE usuario = User();";
                

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
                MessageBox.Show($"ERRO AO RECUPERAR CATEGORIAS: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool ExcluirCategoria(int categoria)
        {

            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Comando SQL que será executado
                string sql = "DELETE FROM tbCategoria WHERE cod_categoria = @cod_categoria;";


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@cod_categoria", categoria);

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
                MessageBox.Show($"Erro ao excluir a Categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        public bool AlterarCategoria(int codigo, string categoria)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Comando SQL que será executado
                string sql = "UPDATE tbcategoria SET categoria = @categoria WHERE cod_categoria = @cod_categoria;";


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@cod_categoria", codigo);
                comando.Parameters.AddWithValue("@categoria", categoria);
                

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
                MessageBox.Show($"Erro ao alterar a Categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
