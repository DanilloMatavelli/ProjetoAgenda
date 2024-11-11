namespace ProjetoAgenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            btnCadastrar = new Button();
            btnEntrar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(28, 130);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(183, 23);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(28, 68);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(183, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(120, 172);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(91, 32);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Enabled = false;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(28, 172);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(91, 32);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 9);
            label3.Name = "label3";
            label3.Size = new Size(183, 23);
            label3.TabIndex = 6;
            label3.Text = "LOGIN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(415, 227);
            Controls.Add(label3);
            Controls.Add(btnEntrar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnCadastrar;
        private Button btnEntrar;
        private Label label3;
    }
}
