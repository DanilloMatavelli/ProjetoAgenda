namespace ProjetoAgenda.Views
{
    partial class FrmAgenda
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
            groupBox1 = new GroupBox();
            txtCategoria = new TextBox();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnCadastrarContato = new Button();
            label3 = new Label();
            txtTelefone = new TextBox();
            label2 = new Label();
            txtContato = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvAgenda = new DataGridView();
            button1 = new Button();
            btnSair = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnCadastrarContato);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agenda";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(15, 210);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(182, 23);
            txtCategoria.TabIndex = 9;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(15, 322);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(83, 32);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(114, 275);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(83, 32);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrarContato
            // 
            btnCadastrarContato.Location = new Point(15, 275);
            btnCadastrarContato.Name = "btnCadastrarContato";
            btnCadastrarContato.Size = new Size(83, 32);
            btnCadastrarContato.TabIndex = 1;
            btnCadastrarContato.Text = "Cadastrar";
            btnCadastrarContato.UseVisualStyleBackColor = true;
            btnCadastrarContato.Click += btnCadastrarContato_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 175);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Categoria";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(15, 125);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(182, 23);
            txtTelefone.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(15, 56);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(182, 23);
            txtContato.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Contato";
            // 
            // dgvAgenda
            // 
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(356, 27);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgenda.Size = new Size(384, 394);
            dgvAgenda.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(114, 322);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(83, 32);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 431);
            Controls.Add(button1);
            Controls.Add(dgvAgenda);
            Controls.Add(groupBox1);
            Name = "FrmAgenda";
            Text = "FrmAgenda";
            Load += FrmAgenda_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private TextBox txtContato;
        private TextBox txtTelefone;
        private Label label3;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnCadastrarContato;
        private DataGridView dgvAgenda;
        private TextBox txtCategoria;
        private Button btnSair;
        private Button button1;
    }
}