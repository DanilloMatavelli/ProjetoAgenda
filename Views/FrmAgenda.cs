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
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvAgenda.DataSource = tabela;
        }

        private void btnCadastrarContato_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Formulario
            string contato = txtContato.Text;
            int telefone = Convert.ToInt32(txtTelefone.Text);
            string categoria = txtCategoria.Text;

            //Instanciando o objeto categoriaController
            AgendaController controleUsuario = new AgendaController();

            //Inserindo o usuário
            bool resultado = controleUsuario.AddContato(contato, telefone, categoria);

            if (resultado)
            {
                MessageBox.Show("Contato cadastrado com sucesso.");
                CategoriaController controleCategoria = new CategoriaController();
                DataTable tabela = controleCategoria.GetCategorias();
                dgvAgenda.DataSource = tabela;
            }

            else
            {
                MessageBox.Show("Não foi possível cadastrar o contato");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Data Grid View
            int codigo = Convert.ToInt32(dgvAgenda.SelectedRows[0].Cells[0].Value);

            //Instanciando o objeto AgendaController
            AgendaController controleUsuario = new AgendaController();

            //Excluindo o contato, está com problema
            bool resultado = controleUsuario.ExcluirContato(contato);

            if (resultado)
            {
                MessageBox.Show("Contato excluído com sucesso.");
                CategoriaController controleCategoria = new CategoriaController();
                DataTable tabela = controleCategoria.GetCategorias();
                dgvAgenda.DataSource = tabela;
            }

            else
            {
                MessageBox.Show("Não foi possível excluir o contato.");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Data Grid View
            int codigo = Convert.ToInt32(dgvAgenda.SelectedRows[0].Cells[0].Value);

            //Instanciando o objeto AgendaController
            AgendaController controleUsuario = new AgendaController();

            //Inserindo o contato, está com problema
            bool resultado = controleUsuario.AlterarContato(contato);

            if (resultado)
            {
                MessageBox.Show("Categoria excluida com sucesso");
                CategoriaController controleCategoria = new CategoriaController();
                DataTable tabela = controleCategoria.GetCategorias();
                dgvAgenda.DataSource = tabela;
            }

            else
            {
                MessageBox.Show("Não foi possivel alterar o Contato");
            }
        }
    }
}
