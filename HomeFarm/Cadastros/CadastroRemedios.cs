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

namespace HomeFarm
{
    public partial class CadastroRemedios : Form
    {
        public CadastroRemedios()
        {
            InitializeComponent();

          

            CarregaComboLote();
            CarregaComboPropriedade();

        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }

        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros cad = new TelaCadastros();
            cad.Show();
            this.Visible = false;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            //verificação se a conexão foi ok ele insere os dados se não apresenta erro
            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO medicamento (NOME, DESCRICAO, ESTOCADO, LOTE_ID,VALOR, PROPRIEDADE_ID) VALUES (@Nome, @Descricao, @Estocado, @Loteid,@Valor, @Propriedadeid)", Conexao);
                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                INSERT.Parameters.AddWithValue("@Estocado", txtEstocado.Text);
                INSERT.Parameters.Add("@Loteid", MySqlDbType.VarChar, 45).Value = comboLote.SelectedValue.ToString();
                INSERT.Parameters.AddWithValue("@Valor", txtValor.Text);
                INSERT.Parameters.Add("@Propriedadeid", MySqlDbType.VarChar, 45).Value = comboPropriedade.SelectedValue.ToString();

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

                txtNome.Text = "";
                txtDescricao.Text = "";
                txtEstocado.Text = "";
                comboLote.Text = "";
              

            }
            catch(Exception erro)
            {
                MessageBox.Show("erro de conexao" + erro);

            }
        }

        private void ImgLote_Click(object sender, EventArgs e)
        {
            CadastroLote lote = new CadastroLote();
            lote.Show();
            this.Visible = false;
        }

    }
}
