namespace CaixaEletronico
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnEntrar = new Button();
            labelSenha = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            labelUsuario = new Label();
            panel1 = new Panel();
            MinimizarLogin = new Button();
            labelTelaLogin = new Label();
            FecharLogin = new Button();
            panel2 = new Panel();
            LinkCriarConta = new LinkLabel();
            labelLogin = new Label();
            pictureBoxSenha = new PictureBox();
            pictureBoxUsuario = new PictureBox();
            LinkEsqueceuSenha = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderColor = Color.White;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(228, 267);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(147, 41);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += Entrar_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.ForeColor = Color.White;
            labelSenha.Location = new Point(184, 163);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 19);
            labelSenha.TabIndex = 3;
            labelSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(64, 64, 64);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(184, 192);
            txtSenha.MaxLength = 12;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Insira sua senha.";
            txtSenha.Size = new Size(252, 19);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(64, 64, 64);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(184, 131);
            txtLogin.MaxLength = 50;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe seu nome.";
            txtLogin.Size = new Size(252, 19);
            txtLogin.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(184, 102);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 19);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuário:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(MinimizarLogin);
            panel1.Controls.Add(labelTelaLogin);
            panel1.Controls.Add(FecharLogin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 30);
            panel1.TabIndex = 1;
            // 
            // MinimizarLogin
            // 
            MinimizarLogin.BackgroundImage = (Image)resources.GetObject("MinimizarLogin.BackgroundImage");
            MinimizarLogin.BackgroundImageLayout = ImageLayout.Zoom;
            MinimizarLogin.Dock = DockStyle.Right;
            MinimizarLogin.FlatAppearance.BorderSize = 0;
            MinimizarLogin.FlatStyle = FlatStyle.Flat;
            MinimizarLogin.Location = new Point(530, 0);
            MinimizarLogin.Name = "MinimizarLogin";
            MinimizarLogin.Size = new Size(35, 30);
            MinimizarLogin.TabIndex = 3;
            MinimizarLogin.UseVisualStyleBackColor = true;
            MinimizarLogin.Click += MinimizarLogin_Click;
            // 
            // labelTelaLogin
            // 
            labelTelaLogin.AutoSize = true;
            labelTelaLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelaLogin.ForeColor = SystemColors.HighlightText;
            labelTelaLogin.Location = new Point(3, 5);
            labelTelaLogin.Name = "labelTelaLogin";
            labelTelaLogin.Size = new Size(141, 19);
            labelTelaLogin.TabIndex = 2;
            labelTelaLogin.Text = "Caixa Eletrônico JP";
            // 
            // FecharLogin
            // 
            FecharLogin.BackgroundImage = (Image)resources.GetObject("FecharLogin.BackgroundImage");
            FecharLogin.BackgroundImageLayout = ImageLayout.Zoom;
            FecharLogin.Dock = DockStyle.Right;
            FecharLogin.FlatAppearance.BorderSize = 0;
            FecharLogin.FlatStyle = FlatStyle.Flat;
            FecharLogin.Location = new Point(565, 0);
            FecharLogin.Name = "FecharLogin";
            FecharLogin.Size = new Size(35, 30);
            FecharLogin.TabIndex = 0;
            FecharLogin.UseVisualStyleBackColor = true;
            FecharLogin.Click += FecharLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(labelUsuario);
            panel2.Controls.Add(LinkCriarConta);
            panel2.Controls.Add(labelLogin);
            panel2.Controls.Add(pictureBoxSenha);
            panel2.Controls.Add(pictureBoxUsuario);
            panel2.Controls.Add(LinkEsqueceuSenha);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(labelSenha);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 420);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint_1;
            // 
            // LinkCriarConta
            // 
            LinkCriarConta.AutoSize = true;
            LinkCriarConta.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LinkCriarConta.LinkColor = Color.White;
            LinkCriarConta.Location = new Point(270, 317);
            LinkCriarConta.Name = "LinkCriarConta";
            LinkCriarConta.Size = new Size(63, 15);
            LinkCriarConta.TabIndex = 11;
            LinkCriarConta.TabStop = true;
            LinkCriarConta.Text = "Criar Conta";
            LinkCriarConta.LinkClicked += LinkCriarConta_LinkClicked;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(273, 58);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(61, 19);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "LOGIN";
            // 
            // pictureBoxSenha
            // 
            pictureBoxSenha.Image = (Image)resources.GetObject("pictureBoxSenha.Image");
            pictureBoxSenha.Location = new Point(152, 185);
            pictureBoxSenha.Name = "pictureBoxSenha";
            pictureBoxSenha.Size = new Size(26, 26);
            pictureBoxSenha.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSenha.TabIndex = 9;
            pictureBoxSenha.TabStop = false;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Image = (Image)resources.GetObject("pictureBoxUsuario.Image");
            pictureBoxUsuario.Location = new Point(152, 124);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(26, 26);
            pictureBoxUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUsuario.TabIndex = 8;
            pictureBoxUsuario.TabStop = false;
            // 
            // LinkEsqueceuSenha
            // 
            LinkEsqueceuSenha.AutoSize = true;
            LinkEsqueceuSenha.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LinkEsqueceuSenha.LinkColor = Color.White;
            LinkEsqueceuSenha.Location = new Point(338, 217);
            LinkEsqueceuSenha.Name = "LinkEsqueceuSenha";
            LinkEsqueceuSenha.Size = new Size(95, 15);
            LinkEsqueceuSenha.TabIndex = 6;
            LinkEsqueceuSenha.TabStop = true;
            LinkEsqueceuSenha.Text = "Esqueceu a senha?";
            LinkEsqueceuSenha.LinkClicked += LinkEsqueceuSenha_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(600, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixa Eletrônico";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEntrar;
        private Label labelSenha;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label labelUsuario;
        private Panel panel1;
        private Button FecharLogin;
        private Label labelTelaLogin;
        private Panel panel2;
        private LinkLabel LinkEsqueceuSenha;
        private LinkLabel LinkCadastro;
        private PictureBox pictureBoxSenha;
        private PictureBox pictureBoxUsuario;
        private Label labelLogin;
        private LinkLabel LinkCriarConta;
        private Button MinimizarLogin;
    }
}
