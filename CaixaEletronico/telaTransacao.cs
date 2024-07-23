namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        double saldo = 0;
        double valor;
        Boolean retorno;
        DateTime data = DateTime.Now;

        Conexao conexao = new Conexao();
        Transacao transacao = new Transacao();

        public int Opcao { get; set; }
        public int CodigoConta { get; set; }
        public String NomePessoa { get; set; }



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (Opcao)
            {
                case 1:
                    inputOperação.Text = "SACAR";
                    break;

                case 2:
                    inputOperação.Text = "DEPOSITO";
                    break;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inputValor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Opcao)
            {
                //Opção que realizará o SAQUE
                case 1:
                    string input = inputValor.Text.Replace('.', ',');

                    if (!double.TryParse(input, out valor) || valor <= 0)
                    {
                        MessageBox.Show($"Valor informado está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        transacao.CodigoConta = CodigoConta;
                        transacao.Quando = data.ToString("yyyy-MM-dd HH:mm:ss");
                        transacao.Tipo = "SAQUE";
                        transacao.Valor = valor;

                        saldo = conexao.BuscarSaldo(transacao);
                        double podeSacar = transacao.Sacar(transacao, saldo);
                        if (podeSacar < 0)
                        {
                            MessageBox.Show($"Não é possível realizar a operação: {transacao.Tipo}, no valor de R$ {valor}. Seu saldo é de R$ {saldo}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            retorno = conexao.InserirTransacao(transacao);
                            if (retorno == true)
                            {
                                transacao.Valor = transacao.Sacar(transacao, saldo);
                                conexao.AtualizandoDadosNoBanco(transacao);
                                MessageBox.Show($"Realizado a operação: {transacao.Tipo} no VALOR de R$ {inputValor.Text}.", "Sucesso!", MessageBoxButtons.OK);

                                var telaPrincipal = new telaMenuPrincipal();
                                telaPrincipal.CodigoConta = CodigoConta;
                                telaPrincipal.NomePessoa = NomePessoa;
                                telaPrincipal.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao inserir dados no Banco de dados, contate o Administrador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }

                    }
                    break;

                //Opção que realizará o DEPOSITO
                case 2:
                    string inpuT = inputValor.Text.Replace('.', ',');

                    if (!double.TryParse(inpuT, out valor) || valor <= 0)
                    {
                        MessageBox.Show($"Valor informado está inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        transacao.CodigoConta = CodigoConta;
                        transacao.Quando = data.ToString("yyyy-MM-dd HH:mm:ss");
                        transacao.Tipo = "DEPOSITO";
                        transacao.Valor = valor;

                        saldo = conexao.BuscarSaldo(transacao);
                        transacao.Valor = transacao.Depositar(transacao, saldo);

                        retorno = conexao.InserirTransacao(transacao);
                        if (retorno == true)
                        {
                            conexao.AtualizandoDadosNoBanco(transacao);
                            MessageBox.Show($"Realizado a operação: {transacao.Tipo} no VALOR de R$ {inputValor.Text}.", "Sucesso!", MessageBoxButtons.OK);
                            
                            var telaPrincipal = new telaMenuPrincipal();
                            telaPrincipal.CodigoConta = CodigoConta;
                            telaPrincipal.NomePessoa = NomePessoa;
                            telaPrincipal.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir dados no Banco de dados, contate o Administrador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    break;
            }//Fim do Switch

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var telaPrincipal = new telaMenuPrincipal();
            telaPrincipal.NomePessoa = NomePessoa;
            telaPrincipal.CodigoConta = CodigoConta;
            telaPrincipal.Show();
        }

        private void inputValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
