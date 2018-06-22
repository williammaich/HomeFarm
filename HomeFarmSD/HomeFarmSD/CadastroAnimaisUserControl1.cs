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
    public partial class CadastroAnimaisUserControl1 : UserControl
    {
        public CadastroAnimaisUserControl1()
        {
            InitializeComponent();




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);
            

            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO animal (CODIGOBRINCO,NOME,DATANASCIMENTO,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA,PO,RACA,TIPO) VALUES (@codigo,@nome,@datanasc,@nomepai, @nomemae,@sexo,@peso,@morto,@vendida,@po,@raca,@tipo )", Conexao);

                INSERT.Parameters.AddWithValue("@codigo", textCodigo.Text);
                INSERT.Parameters.AddWithValue("@nome", textNome.Text);
               
                INSERT.Parameters.AddWithValue("@datanasc", textDataNascimento.Text);
                INSERT.Parameters.AddWithValue("@nomepai", textNomePai.Text);
                INSERT.Parameters.AddWithValue("@nomemae", textNomeMae.Text);

                if (radioButtonMasculino.Checked)
                {

                    INSERT.Parameters.Add("@sexo", MySqlDbType.VarChar, 45).Value = "Masculino";

                }else if (radioButtonFeminino.Checked)
                {
                    INSERT.Parameters.Add("@sexo", MySqlDbType.VarChar, 45).Value = "Feminino";
                }

                INSERT.Parameters.Add("@peso", MySqlDbType.Double).Value=textPeso.Text;


                if (radioButtonSimMorto.Checked)
                {
                    INSERT.Parameters.Add("@morto", MySqlDbType.VarChar, 45).Value = "Morto";
                }else if (radioButtonNaoMorto.Checked)
                {
                    INSERT.Parameters.Add("@morto", MySqlDbType.VarChar, 45).Value = "Vivo";
                }

                if (radioButtonVendidaSim.Checked)
                {
                    INSERT.Parameters.Add("@vendida", MySqlDbType.VarChar, 45).Value = "Vendida";
                } else if (radioButtonVendidaNao.Checked)
                {
                    INSERT.Parameters.Add("@vendida", MySqlDbType.VarChar, 45).Value = "Não vendida";
                }

                if (radioButtonPOsim.Checked)
                {
                    INSERT.Parameters.Add("@po", MySqlDbType.VarChar, 45).Value = "Puro";
                }
                else if (radioButtonPOnao.Checked)
                {
                    INSERT.Parameters.Add("@po", MySqlDbType.VarChar, 45).Value = "naoPuro";
                }

                

                //INSERT.Parameters.Add("@raca",MySqlDbType.VarChar,45).Value = cmbRaca.SelectedItem.ToString();
                INSERT.Parameters.Add("@raca", MySqlDbType.VarChar, 45).Value = cmbRaca;

                

                INSERT.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = cmbTipo.SelectedItem.ToString();




                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");
            }
            catch (Exception erro)
            {


                MessageBox.Show("ERRO DE CONEXÃO " + erro);

            }

        }

        private void radioButtonSimMorto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNaoMorto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastroAnimaisUserControl1_Load(object sender, EventArgs e)
        {


            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Ligar = new MySqlConnection(Conector);
            try
            {
                Ligar.Open();

                MySqlCommand com = new MySqlCommand();
                com.Connection = Ligar;
                com.CommandText = "SELECT nomeraca FROM raca";

                MySqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbRaca.DisplayMember = "nomeraca";
                cmbRaca.DataSource = dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }

           
            cmbTipo.Items.Add("Bovino");
            cmbTipo.Items.Add("Equino");
            cmbTipo.Items.Add("Ovino");
            cmbTipo.Items.Add("Suino");
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Ligar = new MySqlConnection(Conector);
            try
            {
                Ligar.Open();

                MySqlCommand com = new MySqlCommand();
                com.Connection = Ligar;
                com.CommandText = "SELECT nomeraca FROM raca";

                MySqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbRaca.DisplayMember = "nomeraca";
                cmbRaca.DataSource = dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }
        }
    }
}
