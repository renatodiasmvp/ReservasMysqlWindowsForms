using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ReservaMysqlWinForms.AcessoDados
{
    public class Database
    {
        static string ConnectionString = "Server=localhost;Database=BdReservas;Uid=usuarioZero;Pwd=12345678";
        public Database()
        {
            
        }

        public MySqlConnection Conexao = new MySqlConnection(ConnectionString);
    }
}
