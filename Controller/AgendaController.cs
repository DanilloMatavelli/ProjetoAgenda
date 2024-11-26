﻿using MySql.Data.MySqlClient;
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
    internal class AgendaController
    {
        public bool AddContato(int contato , int telefone, string categoria)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                // Comando SQL que será executado
                string sql = @"INSERT INTO tbContatos (contato, telefone, categoria)
                VALUES (@contato, @telefone, @categoria);";


                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocando o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
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

        public DataTable GetContatos()
        {
            //Criando uma conexão vazia
            MySqlConnection conexao = null;

            try
            {
                // Inserindo a conexão usando a ConexaoDB que eu já havia criado
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                string sql = @"SELECT cod_contato AS 'Código', 
                         contato AS 'contato', 
                         telefone AS 'telefone', 
                         categoria AS 'categoria'
                         FROM tbContatos;
                         WHERE usuario = USER();";
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

    }
}
