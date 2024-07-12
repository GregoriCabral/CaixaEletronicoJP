using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=JUNIOR\\Junio;Initial Catalog=Jovem Programador;Data Source=localhost\\SQLEXPRESS");
        public void Conectar()
        { conn.Open(); }
        public void Desconectar()
        { conn.Close(); }
    }
}
