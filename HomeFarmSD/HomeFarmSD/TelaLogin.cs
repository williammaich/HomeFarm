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
using MySql.Data;


namespace HomeFarmSD
{
    public partial class TelaLogin : Form
    {
        
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);
            int i;

            if ((textSenha.Text == "admin") && (textEmail.Text == "admin"))
            {
                TelaPrincipalSIS telaSis = new TelaPrincipalSIS();
                telaSis.Show();
                this.Visible = false;
            }
            else {

                try
                {
                    i = 0;
                    Conexao.Open();

                    MySqlCommand com = Conexao.CreateCommand();

                    com.CommandType = CommandType.Text;

                    String palavra = "";
                    int paa;
                    String frase;

                    frase = textSenha.Text;

                    for (int j = 0; j < frase.Length; j++)
                    {
                        int pa = (int)frase[j];
                        paa = pa + 10;

                        if (j % 2 == 1)
                        {
                            palavra += Char.ConvertFromUtf32(paa).ToLower();
                        }
                        else
                        {
                            palavra += Char.ConvertFromUtf32(paa).ToUpper();
                        }

                    }

                   // com.CommandText = "select * from usuario where login='" + textEmail.Text + "' and senha='" + textSenha.Text + "'";
                    com.CommandText = "select * from usuario where login='" + textEmail.Text + "' and senha='" + palavra + "'";
                    com.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(com);
                    da.Fill(dt);

                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("Usuario não encotrado!   Login ou Senha invalidas!");
                    }
                    else
                    {

                        TelaPrincipalSIS telaSis = new TelaPrincipalSIS();
                        telaSis.Show();
                        this.Visible = false;

                    }

                    Conexao.Close();

                }
                catch
                {

              
                
                
                        MessageBox.Show("Login ou Senha invalidas ");
                    }

                
            }




        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           Registrar registro = new Registrar();
            registro.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
