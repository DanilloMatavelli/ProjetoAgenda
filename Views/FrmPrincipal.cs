﻿using ProjetoAgenda.VariableGlobal;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)

        {

            FrmCategoria newForm = new FrmCategoria();
            newForm.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmUsuários newForm = new FrmUsuários();
            newForm.Show();
        }

        private void lblSejaBemVindo_Click(object sender, EventArgs e)
        {
            lblSejaBemVindo.Text = $"Olá, {UserSession.usuario}, seja bem-vindo";

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblSejaBemVindo.Text = $"Olá, {UserSession.usuario}, seja bem-vindo";
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda newForm = new FrmAgenda();
            newForm.Show();
        }
    }
}
