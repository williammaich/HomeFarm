using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeFarmSD
{
    public partial class CadastroRacaUserControl1 : UserControl
    {
        public CadastroRacaUserControl1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO raca (ORIGEM, NOMERACA) VALUES (@origem, @nomeraca)", Conexao);
                INSERT.Parameters.AddWithValue("@nomeraca", textNomeRaca.Text);
                INSERT.Parameters.AddWithValue("@origem", textOrigemRaca.Text);
                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

            }
            catch
            {


                MessageBox.Show("ERRO DE CONEXÃO");

            }




        }
    }
}
