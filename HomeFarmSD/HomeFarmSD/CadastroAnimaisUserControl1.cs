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
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO animal (CODIFOBRINCO,NOME,DATANAC,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA) VALUES (@codigo,@nome,@datanasc,@nomepai, @nomemae,@sexo,@peso,@morto,@vendida)", Conexao);

                INSERT.Parameters.AddWithValue("@codigo", textCodigo.Text);
                INSERT.Parameters.AddWithValue("@nome", textNome.Text);
                INSERT.Parameters.AddWithValue("@datanasc", textDataNascimento.Text);
                INSERT.Parameters.AddWithValue("@nomepai", textNomePai.Text);
                INSERT.Parameters.AddWithValue("@nomemae", textNomeMae.Text);

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");
            }
            catch
            {


                MessageBox.Show("ERRO DE CONEXÃO");

            }

        }
    }
}
