using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace ReservaMysqlWinForms.Entidades
{
    public class Reserva
    {
        static string ConnectionString = "Server=localhost;Database=BdReservas;Uid=usuarioZero;Pwd=12345678";
        static MySqlConnection Conexao = new MySqlConnection(ConnectionString);
        static MySqlCommand comando = Conexao.CreateCommand();

        private int ID;
        private DateTime DATA_ENT;
        private DateTime DATA_SAI;
        private double VALOR_TOTAL;

        

        public Reserva(int id, DateTime data_ent, DateTime data_sai, double valor_total)
        {
            ID = id;
            DATA_ENT = data_ent;
            DATA_SAI = data_sai;
            VALOR_TOTAL = valor_total;
        }


        public void Incluir()
        {
            try
            {
                Conexao.Open();
                comando.CommandText = @"INSERT INTO reservas (data_ent, data_sai, valor_total) values ('" + this.DATA_ENT.ToString("yyyy-MM-dd") + "','" + this.DATA_SAI.ToString("yyyy-MM-dd") + "'," + VALOR_TOTAL.ToString(CultureInfo.InvariantCulture) + ")";
                comando.ExecuteNonQuery();
                Conexao.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao incluir!" + e.Message);
            }
            finally
            {
                comando.CommandText = null;
            }

        }

        public MySqlDataReader Listar()
        {

            MySqlDataReader leitor;

            try
            {
                Conexao.Open();
                string sql = "SELECT * from reservas ORDER BY ID";
                MySqlCommand consulta = new MySqlCommand(sql, Conexao);

                leitor = consulta.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Listar - " + ex.Message);
            }

        }

        public MySqlDataReader BuscaReserva(DateTime DATA_ENT, DateTime DATA_SAI, double VALOR_TOTAL)
        {

            MySqlDataReader leitor;

            try
            {
                Conexao.Open();
                string sql = "SELECT * from reservas WHERE DATA_ENT='" + DATA_ENT.ToString("yyyy-MM-dd") + "' AND DATA_SAI='" + DATA_SAI.ToString("yyyy-MM-dd") + "' AND VALOR_TOTAL=" + VALOR_TOTAL.ToString(CultureInfo.InvariantCulture);
                MySqlCommand consulta = new MySqlCommand(sql, Conexao);

                leitor = consulta.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Listar - " + ex.Message);
            }

        }
    }
}
