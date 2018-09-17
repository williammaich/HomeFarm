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
    public partial class CadastroRacasETipos : Form
    {
        public CadastroRacasETipos()
        {
            InitializeComponent();

            ImgFechar.Parent = pictureBox1;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = pictureBox1;
            ImgMinimizar.BackColor = Color.Transparent;

           

        }

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            CadastroAnimais cadastro = new CadastroAnimais();
            cadastro.Show();
            this.Visible = false;
        }

        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros tela = new TelaCadastros();
            tela.Show();
            this.Visible = false;
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;

        }

        private void btnRegistrarRaca_Click(object sender, EventArgs e)
        {

            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO raca (NOME, ORIGEM) VALUES (@nome,@origem )", Conexao);

                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@Origem", txtOrigem.Text);

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");
            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO tipo (NOME) VALUES (@nome )", Conexao);

                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }

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
                com.CommandText = "SELECT NOME, ORIGEM FROM raca WHERE NOME= ?";

                com.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                com.Parameters.Add("@codigo", MySqlDbType.VarChar, 45).Value = txtOrigem.Text;
                com.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = com.ExecuteReader();

                dr.Read();

                txtNome.Text = dr.GetString(0);
                txtOrigem.Text = dr.GetString(1);
              
               



                Ligar.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro de conexão" + erro);
            }

        }

        private void btnExcluirRaca_Click(object sender, EventArgs e)
        {

            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conecta = new MySqlConnection(Conector);

            try
            {


                Conecta.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM raca WHERE nome = ?", Conecta);
                Comando.Parameters.Clear();
              
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

        private void ImgBuscar_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Ligar = new MySqlConnection(Conector);
            try
            {
                Ligar.Open();

                MySqlCommand com = new MySqlCommand();
                com.Connection = Ligar;
                com.CommandText = "SELECT TIPO FROM tipo WHERE TIPO= ? ";

                com.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = txtTipo.Text;
               
                com.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = com.ExecuteReader();

                dr.Read();


                txtTipo.Text = dr.GetString(0);
              



                Ligar.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro de conexão" + erro);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conecta = new MySqlConnection(Conector);

            try
            {


                Conecta.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM tipo WHERE tipo = ?", Conecta);
                Comando.Parameters.Clear();

                Comando.Parameters.Add("@tipo", MySqlDbType.VarChar, 85).Value = txtTipo.Text;

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

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
