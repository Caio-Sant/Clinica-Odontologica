using ODONTOLOGIA.DB.Usuário;
using ODONTOLOGIA.DB.Usuario;
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
    public partial class Cadastro_de_Usuario : Form
    {
        public Cadastro_de_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenu tela = new FrmMenu();
            tela.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                UsuarioDTO usuario = new UsuarioDTO();
                usuario.Cpf = maskedTextBox1.Text.Trim();
                usuario.Senha = txtSenha.Text.Trim();

                UsuarioBusiness business = new UsuarioBusiness();
                business.Salvar(usuario);

                MessageBox.Show("Usuario Salvo com sucesso.", "Dales Sorrisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dales Sorrisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "Dales Sorrisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
