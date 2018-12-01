using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HomeFarm.Graficos
{
    public partial class GrafFuncionarios : Form
    {
        public GrafFuncionarios()
        {
            InitializeComponent();
            CarregaComboPropriedade();
        }

        private void CarregaComboPropriedade()
        {
            comboPropriedade.DataSource = DALL.RetornaListaPropriedade();
            comboPropriedade.DisplayMember = "LOGRADOURO";
            comboPropriedade.ValueMember = "ID";
        }

        static String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
        MySqlConnection conexao = new MySqlConnection(Conection);

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuGraficos menu = new MenuGraficos();
            menu.Show();
            this.Visible = false;
        }

        public void chart()
        {
            conexao.Open();
            try
            {
                MySqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT NOME, PROPRIEDADE_ID  FROM usuario ;";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //chart1.Series["QUANTIDADE"].Points.Add(reader.GetDouble("QUANTIDADE"));
                    chartFuncionario.Series["NOME"].Points.AddXY(reader.GetString("PROPRIEDADE_ID"), reader.GetString("NOME"));
                    //chart1.Series["QUANTIDADE"].Points.AddY(reader.GetDateTime("DATAREALIZADA"));
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro!!" + erro);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }

       

        private void ImgProcurar_Click_1(object sender, EventArgs e)
        {
            chartFuncionario.Series["NOME"].Points.Clear();

            chart();
        }
    }
}
