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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCadastrarCategoria);
            groupBox1.Controls.Add(txtInsiraCategoria);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 39);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da categoria";
            // 
            // btnCadastrarCategoria
            // 
            btnCadastrarCategoria.Location = new Point(7, 83);
            btnCadastrarCategoria.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            btnCadastrarCategoria.Size = new Size(215, 43);
            btnCadastrarCategoria.TabIndex = 1;
            btnCadastrarCategoria.Text = "Cadastrar";
            btnCadastrarCategoria.UseVisualStyleBackColor = true;
            btnCadastrarCategoria.Click += btnCadastrarCategoria_Click;
            // 
            // txtInsiraCategoria
            // 
            txtInsiraCategoria.Location = new Point(7, 44);
            txtInsiraCategoria.Margin = new Padding(3, 4, 3, 4);
            txtInsiraCategoria.Name = "txtInsiraCategoria";
            txtInsiraCategoria.Size = new Size(214, 27);
            txtInsiraCategoria.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.Location = new Point(14, 192);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(59, 31);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = SystemColors.ButtonFace;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(286, 39);
            dgvCategoria.Margin = new Padding(3, 4, 3, 4);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(274, 200);
            dgvCategoria.TabIndex = 2;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(286, 251);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtExcluirCategoria
            // 
            txtExcluirCategoria.Location = new Point(386, 253);
            txtExcluirCategoria.Name = "txtExcluirCategoria";
            txtExcluirCategoria.Size = new Size(174, 27);
            txtExcluirCategoria.TabIndex = 4;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(581, 292);
            Controls.Add(txtExcluirCategoria);
            Controls.Add(btnExcluir);
            Controls.Add(dgvCategoria);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}