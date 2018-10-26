using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeFarm.Clases
{
    class MedicamentoDall
    {

        public static List<Medicamento> RetornaListaMedicamento()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, NOME FROM medicamento";

            var cmd = new MySqlCommand(sql, conn);

            var lista = new List<Medicamento>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var medicamento = new Medicamento();
                    medicamento.ID = Convert.ToInt32(leitor["ID"]);
                    medicamento.NOME = leitor["NOME"].ToString();


                    lista.Add(medicamento);
                }
            }
            conn.Close();

            return lista;

        }
    }
}
