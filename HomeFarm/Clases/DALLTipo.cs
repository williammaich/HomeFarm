using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeFarm
{
    class DALLTipo
    {

        public static List<Tipo> RetornaListaAnimal()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, TIPOANIMAL FROM tipo";

            var cmd = new MySqlCommand(sql, conn);

            var listaTipo = new List<Tipo>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var tipo = new Tipo();
                    tipo.ID = Convert.ToInt32(leitor["ID"]);
                    tipo.TIPOANIMAL = leitor["TIPOANIMAL"].ToString();


                    listaTipo.Add(tipo);
                }
            }
            conn.Close();

            return listaTipo;

        }

    }
}


