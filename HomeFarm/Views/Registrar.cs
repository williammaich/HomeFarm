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
using System.Security.Cryptography;

namespace HomeFarm
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();

            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }
          

        


            private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //estabelece conexão com o bando de dados
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            //verificação se a conexão foi ok ele insere os dados se não apresenta erro

            string confirma = "sim";
            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO usuario (NOME, SOBRENOME, LOGIN, SENHA,ADMIN) VALUES (@Nome, @Sobrenome, @Login, @Senha,@Adm)", Conexao);
                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                
              

                if(txtEmail.Text == txtCEmail.Text)
                {
                    INSERT.Parameters.AddWithValue("@Login", txtEmail.Text);
                    if (txtSenha.Text == txtCSenha.Text)
                    {
                        INSERT.Parameters.AddWithValue("@Senha", txtSenha.Text);
                        INSERT.Parameters.AddWithValue("@Adm", confirma.ToString());




                        INSERT.ExecuteNonQuery();
                        Conexao.Close();

                        MessageBox.Show("seu cadastro foi concluido");
                        
                    }
                    else
                    {
                        MessageBox.Show(" Senha não conferem");
                    }
                }
                else
                {
                    MessageBox.Show("Email ou Senha não conferem");
                }

            }catch
            {


                MessageBox.Show("ERRO DE CONEXÃO");

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
            txtSobrenome.Text = " ";
            txtEmail.Text = " ";
            txtCEmail.Text = " ";
            txtSenha.Text = "";
            txtCSenha.Text = "";

            
        }
    }
}
