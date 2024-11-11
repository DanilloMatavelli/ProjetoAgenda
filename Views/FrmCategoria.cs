using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class FrmCategoria : Form
    {
        private readonly int cod_categoria;
        private readonly string categoria;

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Formulario
            string categoria = txtInsiraCategoria.Text;

            //Instanciando o objeto categoriaController
            CategoriaController controleUsuario = new CategoriaController();

            //Inserindo o usuário
            bool resultado = controleUsuario.AddCategoria(categoria);

            if (resultado)
            {
                MessageBox.Show("Categoria cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar a categoria");
            }
        }

        private void btnMostraCategorias_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }
    }
}
