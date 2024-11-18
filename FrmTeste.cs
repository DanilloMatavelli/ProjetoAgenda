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
                    MessageBox.Show($"Erro ao conectar {erro.Message}");
                }

            }
        }
    }

