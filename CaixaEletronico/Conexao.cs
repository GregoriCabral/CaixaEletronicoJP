using System.Data;
using System.Data.SqlClient;

namespace CaixaEletronico
{
    internal class Conexao
    {
        public SqlConnection bancoDados = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CaixaEletronicoJP;Data Source=NOTEBOOK\\SQLEXPRESS");


        public void Conectar()
        {
            bancoDados.Open();
        }

        public void Desconectar()
        {
            bancoDados.Close();
        }

        public bool InserirTransacao(Transacao transacao)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                string sql = "INSERT INTO Transacao (quando, tipo, valor, codigoConta) VALUES (@quando, @tipo, @valor, @codigoConta)";

                SqlCommand comando = new SqlCommand(sql, conexao.bancoDados);
                comando.Parameters.Add("@quando", SqlDbType.DateTime).Value = transacao.Quando;
                comando.Parameters.AddWithValue("@tipo", transacao.Tipo);
                comando.Parameters.AddWithValue("@valor", transacao.Valor);
                comando.Parameters.AddWithValue("@codigoConta", transacao.CodigoConta);

                int result = comando.ExecuteNonQuery();

                conexao.Desconectar();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public double BuscarSaldo(Transacao transacao)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                string sql = "SELECT saldo FROM conta WHERE codigoPessoa = @codigoConta";

                SqlCommand comando = new SqlCommand(sql, conexao.bancoDados);
                comando.Parameters.AddWithValue("@codigoConta", transacao.CodigoConta);

                SqlDataReader reader = comando.ExecuteReader();

                double saldo = 0;

                if (reader.Read())
                {
                    saldo = (double)reader.GetDecimal(0);
                }

                reader.Close();
                conexao.Desconectar();

                return saldo;
            }
            catch (Exception erro)
            {
                return -1;
            }
        }

        public void AtualizandoDadosNoBanco(Transacao transacao)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                string sql = "UPDATE conta SET saldo = @valor WHERE codigo = @codigoConta";

                SqlCommand comando = new SqlCommand(sql, conexao.bancoDados);
                comando.Parameters.AddWithValue("@valor", transacao.Valor);
                comando.Parameters.AddWithValue("@codigoConta", transacao.CodigoConta);

                int result = comando.ExecuteNonQuery();

                conexao.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarConta (int codigoPessoa)
        {
            int codigo = codigoPessoa;
            try
            {
                Conexao conexao = new Conexao();

                conexao.Conectar();

                string sql = "SELECT codigoPessoa FROM conta WHERE codigoPessoa = @codigoPessoa";

                SqlCommand comando = new SqlCommand(sql, conexao.bancoDados);
                comando.Parameters.AddWithValue("@codigoPessoa", codigo);
                SqlDataReader reader = comando.ExecuteReader();

                if (!reader.Read())
                {
                    reader.Close();
                    sql = "INSERT INTO conta (codigoPessoa) VALUES (@codigoPessoa)";
                    using(SqlCommand comandoInsert = new SqlCommand(sql, conexao.bancoDados))
                    {
                        try
                        {
                            comandoInsert.Parameters.AddWithValue("@codigoPessoa", codigo);
                            comandoInsert.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }

                reader.Close();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public int CodigoConta(int codigoPessoa)
        {
            int codigo = codigoPessoa;

            try
            {
                Conexao conexao = new Conexao();

                conexao.Conectar();

                string sql = "SELECT codigo FROM conta WHERE codigoPessoa = @codigoPessoa";

                SqlCommand comando = new SqlCommand(sql, conexao.bancoDados);
                comando.Parameters.AddWithValue("@codigoPessoa", codigo);

                SqlDataReader reader = comando.ExecuteReader();

                int codigoConta = 0;

                if (reader.Read())
                {
                    codigoConta = reader.GetInt32(0);
                }

                reader.Close();
                conexao.Desconectar();

                return codigoConta;
            }
            catch (Exception erro)
            {
                return -1;
            }
        }

        public List<Transacao> BuscarTransacoes(int codigoConta)
        {
            int codigo = codigoConta;

            List<Transacao> transacoes = new List<Transacao>();

            Conexao conexao = new Conexao();
            conexao.Conectar();

            String sql = "SELECT quando, tipo, valor FROM Transacao WHERE codigoConta = @codigo";
            SqlCommand comando = new SqlCommand(sql, conexao.bancoDados);
            comando.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Transacao transacao = new Transacao
                {
                    Quando = reader.GetDateTime(reader.GetOrdinal("quando")).ToString("dd/MM/yyyy HH:mm:ss"),
                    Tipo = reader.GetString(reader.GetOrdinal("tipo")),
                    Valor = (double)reader.GetDecimal(reader.GetOrdinal("valor"))
                };
                transacoes.Add(transacao);
            }

            return transacoes;
        }

    }
}
