using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.ValidarLogin("DAN3465", "12121967");

            MessageBox.Show(resultado.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao("Dan2604", "12121967");
                conexao.Open();
                MessageBox.Show("Conexão deu certo!");

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao conectar: {erro.Message}");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProjetoAgenda.VariableGlobal.UserSession.usuario = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.senha);
            UserSession.senha = txtSenha.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.nome);
            UserSession.nome = txtNome.Text;
        }
    }
}

