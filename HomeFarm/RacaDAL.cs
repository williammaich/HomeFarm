using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeFarm
{
   public class RacaDAL
    {

        public static List<Raca> RetornaLista()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, RACA, ORIGEM FROM raca";

            var cmd = new MySqlCommand(sql, conn);

            var lista = new List<Raca>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var raca = new Raca();
                    raca.ID = Convert.ToInt32(leitor["ID"]);
                    raca.RACA = leitor["RACA"].ToString();
                    raca.ORIGEM = leitor["ORIGEM"].ToString();

                    lista.Add(raca);
                }
            }
            conn.Close();

            return lista;

        }

    }
}
