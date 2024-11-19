namespace ProjetoAgenda
{
    partial class FrmTeste
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
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(12, 2);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 185);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 77);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 72);
            button1.TabIndex = 0;
            button1.Text = "btnTeste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(339, 333);
            button4.Name = "button4";
            button4.Size = new Size(188, 45);
            button4.TabIndex = 3;
            button4.Text = "Session";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(339, 417);
            button5.Name = "button5";
            button5.Size = new Size(188, 29);
            button5.TabIndex = 5;
            button5.Text = "Usuario";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(339, 174);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(188, 27);
            txtSenha.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(339, 122);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(188, 27);
            txtNome.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(558, 349);
            button6.Name = "button6";
            button6.Size = new Size(148, 29);
            button6.TabIndex = 9;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(558, 417);
            button7.Name = "button7";
            button7.Size = new Size(148, 29);
            button7.TabIndex = 10;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // FrmTeste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTeste";
            Text = "FrmTeste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox txtSenha;
        private TextBox txtNome;
        private Button button6;
        private Button button7;
    }
}