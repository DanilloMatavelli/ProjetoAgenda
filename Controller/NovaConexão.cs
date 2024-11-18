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

namespace ProjetoAgenda.Controller
{
    public partial class NovaConexão : Form
    {
        public NovaConexão()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao("Dan2604", "121219767");
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
