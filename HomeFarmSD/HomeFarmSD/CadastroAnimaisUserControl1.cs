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

                INSERT.Parameters.Add("@sexo", MySqlDbType.VarChar, 45).Value = cmbSexo.SelectedItem.ToString();


                INSERT.Parameters.Add("@peso", MySqlDbType.VarChar, 80).Value = textPeso.Text;


                INSERT.Parameters.Add("@morto", MySqlDbType.VarChar, 45).Value = cmbMorto.SelectedItem.ToString();

                INSERT.Parameters.Add("@vendida", MySqlDbType.VarChar, 45).Value = cmbVendida.SelectedItem.ToString();

                INSERT.Parameters.Add("@po", MySqlDbType.VarChar, 45).Value = cmbPO.SelectedItem.ToString();



                INSERT.Parameters.Add("@raca",MySqlDbType.VarChar,45).Value = cmbRaca.SelectedItem.ToString();
               // INSERT.Parameters.Add("@raca", MySqlDbType.VarChar, 45).Value = cmbRaca;



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

            /*
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

                Ligar.Close();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }


            cmbTipo.Items.Add("Bovino");
            cmbTipo.Items.Add("Equino");
            cmbTipo.Items.Add("Ovino");
            cmbTipo.Items.Add("Suino");

            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Feminino");


            cmbMorto.Items.Add("Sim");
            cmbMorto.Items.Add("Não");

            cmbVendida.Items.Add("Sim");
            cmbVendida.Items.Add("Não");

            cmbPO.Items.Add("Sim");
            cmbPO.Items.Add("Não");
        */
            cmbTipo.Items.Add("Bovino");
            cmbTipo.Items.Add("Equino");
            cmbTipo.Items.Add("Ovino");
            cmbTipo.Items.Add("Suino");

            cmbRaca.Items.Add("Holandes");
            cmbRaca.Items.Add("Gersey");
            cmbRaca.Items.Add("Mustangue");
            cmbRaca.Items.Add("Cavalos arabes");
            cmbRaca.Items.Add("Brudy");
            cmbRaca.Items.Add("Zebu");
            cmbRaca.Items.Add("Gusera");
            cmbRaca.Items.Add("Angus");
            cmbRaca.Items.Add("Red Angus");
            cmbRaca.Items.Add("Merino");
            cmbRaca.Items.Add("Dorper");
            cmbRaca.Items.Add("Corriedale");
            cmbRaca.Items.Add("LargeWhite");
            cmbRaca.Items.Add("Durock");


            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Feminino");


            cmbMorto.Items.Add("Sim");
            cmbMorto.Items.Add("Não");

            cmbVendida.Items.Add("Sim");
            cmbVendida.Items.Add("Não");

            cmbPO.Items.Add("Sim");
            cmbPO.Items.Add("Não");
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

                com.ExecuteNonQuery();
                Ligar.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conecta = new MySqlConnection(Conector);
            try
            {
                Conecta.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE animal SET NOME=?,DATANASCIMENTO=?,NOMEPAI=?,NOMEMAE=?,SEXO=?,PESO=?,MORTO=?,VENDIDA=?,PO=?,RACA=?,TIPO= ? WHERE CODIGOBRINCO", Conecta);

                comando.Parameters.Clear();

                /*
                //comando.Parameters.Add("@codigo", MySqlDbType.VarChar, 45).Value = textCodigo.Text;
               // comando.Parameters.AddWithValue("@codigo", textCodigo.Text);
                comando.Parameters.AddWithValue("@nome", textNome.Text);
                comando.Parameters.AddWithValue("@datanascimento", textDataNascimento.Text);
                comando.Parameters.AddWithValue("@nomepai", textNomePai.Text);
                comando.Parameters.AddWithValue("@nomemae", textNomeMae.Text);
                //comando.Parameters.Add("@sexo", MySqlDbType.VarChar, 45).Value = cmbSexo.SelectedItem.ToString();
                comando.Parameters.AddWithValue("@sexo", cmbSexo.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@peso", textPeso.Text);
                comando.Parameters.AddWithValue("@morto", cmbMorto.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@vendida", cmbVendida.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@po", cmbPO.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@raca", cmbRaca.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@tipo", cmbTipo.SelectedItem.ToString());
                */

                
              
                comando.Parameters.Add("@nome", MySqlDbType.VarChar, 85).Value = textNome.Text;
                comando.Parameters.Add("@dadanascimento", MySqlDbType.VarChar, 45).Value = textDataNascimento.Text;
                comando.Parameters.Add("@nomepai", MySqlDbType.VarChar, 85).Value = textNomePai.Text;
                comando.Parameters.Add("@nomemae", MySqlDbType.VarChar, 85).Value = textNomeMae.Text;
                comando.Parameters.Add("@sexo", MySqlDbType.VarChar, 45).Value = cmbSexo.SelectedItem.ToString();
                comando.Parameters.Add("@peso", MySqlDbType.VarChar, 877).Value = textPeso.Text;
                comando.Parameters.Add("@morto", MySqlDbType.VarChar, 45).Value = cmbMorto.SelectedItem.ToString();
                comando.Parameters.Add("@vendida", MySqlDbType.VarChar, 45).Value = cmbVendida.SelectedItem.ToString();
                comando.Parameters.Add("@po", MySqlDbType.VarChar, 45).Value = cmbPO.SelectedItem.ToString();
                comando.Parameters.Add("@raca", MySqlDbType.VarChar, 45).Value = cmbRaca.SelectedItem.ToString();
                comando.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = cmbTipo.SelectedItem.ToString();
               
                
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                
                Conecta.Close();
                MessageBox.Show("Atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }


          



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Ligar = new MySqlConnection(Conector);
            try
            {
                Ligar.Open();

                MySqlCommand com = new MySqlCommand();
                com.Connection = Ligar;
                com.CommandText = "SELECT NOME,DATANASCIMENTO,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA,PO,RACA,TIPO FROM animal WHERE NOME= ? OR CODIGOBRINCO = ?";

                com.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = textNome.Text;
                com.Parameters.Add("@codigo", MySqlDbType.VarChar, 45).Value = textCodigo.Text;
                com.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = com.ExecuteReader();

                dr.Read();

             
                textNome.Text = dr.GetString(0);
                textDataNascimento.Text = dr.GetString(1);
                textNomePai.Text = dr.GetString(2);
                textNomeMae.Text = dr.GetString(3);
                cmbSexo.Text = dr.GetString(4);
                textPeso.Text = dr.GetString(5);
                cmbMorto.Text = dr.GetString(6);
                cmbVendida.Text = dr.GetString(7);
                cmbPO.Text = dr.GetString(8);
                cmbRaca.Text = dr.GetString(9);
                cmbTipo.Text = dr.GetString(10);

                Ligar.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("erro de conexão" + erro);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conecta = new MySqlConnection(Conector);

            try
            {
                

                Conecta.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM animal WHERE codigobrinco = ? or nome = ?",Conecta);
                Comando.Parameters.Clear();
                Comando.Parameters.Add("@codigo", MySqlDbType.VarChar, 45).Value = textCodigo.Text;
                Comando.Parameters.Add("@nome", MySqlDbType.VarChar, 85).Value = textNome.Text;

                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                MessageBox.Show("Registro removido !");
                Conecta.Close();





            }catch(Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }


        }
    }
}
