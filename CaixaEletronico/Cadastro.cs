using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaixaEletronico
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=JUNIOR\\Junio;Initial Catalog=Jovem Programador;Data Source=localhost\\SQLEXPRESS");

        private void SalvarCadastro_Click(object sender, EventArgs e)
        {
            if (txtNomeCadastro.Text == "")
            {
                MessageBox.Show("É obrigatório preencher todos os campos!", "Anteção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeCadastro.Focus();
            }
            else
            if (txtSenhaCadastro.Text == "")
            {
                MessageBox.Show("É obrigatório preencher todos os campos!", "Anteção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenhaCadastro.Focus();
            }
            else
            if (txtEmailCadastro.Text == "")
            {
                MessageBox.Show("É obrigatório preencher todos os campos!", "Anteção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmailCadastro.Focus();
            }
            else
            if (txtSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no mínimo 6 caractere", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string nome = txtNomeCadastro.Text;
                    string senha = txtSenhaCadastro.Text;
                    string email = txtEmailCadastro.Text;
                    string sql = "INSERT INTO Cadastro (nome, senha, email) VALUES (@nome,@senha,@email)";

                    SqlCommand cm = new SqlCommand(sql, conn); //comando para mandar dados para o banco

                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@senha", SqlDbType.Int).Value = senha;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

                    conn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Novo Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                }



            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
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

        private void FecharCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }//Fechar cadastro

        private void MinimizarCadastro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }//Minimizar Tela Cadastro

        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {
            if(txtSenhaCadastro.Text.Length == 12)
            {
                MessageBox.Show("Limite de caractere atingido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
