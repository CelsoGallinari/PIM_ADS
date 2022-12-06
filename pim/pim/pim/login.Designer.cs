namespace pim
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.osicon = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Snow;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.osicon);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.picSenha);
            this.pnlLogin.Controls.Add(this.picLogin);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Location = new System.Drawing.Point(224, 45);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(332, 340);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(37, 278);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // osicon
            // 
            this.osicon.BackColor = System.Drawing.Color.Transparent;
            this.osicon.Image = global::pim.Properties.Resources.os_icon;
            this.osicon.Location = new System.Drawing.Point(121, 17);
            this.osicon.Name = "osicon";
            this.osicon.Size = new System.Drawing.Size(86, 78);
            this.osicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.osicon.TabIndex = 6;
            this.osicon.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(34, 188);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(34, 127);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // picSenha
            // 
            this.picSenha.BackColor = System.Drawing.Color.Transparent;
            this.picSenha.Image = global::pim.Properties.Resources.password;
            this.picSenha.Location = new System.Drawing.Point(34, 207);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(19, 19);
            this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSenha.TabIndex = 3;
            this.picSenha.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.Image = global::pim.Properties.Resources.login;
            this.picLogin.Location = new System.Drawing.Point(34, 146);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(19, 20);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 2;
            this.picLogin.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(59, 206);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(236, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(59, 143);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(236, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.Text = "login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmLogin_Resize);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox osicon;
        private System.Windows.Forms.Button btnLogin;
    }
}

