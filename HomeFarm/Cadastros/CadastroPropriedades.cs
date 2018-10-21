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
    public partial class CadastroPropriedades : Form
    {
        public CadastroPropriedades()
        {
            InitializeComponent();

            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaCadastros cad = new TelaCadastros();
            cad.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO propriedade (CEP,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,ESTADO) VALUES (@cep,@logradouro,@numero,@complemento, @bairro,@cidade,@estado )", Conexao);

                INSERT.Parameters.AddWithValue("@cep", txtCep.Text);
                INSERT.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);

                INSERT.Parameters.AddWithValue("@numero", txtNumero.Text);
                INSERT.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                INSERT.Parameters.AddWithValue("@bairro", txtBairro.Text);
                INSERT.Parameters.AddWithValue("@cidade", txtCidade.Text);
                INSERT.Parameters.AddWithValue("@estado", txtEstado.Text);





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
