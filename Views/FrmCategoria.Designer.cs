namespace ProjetoAgenda.Views
{
    partial class FrmCategoria
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
            btnCadastrarCategoria = new Button();
            txtInsiraCategoria = new TextBox();
            btnFechar = new Button();
            dgvCategoria = new DataGridView();
            btnExcluir = new Button();
            txtExcluirCategoria = new TextBox();
            button1 = new Button();
            btnAlterar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCadastrarCategoria);
            groupBox1.Controls.Add(txtInsiraCategoria);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da categoria";
            // 
            // btnCadastrarCategoria
            // 
            btnCadastrarCategoria.Location = new Point(6, 62);
            btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            btnCadastrarCategoria.Size = new Size(188, 32);
            btnCadastrarCategoria.TabIndex = 1;
            btnCadastrarCategoria.Text = "Cadastrar";
            btnCadastrarCategoria.UseVisualStyleBackColor = true;
            btnCadastrarCategoria.Click += btnCadastrarCategoria_Click;
            // 
            // txtInsiraCategoria
            // 
            txtInsiraCategoria.Location = new Point(6, 33);
            txtInsiraCategoria.Name = "txtInsiraCategoria";
            txtInsiraCategoria.Size = new Size(188, 23);
            txtInsiraCategoria.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.Location = new Point(12, 144);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(52, 23);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = SystemColors.ButtonFace;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(250, 29);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(240, 150);
            dgvCategoria.TabIndex = 2;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(250, 188);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 22);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtExcluirCategoria
            // 
            txtExcluirCategoria.Location = new Point(338, 190);
            txtExcluirCategoria.Margin = new Padding(3, 2, 3, 2);
            txtExcluirCategoria.Name = "txtExcluirCategoria";
            txtExcluirCategoria.Size = new Size(153, 23);
            txtExcluirCategoria.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(91, 144);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(121, 23);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(508, 219);
            Controls.Add(btnAlterar);
            Controls.Add(button1);
            Controls.Add(txtExcluirCategoria);
            Controls.Add(btnExcluir);
            Controls.Add(dgvCategoria);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrarCategoria;
        private TextBox txtInsiraCategoria;
        private Button btnFechar;
        private DataGridView dgvCategoria;
        private Button btnExcluir;
        private TextBox txtExcluirCategoria;
        private Button button1;
        private Button btnAlterar;
    }
}