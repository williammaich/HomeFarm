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

namespace HomeFarm.Controle
{
    public partial class TelaBaixas : Form
    {
        public TelaBaixas()
        {
            InitializeComponent();


            CarregaComboAnimal();


            DLL dll = new DLL();
            try
            {

                dataGridBaixas.DataSource = dll.ExibirDadosDalBaixas();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }

        }

        private void CarregaComboAnimal()
        {
            comboNome.DataSource = AnimalDALL.RetornaListaAnimal();
            comboNome.DisplayMember = "NOME";
            comboNome.ValueMember = "ID";
        }




     
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO baixas (ANIMAL_ID, DATADAMORTE, DOENCA) VALUES (@animal, @datamorte, @doenca)", Conexao);

                INSERT.Parameters.AddWithValue("@animal", comboNome.SelectedValue.ToString());
                INSERT.Parameters.AddWithValue("@datamorte", this.DataMorte.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@doenca", txtDoenca.Text);
                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

               



            }
            catch (Exception erro)
            {
                MessageBox.Show("erro de conexao" + erro);

            }
        }

        private void ImgControle_Click(object sender, EventArgs e)
        {
            MenuControle cont = new MenuControle();
            cont.Show();
            this.Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
