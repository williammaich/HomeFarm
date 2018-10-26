using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HomeFarm.Clases
{
    class FuncionarioDall
    {

        public static List<Funcionario> RetornaListaFuncionario()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, NOME FROM usuario";

            var cmd = new MySqlCommand(sql, conn);

            var lista = new List<Funcionario>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var funcionario = new Funcionario();
                    funcionario.ID = Convert.ToInt32(leitor["ID"]);
                    funcionario.NOME = leitor["NOME"].ToString();


                    lista.Add(funcionario);
                }
            }
            conn.Close();

            return lista;

        }
    }
}
