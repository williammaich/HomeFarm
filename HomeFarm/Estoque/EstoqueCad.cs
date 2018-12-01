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

namespace HomeFarm.Estoque
{
    public partial class EstoqueCad : Form
    {
        public EstoqueCad()
        {
            InitializeComponent();

        

            CarregaComboLote();
            CarregaComboPropriedade();
        }


        private void CarregaComboLote()
        {
            comboLote.DataSource = RemedioDALL.RetornaLista();
            comboLote.DisplayMember = "NUMEROLOTE";
            comboLote.ValueMember = "ID";
        }

        private void CarregaComboPropriedade()
        {
            comboPropriedade.DataSource = DALL.RetornaListaPropriedade();
            comboPropriedade.DisplayMember = "LOGRADOURO";
            comboPropriedade.ValueMember = "ID";
        }


      

        private void ImgEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.Show();
            this.Visible = false;
        }

     

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO racao (NOME,TIPO,QUANTIDADE,DESCRICAO,LOTE_ID,VALOR,PROPRIEDADE_ID) VALUES (@nome,@tipo,@quantidade,@descricao, @lote,@valor,@propriedade)", Conexao);


                INSERT.Parameters.AddWithValue("@nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@tipo", txtTipo.Text);
                INSERT.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                INSERT.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                INSERT.Parameters.Add("@lote", MySqlDbType.VarChar, 45).Value = comboLote.SelectedValue.ToString();
                INSERT.Parameters.AddWithValue("@valor", txtValor.Text);
                INSERT.Parameters.Add("@propriedade", MySqlDbType.VarChar, 45).Value = comboPropriedade.SelectedValue.ToString();

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

                txtNome.Text = "";

                txtTipo.Text = "";
                txtQuantidade.Text = "";
                txtDescricao.Text = "";

                txtValor.Text = "";

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro de conexão!!" + erro);
            }

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboPropriedade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
