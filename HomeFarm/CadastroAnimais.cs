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

namespace HomeFarm
{
    public partial class CadastroAnimais : Form
    {
        public CadastroAnimais()
        {
            InitializeComponent();
           ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;

            comboSexo.Items.Add("Macho");
            comboSexo.Items.Add("Femea");


            comboMorto.Items.Add("Sim");
            comboMorto.Items.Add("Não");

            comboVendida.Items.Add("Sim");
            comboVendida.Items.Add("Não");

            comboPo.Items.Add("Sim");
            comboPo.Items.Add("Não");

            CarregaComboRaca();
            CarregaComboTipo();
        }


     

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Visible = false;
        }

        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros Cadastro = new TelaCadastros();
            Cadastro.Show();
            this.Visible = false;
        }


        //carrega combo
        private void CarregaComboRaca()
        {
            comboRaca.DataSource = RacaDAL.RetornaLista();
            comboRaca.DisplayMember = "RACA";
            comboRaca.ValueMember = "ID";
        }

        private void CarregaComboTipo()
        {
            comboTipo.DataSource = DALL.RetornaListaTipo();
            comboTipo.DisplayMember = "TIPOANIMAL";
            comboTipo.ValueMember = "ID";
        }







        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO animal (CODIGOBRINCO,NOME,DATANASCIMENTO,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA,PO) VALUES (@codigo,@nome,@datanasc,@nomepai, @nomemae,@sexo,@peso,@morto,@vendida,@po )", Conexao);

                INSERT.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                INSERT.Parameters.AddWithValue("@nome", txtNome.Text);

                INSERT.Parameters.AddWithValue("@datanasc", txtDataNascimento.Text);
                INSERT.Parameters.AddWithValue("@nomepai", txtNomePai.Text);
                INSERT.Parameters.AddWithValue("@nomemae", txtNomeMae.Text);

                INSERT.Parameters.Add("@sexo", MySqlDbType.VarChar, 45).Value = comboSexo.SelectedItem.ToString();


                INSERT.Parameters.Add("@peso", MySqlDbType.VarChar, 80).Value = txtPeso.Text;


                INSERT.Parameters.Add("@morto", MySqlDbType.VarChar, 45).Value = comboMorto.SelectedItem.ToString();

                INSERT.Parameters.Add("@vendida", MySqlDbType.VarChar, 45).Value = comboVendida.SelectedItem.ToString();

                INSERT.Parameters.Add("@po", MySqlDbType.VarChar, 45).Value = comboPo.SelectedItem.ToString();




                //INSERT.Parameters.Add("@raca",MySqlDbType.VarChar,45).Value =  comboRaca.SelectedItem.ToString();


                //INSERT.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = comboTipo.SelectedItem.ToString();


                //INSERT.Parameters.Add("@propriedade", MySqlDbType.VarChar, 45).Value = comboPropriedade.SelectedItem.ToString();




                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

                


            }
            catch (Exception erro)
            {


                MessageBox.Show("ERRO DE CONEXÃO " + erro);

            }



        }

        private void ImgRaca_Click(object sender, PaintEventArgs e)
        {
            
            

        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void ImgProcurar_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Ligar = new MySqlConnection(Conector);
            try
            {
                Ligar.Open();

                MySqlCommand com = new MySqlCommand();
                com.Connection = Ligar;
                com.CommandText = "SELECT CODIGOBRINCO,NOME,DATANASCIMENTO,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA,PO,RACA_ID,TIPO_ID,PROPRIEDADE_ID FROM animal WHERE NOME= ? OR CODIGOBRINCO = ?";

                com.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                com.Parameters.Add("@codigo", MySqlDbType.VarChar, 45).Value = txtCodigo.Text;
                com.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = com.ExecuteReader();

                dr.Read();


                txtCodigo.Text = dr.GetString(0);
                txtNome.Text = dr.GetString(1);
                txtDataNascimento.Text = dr.GetString(2);
                txtNomePai.Text = dr.GetString(3);
                txtNomeMae.Text = dr.GetString(4);
                comboSexo.Text = dr.GetString(5);
                txtPeso.Text = dr.GetString(6);
                comboMorto.Text = dr.GetString(7);
                comboVendida.Text = dr.GetString(8);
                comboPo.Text = dr.GetString(9);
                comboRaca.Text = dr.GetString(10);
                comboTipo.Text = dr.GetString(11);
                comboPropriedade.Text = dr.GetString(12);



                Ligar.Close();
            }
            catch (Exception erro)
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
                MySqlCommand Comando = new MySqlCommand("DELETE FROM animal WHERE codigobrinco = ? or nome = ?", Conecta);
                Comando.Parameters.Clear();
                Comando.Parameters.Add("@codigo", MySqlDbType.VarChar, 45).Value = txtCodigo.Text;
                Comando.Parameters.Add("@nome", MySqlDbType.VarChar, 85).Value = txtNome.Text;

                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                MessageBox.Show("Registro removido !");
                Conecta.Close();





            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conecta = new MySqlConnection(Conector);
            try
            {
                Conecta.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE animal SET CODIGOBRINCO=?, NOME=?,DATANASCIMENTO=?,NOMEPAI=?,NOMEMAE=?,SEXO=?,PESO=?,MORTO=?,VENDIDA=?,PO=?,RACA_ID=?,TIPO_ID= ?,PROPRIEDADE_ID WHERE ID", Conecta);

                comando.Parameters.Clear();



                comando.Parameters.Add("@codigo", MySqlDbType.VarChar, 45).Value = txtCodigo.Text;
                comando.Parameters.Add("@nome", MySqlDbType.VarChar, 85).Value = txtNome.Text;
                comando.Parameters.Add("@dadanascimento", MySqlDbType.VarChar, 45).Value = txtDataNascimento.Text;
                comando.Parameters.Add("@nomepai", MySqlDbType.VarChar, 85).Value = txtNomePai.Text;
                comando.Parameters.Add("@nomemae", MySqlDbType.VarChar, 85).Value = txtNomeMae.Text;
                comando.Parameters.Add("@sexo", MySqlDbType.VarChar, 45).Value = comboSexo.SelectedItem.ToString();
                comando.Parameters.Add("@peso", MySqlDbType.VarChar, 877).Value = txtPeso.Text;
                comando.Parameters.Add("@morto", MySqlDbType.VarChar, 45).Value = comboMorto.SelectedItem.ToString();
                comando.Parameters.Add("@vendida", MySqlDbType.VarChar, 45).Value = comboVendida.SelectedItem.ToString();
                comando.Parameters.Add("@po", MySqlDbType.VarChar, 45).Value = comboPo.SelectedItem.ToString();
                comando.Parameters.Add("@raca", MySqlDbType.VarChar, 45).Value = comboRaca.SelectedItem.ToString();
                comando.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = comboTipo.SelectedItem.ToString();
                comando.Parameters.Add("@propriedade", MySqlDbType.VarChar, 45).Value = comboTipo.SelectedItem.ToString();

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

        private void ImgRaca_Click(object sender, EventArgs e)
        {
            CadastroRacasETipos raca = new CadastroRacasETipos();
            raca.Show();
            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtNomePai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeMae_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboMorto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
