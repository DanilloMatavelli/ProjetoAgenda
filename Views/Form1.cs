using ProjetoAgenda.Controller;
using ProjetoAgenda.Views;

namespace ProjetoAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            // Se o usuário for diferente de vazio e e a quantidade de caracteres na senha for maior ou igual a 8, habilita o botão de login
            // Para verificar quantos caracteres tem no textBox
            if (txtUsuario.Text != "" && txtSenha.Text.Length >= 8)
            {
                btnEntrar.Enabled = true;
            }

            //Para o botão desativar se tiver vazio
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar newForm = new FrmCadastrar();
            newForm.Show();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();


        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.ValidarLogin(txtUsuario.Text, txtSenha.Text);

            if (resultado==true)
            {
                FrmPrincipal newForm = new FrmPrincipal();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Erro ao verificar usuário.");
            }
        }
    }
}
