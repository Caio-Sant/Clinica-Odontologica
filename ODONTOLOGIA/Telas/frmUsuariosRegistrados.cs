﻿using System;
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
    public partial class Lista_de_Usuarios_Registrado : Form
    {
        public Lista_de_Usuarios_Registrado()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenu Menutela = new FrmMenu();
            Menutela.Show();
            Hide();
        }
    }
}
