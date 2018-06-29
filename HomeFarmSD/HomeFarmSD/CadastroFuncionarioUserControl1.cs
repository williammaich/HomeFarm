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
    public partial class CadastroFuncionarioUserControl1 : UserControl
    {
        public CadastroFuncionarioUserControl1()
        {
            InitializeComponent();
            cmbADM.Items.Add("Sim");
            cmbADM.Items.Add("Não");
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

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO usuario (NOME, SOBRENOME, LOGIN, SENHA,ADMIN) VALUES (@Nome, @Sobrenome, @Login, @Senha, @admin)", Cnexao);
                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                INSERT.Parameters.AddWithValue("@Login", txtEmail.Text);
                INSERT.Parameters.AddWithValue("@Senha", txtSenha.Text);
                INSERT.Parameters.AddWithValue("@admin", cmbADM.SelectedItem.ToString());



                if (txtEmail.Text == txtConfirmarEmail.Text)
                {
                    if (txtSenha.Text == txtConfirmarSenha.Text)
                    {
                        INSERT.Parameters.AddWithValue("@Senha", txtSenha.Text);
                        INSERT.ExecuteNonQuery();
                        Cnexao.Close();

                        MessageBox.Show("seu cadastro foi concluido");
                        TelaLogin volta = new TelaLogin();
                        volta.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Senha não confere");
                    }


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

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void cmbADM_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
