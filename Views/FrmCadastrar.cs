using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void habilitarBotaoCadastrar()
        {
            // Se o usuário for diferente de vazio e e a quantidade de caracteres na senha for maior ou igual a 8, habilita o botão de login
            // Para verificar quantos caracteres tem no textBox
            if (txtNome.Text != "" && txtUsuario.Text != "" && txtSenha.Text.Length >= 8 && txtRepitaSenha.Text.Length >= 8 && txtSenha.Text.Length == txtRepitaSenha.Text.Length)
            {
                btnCadastrar.Enabled = true;
            }

            else
            {
                btnCadastrar.Enabled = false;
            }

            // OUTRO JEITO DE FAZER
            // private void habilitarBotaoCadastrar()
            //{
            //bool erro = false;

            //VERIFICA O NOME
            //if (txtNome.Text == "")
            //{
            //erro = true;
            //}

            //VERIFICA O USUÁRIO
            //if (txtUsuario.Text == "")
            //{
            //erro = true;
            //}

            //VERIFICA SENHA
            //if (txtSenha.Text.Length < 8)
            //{
            //erro = true;
            //}

            //VERIFICA REPETE SENHA
            // if (txtSenha.Text != txtRepitaSenha.Text)
            //{
            //erro = true;
            //}

            //CASO NÃO ENCONTRE NENHUM ERRO HABILITA O BOTÃO CADASTRAR
            //if (erro == false)
            //{
            //btnCadastrar.Enabled = true;
            //}

            //else
            //{
            //btnCadastrar.Enabled = false;
            //}
            //}


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtRepitaSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            MySqlConnection conexao = ConexaoDB.CriarConexao();

            //Abrindo Conexão
            conexao.Open();

            //Criando o comando SQL para inserir o usuário
            string sql = $"INSERT INTO tbUsuarios ( nome, usuario, senha) VALUES (@nome , @usuario , @senha)";

            //Criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);

            //Executando a instrução SQL no banco
            comando.ExecuteNonQuery();

            //Fechando a conexão com o banco
            conexao.Close();

            //Exibindo um MessageBox para o Usuario
            MessageBox.Show("Cadastro efetuado com sucesso! \n Você já pode realizar o login");

            //Para fechar a janela
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
