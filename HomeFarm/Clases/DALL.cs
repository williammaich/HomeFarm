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
                comando = new MySqlCommand("SELECT CODIGOBRINCO,NOME,DATANASCIMENTO,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA,PO,TIPOANIMAL,RACA,LOGRADOURO FROM animal INNER JOIN tipo ON animal.TIPO_ID = tipo.ID INNER JOIN raca ON animal.RACA_ID=raca.ID INNER JOIN propriedade ON animal.PROPRIEDADE_ID=propriedade.ID;", conexao);

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

        public DataTable ExibirDadosFuncionarios()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT NOME,SOBRENOME,LOGIN,ADMIN,LOGRADOURO FROM usuario INNER JOIN propriedade ON usuario.PROPRIEDADE_ID = propriedade.ID;", conexao);

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


        public DataTable ExibirDadosPropriedades()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT CEP,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,ESTADO FROM propriedade;", conexao);

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


        public DataTable ExibirDadosMedicamentos()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT NOME,DESCRICAO,ESTOCADO,NUMEROLOTE,LOGRADOURO,DATAVALIDADE FROM medicamento  INNER JOIN lote ON medicamento.LOTE_ID = lote.ID INNER JOIN propriedade ON medicamento.PROPRIEDADE_ID = propriedade.ID;", conexao);

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

        public DataTable ExibirDadosProducao()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT DATAREALIZADA,QUANTIDADE,DATADECADASTRO,DATAALTERACAO,OBSERVACAO,NOME,TIPOANIMAL,LOGRADOURO,RACA FROM producao  INNER JOIN animal ON producao.ANIMAL_ID = animal.ID INNER JOIN tipo ON animal.TIPO_ID = tipo.ID INNER JOIN propriedade ON animal.PROPRIEDADE_ID = propriedade.ID INNER JOIN raca ON animal.RACA_ID = raca.ID; ", conexao);

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

        //Listagem dos combobox

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
                    

                    propriedade.ID = Convert.ToInt32(leitor["ID"].ToString());
                    propriedade.LOGRADOURO = leitor["LOGRADOURO"].ToString();

                    
                    lista.Add(propriedade);
                    
                }
            }
            conn.Close();

            return lista;

        }

    } 


}





