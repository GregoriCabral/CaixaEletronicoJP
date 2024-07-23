using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.PortableExecutable;

namespace CaixaEletronico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public String NomePessoa {  get; set; } 

        Conexao conn = new Conexao();
        SqlCommand cm = new SqlCommand(); //comando para mandar dados para o banco
        SqlDataReader db; //recebe os dados do banco

        Transacao transacao = new Transacao();

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "" || txtLogin.Text == "")
            {
                MessageBox.Show("Informe seus dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Conectar();
                    cm.CommandText = "select * from Pessoa where nome =('" + txtLogin.Text + "') and senha =('" + txtSenha.Text + "')";//Busca os dados na tabela selecionada no banco
                    cm.Connection = conn.bancoDados;//Estabelece conexão
                    db = cm.ExecuteReader();//Executa a leitura do banco.


                    int codigoPessoa = 0;

                    if (db.HasRows)
                    {
                        db.Read();
                        codigoPessoa = db.GetInt32(0);
                        String nomePessoa = db.GetString(1);

                        conn.ValidarConta(codigoPessoa);

                        var telaPrincipal = new telaMenuPrincipal();
                        telaPrincipal.NomePessoa = nomePessoa;
                        telaPrincipal.CodigoConta = conn.CodigoConta(codigoPessoa);
                        
                        MessageBox.Show($"Bem-vindo ao Sistema!", "Sucesso!", MessageBoxButtons.OK);

                        telaPrincipal.Show();
                        this.Hide();

                    }//Seu houver o usuário cadastro no banco de dados ele será direcionado para o menu.
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    db.Close();
                    conn.Desconectar();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message);
                    conn.Desconectar();
                }
            }
        }//Botão Entrar 

        private void LinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }//Botão criar conta

        private void FecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Botão fechar

        private void Form1_Load(object sender, EventArgs e)
        {
            // Defina o raio desejado para os cantos arredondados
            int radius = 20;

            // Crie um GraphicsPath para definir a região com cantos arredondados
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            // Aplique a região ao formulário
            this.Region = new Region(path);
        }//Arredondar cantos

        private void MinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }//Minimizar tela login

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LinkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Favor contatar o Administrador!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
