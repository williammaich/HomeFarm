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
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO animal (CODIFOBRINCO,NOME,DATANAC,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA,PO,BOVINO,EQUINO,SUINO,OVINO) VALUES (@codigo,@nome,@datanasc,@nomepai, @nomemae,@sexo,@peso,@morto,@vendida,@po,@bovino,@equino,@suino,@suino )", Conexao);

                INSERT.Parameters.AddWithValue("@codigo", textCodigo.Text);
                INSERT.Parameters.AddWithValue("@nome", textNome.Text);
                INSERT.Parameters.AddWithValue("@datanasc", textDataNascimento.Text);
                INSERT.Parameters.AddWithValue("@nomepai", textNomePai.Text);
                INSERT.Parameters.AddWithValue("@nomemae", textNomeMae.Text);
                if (radioButtonMasculino.Checked)
                {

                    INSERT.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "Masculino";

                }else if (radioButtonFeminino.Checked)
                {
                    INSERT.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "Feminino";
                }

                INSERT.Parameters.AddWithValue("@peso", textPeso.Text);

                if (radioButtonSimMorto.Checked)
                {
                    INSERT.Parameters.Add("@morto", MySqlDbType.VarChar, 1).Value = "Vivo";
                }else if (radioButtonNaoMorto.Checked)
                {
                    INSERT.Parameters.Add("@morto", MySqlDbType.VarChar, 1).Value = "Morto";
                }

                if (radioButtonVendidaSim.Checked)
                {
                    INSERT.Parameters.Add("@vendida", MySqlDbType.VarChar, 1).Value = "Vendida";
                } else if (radioButtonVendidaNao.Checked)
                {
                    INSERT.Parameters.Add("@vendida", MySqlDbType.VarChar, 1).Value = "Não vendida";
                }

                if (radioButtonPOsim.Checked)
                {
                    INSERT.Parameters.Add("@po", MySqlDbType.VarChar, 1).Value = "Puro";
                }else if (radioButtonPOnao.Checked)
                {
                    INSERT.Parameters.Add("@po", MySqlDbType.VarChar, 1).Value = "naoPuro";
                }

                if (radioButtonBovino.Checked)
                {
                    INSERT.Parameters.Add("@bovino", MySqlDbType.VarChar, 1).Value = "Bovino";
                }else if (radioButtonEquino.Checked)
                {
                    INSERT.Parameters.Add("@equino", MySqlDbType.VarChar, 1).Value = "Equino";
                }else if (radioButtonSuino.Checked)
                {
                    INSERT.Parameters.Add("@suino", MySqlDbType.VarChar, 1).Value = "Suino";
                }else if (radioButtonOvino.Checked)
                {
                    INSERT.Parameters.Add("@ovino", MySqlDbType.VarChar, 1).Value = "Ovino";
                }




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
