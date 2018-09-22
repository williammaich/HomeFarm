using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace HomeFarm
{
    class DALL
    {
        
        string conectaBanco = "server=localhost; userid=root; database=homefarm; SslMode=none";
        MySqlConnection conexao = null;
        MySqlCommand comando;





        public DataTable ExibirDados()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM animal ;", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                return Dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<Propriedade> RetornaListaPropriedade()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

            var sql = "SELECT ID, LOGRADOURO FROM propriedade";

            var cmd = new MySqlCommand(sql, conn);

            var lista = new List<Propriedade>();

            conn.Open();

            var leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var propriedade = new Propriedade();
                    
                   propriedade.ID = Convert.ToInt32(leitor["ID"]);
                    propriedade.LOGRADOURO = leitor["LOGRADOURO"].ToString();


                    lista.Add(propriedade);
                }
            }
            conn.Close();

            return lista;

        }

    }



    /*
    public static List<Tipo> RetornaListaTipo()
    {

        MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

        var sql = "SELECT ID, TIPOANIMAL FROM tipo";

        var cmd = new MySqlCommand(sql, conn);

        var lista = new List<Tipo>();

        conn.Open();

        var leitor = cmd.ExecuteReader();

        if (leitor.HasRows)
        {
            while (leitor.Read())
            {
                var tipo = new Tipo();
                tipo.ID = Convert.ToInt32(leitor["ID"]);
                tipo.TIPOANIMAL = leitor["TIPOANIMAL"].ToString();


                lista.Add(tipo);
            }
        }
        conn.Close();

        return lista;

    }


    public static List<Propriedade> RetornaListaPropriedade()
    {

        MySqlConnection conn = new MySqlConnection("server=localhost; userid=root; database=homefarm; SslMode=none");

        var sql = "SELECT ID, LOGRADOURO FROM propriedade";

        var cmd = new MySqlCommand(sql, conn);

        var lista = new List<Propriedade>();

        conn.Open();

        var leitor = cmd.ExecuteReader();

        if (leitor.HasRows)
        {
            while (leitor.Read())
            {
                var propriedade = new Propriedade();
                propriedade.ID = Convert.ToInt32(leitor["ID"]);
                propriedade.LOGRADOURO = leitor["LOGRADOURO"].ToString();


                lista.Add(propriedade);
            }
        }
        conn.Close();

        return lista;

    }

}
*/

}


