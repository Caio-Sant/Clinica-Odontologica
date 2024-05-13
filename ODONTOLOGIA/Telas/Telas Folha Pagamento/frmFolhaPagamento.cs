using ODONTOLOGIA.DB.Funcionario;
using ODONTOLOGIA.Folha_de_Pagamento;
using ODONTOLOGIA.Telas.Telas_Folha_Pagamento;
using ODONTOLOGIA.trelasodo;
using System;
using System.Windows.Forms;

namespace ODONTOLOGIA.Folha_de_pagamento
{
    public partial class Folha_De_Pagamento : Form
    {
        public Folha_De_Pagamento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenu tela = new FrmMenu();
            tela.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO cat = cboFuncionario.SelectedItem as FuncionarioDTO;
                FuncionarioDTO forn = cboSalarioBse.SelectedItem as FuncionarioDTO;

                FolhaDePagamentoDTO dto = new FolhaDePagamentoDTO();

                dto.ValorTotal = Convert.ToDouble(lblTotal.Text);
                dto.ValeTransporte = Convert.ToDouble(lblVale.Text);
                dto.SalarioFamilia = Convert.ToDouble(lblSalarioFamilia.Text);
                dto.id_Funcionario = cat.Id;
                dto.DataPagamento = dtpPga.Value;
                dto.INSS = Convert.ToDouble(lblInss.Text);
                dto.HoraExtra = Convert.ToDouble(lblHoraExtra.Text);
                dto.Faltas = Convert.ToDouble(lblFaltas.Text);
                dto.DSR = Convert.ToDouble(lblDSR.Text);
                dto.Diastrabalhados = Convert.ToDouble(txtQuant.Text);
                dto.Atrasos = Convert.ToDouble(lblAtrasos.Text);


                FolhaDePagamentoBussenis business = new FolhaDePagamentoBussenis();
                business.Salvar(dto);

                MessageBox.Show("Folha salva com sucesso.", "Dales Sorrisos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro tente novamente mais tarde");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // CONVERSAO //
            try
            {

                double SalarioBase = Convert.ToDouble(cboSalarioBse.Text);
                double SalarioHora = Convert.ToDouble(lblSalarioHora.Text);
                double NudH = Convert.ToDouble(nudFilhos.Text);

                double SalarioFamilia = Convert.ToDouble(lblSalarioFamilia.Text);
                double Atrasos = Convert.ToDouble(nudAtrasos.Value);
                double Faltas = Convert.ToDouble(nudFaltas.Value);
                double Adicional = Convert.ToDouble(txtAdic.Text);
                double DiasT = Convert.ToDouble(txtQuant.Text);
                double HorasExtras = Convert.ToDouble(lblHoraExtra.Text);
                double Quantidade = Convert.ToDouble(txtQuant.Text);
                double AtrasosR = Convert.ToDouble(lblAtrasos.Text);
                double Faltas1 = Convert.ToDouble(lblFaltas.Text);
                double dsr1 = Convert.ToDouble(lblDSR.Text);
                double FaltaFGTS = Convert.ToDouble(txtFaltaFGTS.Text);

                Calcular a = new Calcular();

                double SH = a.CalcularSH(SalarioBase);
                lblSalarioHora.Text = SH.ToString();

                double hhh = a.CalcularHE(SH, Adicional, Quantidade);
                lblHoraExtra.Text = hhh.ToString();



                double dsr = a.CalcularDsr(DiasT, FaltaFGTS, hhh);
                lblDSR.Text = dsr.ToString();



                double Atrasos5 = a.CalcularAtrasos(SH, Quantidade);
                lblAtrasos.Text = Atrasos5.ToString();


                double Falt = a.CalcularFaltas(SalarioBase, Faltas, FaltaFGTS);
                lblFaltas.Text = Falt.ToString();



                double Inss = a.CalcularINSS(SalarioBase, hhh, dsr1, Falt, Atrasos5);
                lblInss.Text = Inss.ToString();

                double Vale = a.CalcularVT(SalarioBase);
                lblVale.Text = Vale.ToString();

                double sf = a.CalcularSF(SalarioBase, NudH);
                lblSalarioFamilia.Text = sf.ToString();

                double conta = a.CalcularTotal(SalarioBase, hhh, dsr, Falt, Atrasos5, Inss, Vale, sf);
                lblTotal.Text = conta.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro tente novamente mais tarde");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pontos_Folhas newForm2 = new Pontos_Folhas();
            this.Hide();
            newForm2.ShowDialog();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            FrmMenu newForm2 = new FrmMenu();
            this.Hide();
            newForm2.ShowDialog();
        }
    }
}
