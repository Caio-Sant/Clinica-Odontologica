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
    public partial class Procedimento : Form
    {
        public Procedimento()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMenu Menutela = new FrmMenu();
            Menutela.Show();
            Hide();
        }

    }
}
