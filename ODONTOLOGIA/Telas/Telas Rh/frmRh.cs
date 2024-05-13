using ODONTOLOGIA.Folha_de_pagamento;
using ODONTOLOGIA.trelasodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODONTOLOGIA.RH
{
    public partial class FmrRh : Form
    {
        public FmrRh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Folha_de_Ponto newForm2 = new Folha_de_Ponto();
            this.Hide();
            newForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Folha_De_Pagamento newForm2 = new Folha_De_Pagamento();

            this.Hide();
            newForm2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            funcionario newForm2 = new funcionario();
            this.Hide();
            newForm2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Consultar_Funcionario verfuncio = new Consultar_Funcionario();
            verfuncio.ShowDialog();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMenu tela = new FrmMenu();
            tela.Show();
            Hide();
        }
    }
}
