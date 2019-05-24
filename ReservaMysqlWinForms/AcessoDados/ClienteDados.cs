using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ReservaMysqlWinForms.AcessoDados
{
    public class ClienteDados
    {
        static Database db = new Database();
        MySqlCommand comando = db.Conexao.CreateCommand();
        

        public void Incluir(string nome, string cpf, string telefone, string endereco, string email)
        {
            db.Conexao.Open();
            comando.CommandText = @"INSERT INTO cliente VALUES (null, '" + nome + "', '" + cpf + "', '" + telefone + "', '" + endereco + "', '" + email + "')";
            comando.ExecuteNonQuery();
            db.Conexao.Close();
        }

        public MySqlDataReader Listar()
        {
            MySqlDataReader leitor;

            db.Conexao.Open();
            string sql = "SELECT * FROM cliente ORDER BY id";
            MySqlCommand consulta = new MySqlCommand(sql, db.Conexao);

            leitor = consulta.ExecuteReader();
            return leitor;
        }
    }
}
