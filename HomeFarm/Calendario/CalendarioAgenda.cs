using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MySql.Data.MySqlClient;
using MySql.Data;
using HomeFarm.Clases;

namespace HomeFarm.Calendario
{
    
    public partial class CalendarioAgenda : Form
    {

    
        
       
        public CalendarioAgenda()
        {
            InitializeComponent();

            DLL dll = new DLL();
            try
            {

                dataGVagenda.DataSource = dll.ExibirDadosDalAgenda();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }




        }

    

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO agenda (DATAINICIO, DATAFINAL, EVENTO) VALUES (@dataInicial, @dataFinal, @evento)", Conexao);
        
                INSERT.Parameters.AddWithValue("@dataInicial", this.dataInicial.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@dataFinal", this.dataFinal.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@evento", txtEvento.Text);
                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

                txtEvento.Text = "";
                
               

            }
            catch(Exception erro)
            {
                MessageBox.Show("erro de conexao" + erro);

            }
        }

        private void txtAgenda_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
