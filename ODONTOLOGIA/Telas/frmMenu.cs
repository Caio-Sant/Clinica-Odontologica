using ODONTOLOGIA.Folha_de_pagamento;
using ODONTOLOGIA.RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODONTOLOGIA.trelasodo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            VerificarPermissoes();
        }

        void VerificarPermissoes()
        {
            if (UserSession.UsuarioLogado.PermissaoAdm == false)
            {
                if (UserSession.UsuarioLogado.PermissaoAdm == false)
                {
                    administradorToolStripMenuItem.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermissaoAdm == false)
                {
                    pontosDeFolhasToolStripMenuItem1.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermissaoAdm == false)
                {
                    rHToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pacientes pacientetela = new pacientes();
            pacientetela.Show();
            this.Hide();
        }

        private void procedimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procedimento procedimentotela = new Procedimento();
            procedimentotela.Show();
            this.Hide();
        }



        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcionario funcionariotela = new funcionario();
            funcionariotela.Show();
            this.Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Folha_De_Pagamento Folha_De_Pagamentotela = new Folha_De_Pagamento();
            Folha_De_Pagamentotela.Show();
            this.Hide();
        }

        private void pontosDeFolhasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pontos_Folhas Pontos_Folhastela = new Pontos_Folhas();
            Pontos_Folhastela.Show();
            this.Hide();
        }

        private void rHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrRh FmrRhtela = new FmrRh();
            FmrRhtela.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            Hide();
        }

        private void cadastrodeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Usuario Cadastro_de_Usuariotela = new Cadastro_de_Usuario();
            Cadastro_de_Usuariotela.Show();
            this.Hide();
        }

    }
}
