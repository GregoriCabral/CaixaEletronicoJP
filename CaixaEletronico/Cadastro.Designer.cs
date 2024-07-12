namespace CaixaEletronico
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            btnSalvarCadastro = new Button();
            labelEmailCadastrar = new Label();
            labelSenhaCadastar = new Label();
            labelNomeCadastar = new Label();
            txtEmailCadastro = new TextBox();
            txtSenhaCadastro = new TextBox();
            txtNomeCadastro = new TextBox();
            PainelCadastro = new Panel();
            MinimizarCadastro = new Button();
            FecharCadastro = new Button();
            labelTelaCadastrar = new Label();
            panel1 = new Panel();
            PainelCadastro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvarCadastro
            // 
            btnSalvarCadastro.Cursor = Cursors.Hand;
            btnSalvarCadastro.FlatAppearance.BorderColor = Color.White;
            btnSalvarCadastro.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSalvarCadastro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalvarCadastro.FlatStyle = FlatStyle.Flat;
            btnSalvarCadastro.ForeColor = Color.White;
            btnSalvarCadastro.Location = new Point(464, 327);
            btnSalvarCadastro.Margin = new Padding(2);
            btnSalvarCadastro.Name = "btnSalvarCadastro";
            btnSalvarCadastro.Size = new Size(106, 43);
            btnSalvarCadastro.TabIndex = 4;
            btnSalvarCadastro.Text = "Salvar";
            btnSalvarCadastro.UseVisualStyleBackColor = true;
            btnSalvarCadastro.Click += SalvarCadastro_Click;
            // 
            // labelEmailCadastrar
            // 
            labelEmailCadastrar.AutoSize = true;
            labelEmailCadastrar.BackColor = Color.Transparent;
            labelEmailCadastrar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmailCadastrar.ForeColor = Color.White;
            labelEmailCadastrar.Location = new Point(21, 212);
            labelEmailCadastrar.Margin = new Padding(2, 0, 2, 0);
            labelEmailCadastrar.Name = "labelEmailCadastrar";
            labelEmailCadastrar.Size = new Size(45, 19);
            labelEmailCadastrar.TabIndex = 5;
            labelEmailCadastrar.Text = "Email:";
            // 
            // labelSenhaCadastar
            // 
            labelSenhaCadastar.AutoSize = true;
            labelSenhaCadastar.BackColor = Color.Transparent;
            labelSenhaCadastar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenhaCadastar.ForeColor = Color.White;
            labelSenhaCadastar.Location = new Point(18, 120);
            labelSenhaCadastar.Margin = new Padding(2, 0, 2, 0);
            labelSenhaCadastar.Name = "labelSenhaCadastar";
            labelSenhaCadastar.Size = new Size(49, 19);
            labelSenhaCadastar.TabIndex = 4;
            labelSenhaCadastar.Text = "Senha:";
            // 
            // labelNomeCadastar
            // 
            labelNomeCadastar.AutoSize = true;
            labelNomeCadastar.BackColor = Color.Transparent;
            labelNomeCadastar.ForeColor = Color.White;
            labelNomeCadastar.Location = new Point(24, 28);
            labelNomeCadastar.Margin = new Padding(2, 0, 2, 0);
            labelNomeCadastar.Name = "labelNomeCadastar";
            labelNomeCadastar.Size = new Size(50, 19);
            labelNomeCadastar.TabIndex = 3;
            labelNomeCadastar.Text = "Nome:";
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.BackColor = Color.FromArgb(64, 64, 64);
            txtEmailCadastro.BorderStyle = BorderStyle.None;
            txtEmailCadastro.ForeColor = Color.White;
            txtEmailCadastro.Location = new Point(21, 233);
            txtEmailCadastro.Margin = new Padding(2);
            txtEmailCadastro.MaxLength = 50;
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.PlaceholderText = "Inserir email.";
            txtEmailCadastro.Size = new Size(314, 19);
            txtEmailCadastro.TabIndex = 2;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.BackColor = Color.FromArgb(64, 64, 64);
            txtSenhaCadastro.BorderStyle = BorderStyle.None;
            txtSenhaCadastro.ForeColor = Color.White;
            txtSenhaCadastro.Location = new Point(21, 141);
            txtSenhaCadastro.Margin = new Padding(2);
            txtSenhaCadastro.MaxLength = 12;
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "Inserir senha numérica.";
            txtSenhaCadastro.Size = new Size(317, 19);
            txtSenhaCadastro.TabIndex = 1;
            txtSenhaCadastro.UseSystemPasswordChar = true;
            txtSenhaCadastro.TextChanged += txtSenhaCadastro_TextChanged;
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.BackColor = Color.FromArgb(64, 64, 64);
            txtNomeCadastro.BorderStyle = BorderStyle.None;
            txtNomeCadastro.ForeColor = Color.White;
            txtNomeCadastro.Location = new Point(23, 49);
            txtNomeCadastro.Margin = new Padding(2);
            txtNomeCadastro.MaxLength = 50;
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.PlaceholderText = "Inserir nome.";
            txtNomeCadastro.Size = new Size(317, 19);
            txtNomeCadastro.TabIndex = 0;
            // 
            // PainelCadastro
            // 
            PainelCadastro.BackgroundImage = (Image)resources.GetObject("PainelCadastro.BackgroundImage");
            PainelCadastro.Controls.Add(MinimizarCadastro);
            PainelCadastro.Controls.Add(FecharCadastro);
            PainelCadastro.Controls.Add(labelTelaCadastrar);
            PainelCadastro.Dock = DockStyle.Top;
            PainelCadastro.Location = new Point(0, 0);
            PainelCadastro.Name = "PainelCadastro";
            PainelCadastro.Size = new Size(600, 30);
            PainelCadastro.TabIndex = 1;
            // 
            // MinimizarCadastro
            // 
            MinimizarCadastro.BackColor = Color.Transparent;
            MinimizarCadastro.BackgroundImage = (Image)resources.GetObject("MinimizarCadastro.BackgroundImage");
            MinimizarCadastro.BackgroundImageLayout = ImageLayout.Zoom;
            MinimizarCadastro.Dock = DockStyle.Right;
            MinimizarCadastro.FlatAppearance.BorderSize = 0;
            MinimizarCadastro.FlatStyle = FlatStyle.Flat;
            MinimizarCadastro.Location = new Point(530, 0);
            MinimizarCadastro.Name = "MinimizarCadastro";
            MinimizarCadastro.Size = new Size(35, 30);
            MinimizarCadastro.TabIndex = 4;
            MinimizarCadastro.UseVisualStyleBackColor = false;
            MinimizarCadastro.Click += MinimizarCadastro_Click;
            // 
            // FecharCadastro
            // 
            FecharCadastro.BackColor = Color.Transparent;
            FecharCadastro.BackgroundImage = (Image)resources.GetObject("FecharCadastro.BackgroundImage");
            FecharCadastro.BackgroundImageLayout = ImageLayout.Zoom;
            FecharCadastro.Dock = DockStyle.Right;
            FecharCadastro.FlatAppearance.BorderSize = 0;
            FecharCadastro.FlatStyle = FlatStyle.Flat;
            FecharCadastro.Location = new Point(565, 0);
            FecharCadastro.Name = "FecharCadastro";
            FecharCadastro.Size = new Size(35, 30);
            FecharCadastro.TabIndex = 1;
            FecharCadastro.UseVisualStyleBackColor = false;
            FecharCadastro.Click += FecharCadastro_Click;
            // 
            // labelTelaCadastrar
            // 
            labelTelaCadastrar.AutoSize = true;
            labelTelaCadastrar.BackColor = Color.Transparent;
            labelTelaCadastrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelaCadastrar.ForeColor = Color.Transparent;
            labelTelaCadastrar.Location = new Point(5, 6);
            labelTelaCadastrar.Name = "labelTelaCadastrar";
            labelTelaCadastrar.Size = new Size(70, 19);
            labelTelaCadastrar.TabIndex = 0;
            labelTelaCadastrar.Text = "Cadastro";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(labelNomeCadastar);
            panel1.Controls.Add(btnSalvarCadastro);
            panel1.Controls.Add(txtSenhaCadastro);
            panel1.Controls.Add(txtEmailCadastro);
            panel1.Controls.Add(txtNomeCadastro);
            panel1.Controls.Add(labelEmailCadastrar);
            panel1.Controls.Add(labelSenhaCadastar);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 395);
            panel1.TabIndex = 2;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 425);
            Controls.Add(panel1);
            Controls.Add(PainelCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Cadastro_Load;
            PainelCadastro.ResumeLayout(false);
            PainelCadastro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNomeCadastro;
        private Button btnSalvarCadastro;
        private Label labelEmailCadastrar;
        private Label labelSenhaCadastar;
        private Label labelNomeCadastar;
        private TextBox txtEmailCadastro;
        private TextBox txtSenhaCadastro;
        private Panel PainelCadastro;
        private Label labelTelaCadastrar;
        private Button FecharCadastro;
        private Panel panel1;
        private Button MinimizarCadastro;
    }
}