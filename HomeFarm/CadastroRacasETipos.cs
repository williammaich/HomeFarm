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
    }
}
