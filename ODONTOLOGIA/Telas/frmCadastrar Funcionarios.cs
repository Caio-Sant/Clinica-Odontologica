using ODONTOLOGIA.DB.Funcionario;
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
    public partial class funcionario : Form
    {
        public funcionario()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMenu Menutela = new FrmMenu();
            Menutela.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Nome = txtNome.Text.Trim();
                dto.Cpf = txtCPF.Text.Trim();
                dto.NumeroCasa = txtNumero.Text.Trim();
                dto.Telefone = txtTelefone.Text.Trim();
                dto.Cep = txtCEP.Text.Trim();
                dto.Nascimento = dtpNasc.Value.Date;
                dto.Sexo = cboSexo.Text;
                dto.Email = txtEmail.Text.Trim();
                dto.Cargo = txtCargo.Text.Trim();
                dto.Admissao = dtpAdmissao.Value.Date;
                dto.Salario = Convert.ToDecimal(txtSalario.Text);
                dto.Rg = txtRG.Text.Trim();


                FuncionarioBusiness business = new FuncionarioBusiness();
                business.Salvar(dto);

                MessageBox.Show("Cliente Salvo com sucesso.", "Dales Sorrisos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    catch (ArgumentException ex)
            //    {
            //        MessageBox.Show(ex.Message, "Dales Sorrisos",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Ocorreru um erro, tente mais tarde.", "Dales Sorrisos",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu tela = new FrmMenu();
            tela.Show();
            Hide();
        }
    }
}
