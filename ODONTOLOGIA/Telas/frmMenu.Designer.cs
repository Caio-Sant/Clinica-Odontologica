namespace ODONTOLOGIA.trelasodo
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrodeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontosDeFolhasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendenteToolStripMenuItem,
            this.cadastrodeUsuarioToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.pontosDeFolhasToolStripMenuItem1,
            this.rHToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atendenteToolStripMenuItem
            // 
            this.atendenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.procedimentosToolStripMenuItem});
            this.atendenteToolStripMenuItem.Name = "atendenteToolStripMenuItem";
            this.atendenteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.atendenteToolStripMenuItem.Text = "Atendente";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // procedimentosToolStripMenuItem
            // 
            this.procedimentosToolStripMenuItem.Name = "procedimentosToolStripMenuItem";
            this.procedimentosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.procedimentosToolStripMenuItem.Text = "Procedimentos";
            this.procedimentosToolStripMenuItem.Click += new System.EventHandler(this.procedimentosToolStripMenuItem_Click);
            // 
            // cadastrodeUsuarioToolStripMenuItem
            // 
            this.cadastrodeUsuarioToolStripMenuItem.Name = "cadastrodeUsuarioToolStripMenuItem";
            this.cadastrodeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.cadastrodeUsuarioToolStripMenuItem.Text = "Cadastro de Usuario";
            this.cadastrodeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrodeUsuarioToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // pontosDeFolhasToolStripMenuItem1
            // 
            this.pontosDeFolhasToolStripMenuItem1.Name = "pontosDeFolhasToolStripMenuItem1";
            this.pontosDeFolhasToolStripMenuItem1.Size = new System.Drawing.Size(112, 20);
            this.pontosDeFolhasToolStripMenuItem1.Text = "Pontos de Folhas ";
            this.pontosDeFolhasToolStripMenuItem1.Click += new System.EventHandler(this.pontosDeFolhasToolStripMenuItem1_Click);
            // 
            // rHToolStripMenuItem
            // 
            this.rHToolStripMenuItem.Name = "rHToolStripMenuItem";
            this.rHToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.rHToolStripMenuItem.Text = "RH";
            this.rHToolStripMenuItem.Click += new System.EventHandler(this.rHToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ODONTOLOGIA.Properties.Resources.Odontologia_minimamente_invasiva_727x409;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 404);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dales Sorrisos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontosDeFolhasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrodeUsuarioToolStripMenuItem;
    }
}