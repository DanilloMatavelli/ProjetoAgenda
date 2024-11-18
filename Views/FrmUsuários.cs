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
    public partial class FrmUsuários : Form
    {
        public FrmUsuários()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuários_Load(object sender, EventArgs e)
        {
            UsuarioController controleCategoria = new UsuarioController();
            DataTable tabela = controleCategoria.GetUsuario();
            dgvUsuarios.DataSource = tabela;
        }

        private void ExcluirUsuario_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Data Grid View
            string usuario = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();

            //Instanciando o objeto categoriaController
            UsuarioController controleUsuario = new UsuarioController();

            //Inserindo o usuário
            bool resultado = controleUsuario.ExcluirUsuario(usuario);

            if (resultado)
            {
                MessageBox.Show("Usuário excluido com sucesso");
                UsuarioController controleCategoria = new UsuarioController();
                DataTable tabela = controleCategoria.GetUsuario();
                dgvUsuarios.DataSource = tabela;
            }

            else
            {
                MessageBox.Show("Não foi possivel excluir o Usuario");
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            //Pegando os dados do Data Grid View
            string senha = txtAlteraSenha.Text;
            string usuario = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();

            //Instanciando o objeto categoriaController
            UsuarioController controleUsuario = new UsuarioController();

            //Inserindo o usuário
            bool resultado = controleUsuario.AlteraSenha(senha,usuario);

            if (resultado)
            {
                MessageBox.Show("Senha alterada com sucesso");
                UsuarioController controleCategoria = new UsuarioController();
                DataTable tabela = controleCategoria.GetUsuario();
                dgvUsuarios.DataSource = tabela;
            }

            else
            {
                MessageBox.Show("Não foi possivel Alterar a Senha");
            }
        }
    }
}

