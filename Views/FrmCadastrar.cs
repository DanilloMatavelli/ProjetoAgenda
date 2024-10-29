using MySql.Data.MySqlClient;
using ProjetoAgenda.Controller;
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
            //Pegando os dados do Formulario
            string nome = txtNome.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            //Instanciando o objeto UsuarioController
            UsuarioController controleUsuario = new UsuarioController();

            //Inserindo o usuário
            bool resultado = controleUsuario.AddUsuario(nome, usuario, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o usuário");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
