
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace HomeFarm.Clases
{
    class AgendaDALL
    {
        public static List<Agenda> RetornaListaAgenda()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, DATAINICIO FROM agenda";

            var cmd = new MySqlCommand(sql, conn);

            var lista = new List<Agenda>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {

                while (leitor.Read())
                {
                    var agenda = new Agenda();


                    agenda.ID = Convert.ToInt32(leitor["ID"].ToString());
                    agenda.DATAINICIO = leitor["DATAINICIO"].ToString();


                    lista.Add(agenda);

                }
            }
            conn.Close();

            return lista;

        }
    }
}
