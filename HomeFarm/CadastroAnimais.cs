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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO animal (CODIGOBRINCO,NOME,DATANASCIMENTO,NOMEPAI,NOMEMAE,SEXO,PESO,MORTO,VENDIDA,PO,RACA,TIPO) VALUES (@codigo,@nome,@datanasc,@nomepai, @nomemae,@sexo,@peso,@morto,@vendida,@po,@raca,@tipo )", Conexao);

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




                INSERT.Parameters.Add("@raca",MySqlDbType.VarChar,45).Value =  comboRaca.Text;


                INSERT.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = comboTipo.Text;







                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");
            }
            catch (Exception erro)
            {


                MessageBox.Show("ERRO DE CONEXÃO " + erro);

            }



        }

        private void ImgRaca_Paint(object sender, PaintEventArgs e)
        {
            CadastroRacasETipos raca = new CadastroRacasETipos();
            raca.Show();
            this.Visible = false;

        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
