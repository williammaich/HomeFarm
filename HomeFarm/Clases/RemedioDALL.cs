using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeFarm
{
    class RemedioDALL
    {
        public static List<Remedio> RetornaLista()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, NUMEROLOTE FROM lote";

            var cmd = new MySqlCommand(sql, conn);

            var lista = new List<Remedio>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var remedio = new Remedio();
                    remedio.ID = Convert.ToInt32(leitor["ID"]);
                    remedio.NUMEROLOTE = leitor["NUMEROLOTE"].ToString();
                    

                    lista.Add(remedio);
                }
            }
            conn.Close();

            return lista;

        }

    }

}

