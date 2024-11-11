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
            btnMostraCategorias = new Button();
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
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = SystemColors.ButtonFace;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(247, 45);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(240, 150);
            dgvCategoria.TabIndex = 2;
            // 
            // btnMostraCategorias
            // 
            btnMostraCategorias.Location = new Point(330, 12);
            btnMostraCategorias.Name = "btnMostraCategorias";
            btnMostraCategorias.Size = new Size(123, 23);
            btnMostraCategorias.TabIndex = 3;
            btnMostraCategorias.Text = "Mostrar Categorias";
            btnMostraCategorias.UseVisualStyleBackColor = true;
            btnMostraCategorias.Click += btnMostraCategorias_Click;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(508, 219);
            Controls.Add(btnMostraCategorias);
            Controls.Add(dgvCategoria);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrarCategoria;
        private TextBox txtInsiraCategoria;
        private Button btnFechar;
        private DataGridView dgvCategoria;
        private Button btnMostraCategorias;
    }
}