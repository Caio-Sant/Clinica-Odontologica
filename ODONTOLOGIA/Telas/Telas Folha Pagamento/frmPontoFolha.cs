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

namespace ODONTOLOGIA.Folha_de_pagamento
{
    public partial class Pontos_Folhas : Form
    {
        public Pontos_Folhas()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu tela = new FrmMenu();
            tela.Show();
            Hide();
        }
    }
}
