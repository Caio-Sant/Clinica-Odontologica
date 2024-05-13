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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(5000);
                Invoke(new Action(() =>
                {
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    Hide();
                }));
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                timer1.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
