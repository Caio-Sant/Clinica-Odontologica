namespace ODONTOLOGIA
{
    partial class frmLogin
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
            System.Windows.Forms.Button button3;
            this.lblfmrLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_usuario = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            this.lblfmrLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.White;
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F);
            button3.ForeColor = System.Drawing.Color.Black;
            button3.Location = new System.Drawing.Point(272, 274);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(94, 32);
            button3.TabIndex = 4;
            button3.Text = "OK ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblfmrLogin
            // 
            this.lblfmrLogin.BackColor = System.Drawing.Color.White;
            this.lblfmrLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblfmrLogin.Controls.Add(this.panel2);
            this.lblfmrLogin.Controls.Add(this.textBox1);
            this.lblfmrLogin.Controls.Add(this.textBox_usuario);
            this.lblfmrLogin.Controls.Add(this.button4);
            this.lblfmrLogin.Controls.Add(button3);
            this.lblfmrLogin.Controls.Add(this.label2);
            this.lblfmrLogin.Controls.Add(this.label1);
            this.lblfmrLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblfmrLogin.ForeColor = System.Drawing.Color.Transparent;
            this.lblfmrLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblfmrLogin.Location = new System.Drawing.Point(0, 0);
            this.lblfmrLogin.Name = "lblfmrLogin";
            this.lblfmrLogin.Size = new System.Drawing.Size(737, 411);
            this.lblfmrLogin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ODONTOLOGIA.Properties.Resources.page1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(258, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 190);
            this.panel2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 33;
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(272, 210);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(214, 20);
            this.textBox_usuario.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(381, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancelar ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(194, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SENHA ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(194, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 410);
            this.Controls.Add(this.lblfmrLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.lblfmrLogin.ResumeLayout(false);
            this.lblfmrLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblfmrLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox textBox_usuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}