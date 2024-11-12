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

        private void AtualizaDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
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
                CategoriaController controleCategoria = new CategoriaController();
                DataTable tabela = controleCategoria.GetCategorias();
                dgvCategoria.DataSource = tabela;
            }

            else
            {
                MessageBox.Show("Não foi possivel cadastrar a categoria");
            }
        }


        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Data Grid View
            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);

            //Instanciando o objeto categoriaController
            CategoriaController controleUsuario = new CategoriaController();

            //Inserindo o usuário
            bool resultado = controleUsuario.ExcluirCategoria(codigo);

            if (resultado)
            {
                MessageBox.Show("Categoria excluida com sucesso");
                CategoriaController controleCategoria = new CategoriaController();
                DataTable tabela = controleCategoria.GetCategorias();
                dgvCategoria.DataSource = tabela;
            }

            else
            {
                MessageBox.Show("Não foi possivel excluir a categoria");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
