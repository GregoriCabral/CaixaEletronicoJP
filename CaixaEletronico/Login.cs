using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaixaEletronico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=JUNIOR\\Junio;Initial Catalog=Jovem Programador;Data Source=localhost\\SQLEXPRESS");

        SqlCommand cm = new SqlCommand(); //comando para mandar dados para o banco

        SqlDataReader db; //recebe os dados do banco

        private void Entrar_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text == "" || txtLogin.Text == "")
            {
                MessageBox.Show("Informe seus dados!","Aten��o!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    cm.CommandText = "select * from Cadastro where nome =('"+txtLogin.Text+"') and senha =('"+txtSenha.Text+"')";//Busca os dados na tabela selecionada no banco
                    cm.Connection = conn;//Estabelece conex�o
                    db = cm.ExecuteReader();//Executa a leitura do banco.

                    if(db.HasRows)
                    {
                        //menu.Show();
                        //this.Hide();//Oculta a jenela que esta aberta.
                    }//Seu houver o usu�rio cadastro no banco de dados ele ser� direcionado para o menu.
                    else
                    {
                        MessageBox.Show("Usu�rio ou senha inv�lida!", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception Erro) 
                {
                    MessageBox.Show(Erro.Message);
                    conn.Close();
                }
            }
        }//Bot�o Entrar 

        private void LinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastro = new Cadastro();
            cadastro.Show();
        }//Bot�o criar conta

        private void FecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Bot�o fechar

        private void Form1_Load(object sender, EventArgs e)
        {
            // Defina o raio desejado para os cantos arredondados
            int radius = 20;

            // Crie um GraphicsPath para definir a regi�o com cantos arredondados
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            // Aplique a regi�o ao formul�rio
            this.Region = new Region(path);
        }//Arredondar cantos

        private void MinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }//Minimizar tela login

    }
}
