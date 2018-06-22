using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HomeFarmSD
{
    class ClassDAL
    {
        string conectaBanco = "server=localhost; userid=root; database=homefarm; SslMode=none";
        MySqlConnection conexao = null;
        MySqlCommand comando;

        public DataTable ExibirDados()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM animal;", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                return Dt;

            }catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
