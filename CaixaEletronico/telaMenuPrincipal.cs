using CaixaEletronicoJP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class telaMenuPrincipal : Form
    {
        public string NomePessoa { get; set; }
        public int CodigoConta { get; set; }

        Transacao transacao = new Transacao();
        Conexao conexao = new Conexao();

        public telaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void telaMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            nomePessoa.Text = " " + NomePessoa;

            transacao.CodigoConta = CodigoConta;
            double saldo = conexao.BuscarSaldo(transacao);
            decimal saldoDecimal = (decimal)saldo;

            inputSaldoBd.Text = "R$ " + saldoDecimal.ToString("F2");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            //Executa a tela Transação como Saque
            var telaTransacao = new Form1();
            telaTransacao.Opcao = 1;
            telaTransacao.CodigoConta = CodigoConta;
            telaTransacao.NomePessoa = NomePessoa;
            telaTransacao.Show();

            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //Executa a tela transação como Deposito
            var telaTransacao = new Form1();
            telaTransacao.Opcao = 2;
            telaTransacao.CodigoConta = CodigoConta;
            telaTransacao.NomePessoa = NomePessoa;
            telaTransacao.Show();

            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Executa a tela Extrato
            var telaExtrato = new telaExtrato();
            telaExtrato.CodigoConta = CodigoConta;
            telaExtrato.NomePessoa = NomePessoa;
            telaExtrato.Show();

            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Volta para tela inicial
            this.Hide();

            var login = new Login();
            login.Show();

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void saudacaoPessoa_Click(object sender, EventArgs e)
        {

        }

        private void nomePessoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputSaldoBd_TextChanged(object sender, EventArgs e)
        {

        }

        private void telaMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
