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
    public partial class GrafAnimais : Form
    {
        public GrafAnimais()
        {
            InitializeComponent();

            CarregaComboAnimal();
           
            

           
        }

       


        


        static String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
        MySqlConnection conexao = new MySqlConnection(Conection);

       
        private void CarregaComboAnimal()
        {
            comboAnimal.DataSource = AnimalDALL.RetornaListaAnimal();
            comboAnimal.DisplayMember = "NOME";
            comboAnimal.ValueMember = "ID";
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }

        private void GrafAnimais_Load(object sender, EventArgs e)
        {

           
        }

        public void chart()
        {
            conexao.Open();
            try
            {
                MySqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT PRODUCAO.DATAREALIZADA,PRODUCAO.QUANTIDADE,PROPRIEDADE.LOGRADOURO FROM PRODUCAO,PROPRIEDADE WHERE ANIMAL_ID = "+comboAnimal.SelectedValue.ToString()+";";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //chart1.Series["QUANTIDADE"].Points.Add(reader.GetDouble("QUANTIDADE"));
                    chart1.Series["QUANTIDADE"].Points.AddXY(reader.GetDateTime("DATAREALIZADA"),reader.GetDouble("QUANTIDADE"));
                    //chart1.Series["QUANTIDADE"].Points.AddY(reader.GetDateTime("DATAREALIZADA"));
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro!!"+ erro);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }

        private void ImgProcurar_Click(object sender, EventArgs e)
        {
            chart1.Series["QUANTIDADE"].Points.Clear();

            chart();
        }
    }
}
