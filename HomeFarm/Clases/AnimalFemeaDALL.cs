using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeFarm.Clases
{
    class AnimalFemeaDALL
    {
        public static List<Animal> RetornaListaAnimalFemea()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, NOME FROM animal WHERE SEXO = 'Femea' or SEXO='FEMEA';";

            var cmd = new MySqlCommand(sql, conn);

            var lista = new List<Animal>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var animal = new Animal();
                    animal.ID = Convert.ToInt32(leitor["ID"]);
                    animal.NOME = leitor["NOME"].ToString();


                    lista.Add(animal);
                }
            }
            conn.Close();

            return lista;
        }
    }
}
