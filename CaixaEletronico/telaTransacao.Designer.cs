namespace CaixaEletronico
{
    partial class Form1
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
            DateTimePicker inputData;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            inputTime = new DateTimePicker();
            inputOperação = new TextBox();
            inputValor = new TextBox();
            inputData = new DateTimePicker();
            SuspendLayout();
            // 
            // inputData
            // 
            inputData.AccessibleRole = AccessibleRole.TitleBar;
            inputData.CausesValidation = false;
            inputData.Checked = false;
            inputData.Enabled = false;
            inputData.Format = DateTimePickerFormat.Short;
            inputData.Location = new Point(14, 68);
            inputData.Name = "inputData";
            inputData.RightToLeftLayout = true;
            inputData.Size = new Size(120, 23);
            inputData.TabIndex = 1;
            inputData.TabStop = false;
            inputData.Value = new DateTime(2024, 7, 5, 0, 0, 0, 0);
            inputData.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(216, 17);
            label1.TabIndex = 0;
            label1.Text = "Confirme os dados da Transação: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Data da operação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de operação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 6;
            label4.Text = "Informe o valor:";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(140, 224);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 7;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(59, 224);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // inputTime
            // 
            inputTime.Enabled = false;
            inputTime.Format = DateTimePickerFormat.Time;
            inputTime.Location = new Point(140, 68);
            inputTime.Name = "inputTime";
            inputTime.Size = new Size(88, 23);
            inputTime.TabIndex = 10;
            inputTime.TabStop = false;
            inputTime.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // inputOperação
            // 
            inputOperação.Enabled = false;
            inputOperação.Location = new Point(14, 118);
            inputOperação.Name = "inputOperação";
            inputOperação.Size = new Size(120, 23);
            inputOperação.TabIndex = 11;
            // 
            // inputValor
            // 
            inputValor.Location = new Point(14, 181);
            inputValor.Name = "inputValor";
            inputValor.Size = new Size(120, 23);
            inputValor.TabIndex = 12;
            inputValor.TextChanged += inputValor_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 274);
            Controls.Add(inputValor);
            Controls.Add(inputOperação);
            Controls.Add(inputTime);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputData);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transação";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker inputData;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private DateTimePicker inputTime;
        private TextBox inputOperação;
        private TextBox inputValor;
    }
}
