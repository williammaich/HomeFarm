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


namespace HomeFarmSD
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Cnexao = new MySqlConnection(Conection);

            try
            {
                Cnexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO usuario (NOME, SOBRENOME, LOGIN, SENHA) VALUES (@Nome, @Sobrenome, @Login, @Senha)", Cnexao);
                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                INSERT.Parameters.AddWithValue("@Login", txtEmail.Text);
                INSERT.Parameters.AddWithValue("@Senha", txtSenha.Text);
              
                

                if (txtEmail.Text == txtConfirmarEmail.Text )
                {

                    INSERT.ExecuteNonQuery();
                    Cnexao.Close();

                    MessageBox.Show("seu cadastro foi concluido");
                    TelaLogin volta = new TelaLogin();
                    volta.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Email não confere");
                }

                
                

            }
            catch
            {


                MessageBox.Show("ERRO DE CONEXÃO");

            }


        }
    }
    }

