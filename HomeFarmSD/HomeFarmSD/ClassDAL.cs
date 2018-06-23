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
                comando = new MySqlCommand("SELECT * FROM animal WHERE tipo='bovino';", conexao);

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

        public DataTable ExibirDadosEquino()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM animal WHERE tipo='equino';", conexao);

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

        public DataTable ExibirDadosOvino()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM animal WHERE tipo='ovino';", conexao);

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

        public DataTable ExibirDadosSuino()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM animal WHERE tipo='suino';", conexao);

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

        public DataTable ExibirDadosCampos()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM campos;", conexao);

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

        public DataTable ExibirDadosUsuarios()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM usuario;", conexao);

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
    }
}
