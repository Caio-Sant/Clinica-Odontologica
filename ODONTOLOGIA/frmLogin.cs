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

namespace ODONTOLOGIA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioBusiness business = new FuncionarioBusiness();
                FuncionarioDTO funcionario = business.Logar(textBox_usuario.Text, textBox1.Text);

                if (funcionario != null)
                {
                    UserSession.UsuarioLogado = funcionario;

                    trelasodo.FrmMenu menu = new trelasodo.FrmMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas.", "Dales Sorriso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dales Sorriso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "Dales Sorriso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}