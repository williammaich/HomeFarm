using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeFarm.Clases;
using MySql.Data.MySqlClient;

namespace HomeFarm.Controle
{
    public partial class TelaPrenhes : Form
    {
        public TelaPrenhes()
        {
            InitializeComponent();

            CarregaComboNomeAnimal();
            CarregaComboPaiAnimal();

            comboTipo.Items.Add("Bovino");
            comboTipo.Items.Add("Equino");
            comboTipo.Items.Add("Suino");
            comboTipo.Items.Add("Ovino");
            comboTipo.Items.Add("Aves");


            DLL dll = new DLL();
            try
            {

                dataGridPrenhes.DataSource = dll.ExibirDadosDalPrenhes();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }
        }

        private void CarregaComboNomeAnimal()
        {
            comboNome.DataSource = AnimalFemeaDALL.RetornaListaAnimalFemea();
            comboNome.DisplayMember = "NOME";
            comboNome.ValueMember = "ID";
        }

        private void CarregaComboPaiAnimal()
        {
            comboPai.DataSource = AnimalMachoDALL.RetornaListaAnimalMacho();
            comboPai.DisplayMember = "NOME";
            comboPai.ValueMember = "ID";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO prenhes (ANIMAL_ID,DATADOCOBRIMENTO,PAI,DATAPREVISTA) VALUES (@nome,@datacobrimento,@pai,@dataprevista )", Conexao);

                INSERT.Parameters.AddWithValue("@nome", comboNome.SelectedValue.ToString());
                INSERT.Parameters.AddWithValue("@datacobrimento", this.DataCobrimento.Value.ToString("yyyy-MM-dd"));
                INSERT.Parameters.AddWithValue("@pai", comboPai.SelectedValue.ToString());
                INSERT.Parameters.AddWithValue("@dataprevista", this.DataPrevista.Value.ToString("yyyy-MM-dd"));


                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");




            }
            catch (Exception erro)
            {


                MessageBox.Show("ERRO DE CONEXÃO " + erro);

            }

        }

        /*
        private void TelaPrenhes_Load(object sender, EventArgs e)
        {
            if(comboTipo.SelectedItem.ToString() == "Bovino")
            {
                this.DataPrevista.ToString() == this.DataCobrimento.ToString() + 270;
            }
        }
        */
    }
}
