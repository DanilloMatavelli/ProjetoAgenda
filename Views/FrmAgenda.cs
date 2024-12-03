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


        private void AtualizaDataGrid()
        {
            AgendaController controleCategoria = new AgendaController();
            DataTable tabela = controleCategoria.GetContatos();
            dgvAgenda.DataSource = tabela;
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void btnCadastrarContato_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Formulario
            string contato = txtContato.Text;
            string telefone = Convert.ToString(txtTelefone.Text);
            string categoria = txtCategoria.Text;

            //Instanciando o objeto categoriaController
            AgendaController controleUsuario = new AgendaController();

            //Inserindo o usuário
            bool resultado = controleUsuario.AddContato(contato, telefone, categoria);

            if (resultado)
            {
                AtualizaDataGrid();
            }

            else
            {
                MessageBox.Show("Não foi possível cadastrar o contato");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Data Grid View
            int cod_contato = Convert.ToInt32(dgvAgenda.SelectedRows[0].Cells[0].Value);

            //Instanciando o objeto AgendaController
            AgendaController controleUsuario = new AgendaController();

            //Excluindo o contato, está com problema
            bool resultado = controleUsuario.ExcluirContato(cod_contato);

            if (resultado)
            {
                AtualizaDataGrid();
            }

            else
            {
                MessageBox.Show("Não foi possível excluir o contato.");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Data Grid View
            int cod_contato = Convert.ToInt32(dgvAgenda.SelectedRows[0].Cells[0].Value);
            string contato = txtContato.Text;
            string telefone = Convert.ToString(txtTelefone.Text);
            string categoria = txtCategoria.Text;

            //Instanciando o objeto AgendaController
            AgendaController controleUsuario = new AgendaController();

            //Inserindo o contato, está com problema
            bool resultado = controleUsuario.AlterarContato(cod_contato, contato, telefone, categoria);

            if (resultado)
            {
                AtualizaDataGrid();
            }

            else
            {
                MessageBox.Show("Não foi possivel alterar o Contato");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
