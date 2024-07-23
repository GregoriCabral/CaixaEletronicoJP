namespace CaixaEletronico
{
    partial class telaMenuPrincipal
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            label3 = new Label();
            nomePessoa = new TextBox();
            inputSaldoBd = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 128);
            label1.Name = "label1";
            label1.Size = new Size(216, 19);
            label1.TabIndex = 0;
            label1.Text = "Qual a operação deseja fazer? ";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(21, 150);
            button1.Name = "button1";
            button1.Size = new Size(116, 28);
            button1.TabIndex = 1;
            button1.Text = "SAQUE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(21, 184);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 2;
            button2.Text = "DEPOSITO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(21, 219);
            button3.Name = "button3";
            button3.Size = new Size(116, 28);
            button3.TabIndex = 3;
            button3.Text = "EXTRATO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 6;
            label2.Text = "Saldo Atual:";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(21, 253);
            button4.Name = "button4";
            button4.Size = new Size(116, 28);
            button4.TabIndex = 8;
            button4.Text = "SAIR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 19);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 9;
            label3.Text = "Olá,";
            // 
            // nomePessoa
            // 
            nomePessoa.BorderStyle = BorderStyle.None;
            nomePessoa.Enabled = false;
            nomePessoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nomePessoa.Location = new Point(35, 19);
            nomePessoa.Name = "nomePessoa";
            nomePessoa.Size = new Size(91, 18);
            nomePessoa.TabIndex = 10;
            nomePessoa.TextChanged += nomePessoa_TextChanged;
            // 
            // inputSaldoBd
            // 
            inputSaldoBd.BorderStyle = BorderStyle.FixedSingle;
            inputSaldoBd.Enabled = false;
            inputSaldoBd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputSaldoBd.Location = new Point(21, 74);
            inputSaldoBd.Name = "inputSaldoBd";
            inputSaldoBd.Size = new Size(105, 35);
            inputSaldoBd.TabIndex = 11;
            inputSaldoBd.TextChanged += inputSaldoBd_TextChanged;
            // 
            // telaMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 300);
            Controls.Add(inputSaldoBd);
            Controls.Add(nomePessoa);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "telaMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            TransparencyKey = Color.Black;
            FormClosing += telaMenuPrincipal_FormClosing;
            Load += telaMenuPrincipal_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button button4;
        private Label label3;
        private TextBox nomePessoa;
        private TextBox inputSaldoBd;
    }
}