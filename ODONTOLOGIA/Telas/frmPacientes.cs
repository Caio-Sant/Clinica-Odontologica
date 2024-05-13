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
    public partial class pacientes : Form
    {
        public pacientes()
        {
            InitializeComponent();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            FrmMenu Menutela = new FrmMenu();
            Menutela.Show();
            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu tela = new FrmMenu();
            tela.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
