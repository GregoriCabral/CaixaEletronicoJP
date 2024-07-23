using CaixaEletronico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoJP
{
    public partial class telaExtrato : Form
    {
        Conexao conexao = new Conexao();
        public int CodigoConta { get; set; }
        public string NomePessoa { get; set; }

        String filtro;

        public telaExtrato()
        {
            InitializeComponent();
        }


        private void telaExtrato_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Todas");
            comboBox1.Items.Add("Deposito");
            comboBox1.Items.Add("Saque");
            comboBox1.SelectedItem = "Todas";

            CarregarDados();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void telaExtrato_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaPrincipal = new telaMenuPrincipal();
            telaPrincipal.CodigoConta = CodigoConta;
            telaPrincipal.NomePessoa = NomePessoa;
            telaPrincipal.Show();

            this.Hide();
        }

        private void CarregarDados()
        {
            filtro = comboBox1.SelectedItem.ToString();
            List<Transacao> transacoes = new List<Transacao>();

            if (filtro == "Todas")
            {
                transacoes = conexao.BuscarTransacoes(CodigoConta);
            }
            else
            {
                transacoes = conexao.BuscarTransacoes(CodigoConta).Where(t => t.Tipo == filtro.ToUpper()).ToList();
            }

            dataGridView1.Rows.Clear();
            foreach (var transacao in transacoes)
            {
                dataGridView1.Rows.Add(transacao.Quando, transacao.Tipo, $"R$  {transacao.Valor:F2}");
            }
        }
    }
}
