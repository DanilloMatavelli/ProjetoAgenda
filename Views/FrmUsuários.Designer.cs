namespace ProjetoAgenda.Views
{
    partial class FrmUsuários
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
            dgvUsuarios = new DataGridView();
            ExcluirUsuario = new Button();
            groupBox1 = new GroupBox();
            btnAlterarSenha = new Button();
            txtAlteraSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Exclua o Usuário ";
            label1.Click += label1_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(21, 40);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(375, 188);
            dgvUsuarios.TabIndex = 1;
            // 
            // ExcluirUsuario
            // 
            ExcluirUsuario.Location = new Point(21, 234);
            ExcluirUsuario.Name = "ExcluirUsuario";
            ExcluirUsuario.Size = new Size(94, 31);
            ExcluirUsuario.TabIndex = 2;
            ExcluirUsuario.Text = "Excluir";
            ExcluirUsuario.UseVisualStyleBackColor = true;
            ExcluirUsuario.Click += ExcluirUsuario_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAlterarSenha);
            groupBox1.Controls.Add(txtAlteraSenha);
            groupBox1.Location = new Point(402, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 113);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "AlterarSenha";
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Location = new Point(6, 59);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(279, 29);
            btnAlterarSenha.TabIndex = 5;
            btnAlterarSenha.Text = "Alterar Senha";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // txtAlteraSenha
            // 
            txtAlteraSenha.Location = new Point(6, 26);
            txtAlteraSenha.Name = "txtAlteraSenha";
            txtAlteraSenha.Size = new Size(279, 27);
            txtAlteraSenha.TabIndex = 4;
            // 
            // FrmUsuários
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 303);
            Controls.Add(groupBox1);
            Controls.Add(ExcluirUsuario);
            Controls.Add(dgvUsuarios);
            Controls.Add(label1);
            Name = "FrmUsuários";
            Text = "FrmUsuários";
            Load += FrmUsuários_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUsuarios;
        private Button ExcluirUsuario;
        private GroupBox groupBox1;
        private Button btnAlterarSenha;
        private TextBox txtAlteraSenha;
    }
}