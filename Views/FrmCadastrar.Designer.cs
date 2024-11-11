namespace ProjetoAgenda
{
    partial class FrmCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            txtRepitaSenha = new TextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "USUÁRIO";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Repita a Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 166);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(180, 23);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 96);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 23);
            txtUsuario.TabIndex = 7;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtRepitaSenha
            // 
            txtRepitaSenha.Location = new Point(12, 230);
            txtRepitaSenha.Name = "txtRepitaSenha";
            txtRepitaSenha.PasswordChar = '*';
            txtRepitaSenha.Size = new Size(180, 23);
            txtRepitaSenha.TabIndex = 8;
            txtRepitaSenha.TextChanged += txtRepitaSenha_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(105, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Enabled = false;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(12, 268);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(87, 23);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 12;
            label3.Text = "Senha";
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(399, 314);
            Controls.Add(label3);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtRepitaSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCadastrar";
            Text = "FrmCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private TextBox txtRepitaSenha;
        private Button btnCancelar;
        private Button btnCadastrar;
        private Label label3;
    }
}