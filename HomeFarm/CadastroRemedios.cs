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

            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;

            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            //verificação se a conexão foi ok ele insere os dados se não apresenta erro
            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO medicamento (NOME, DESCRICAO, ESTOCADO, LOTE_ID) VALUES (@Nome, @Descricao, @Estocado, @Obs, @loteid)", Conexao);
                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                INSERT.Parameters.AddWithValue("@Estocado", txtEstocado.Text);
                INSERT.Parameters.Add("@Loteid", MySqlDbType.VarChar, 45).Value = comboLote.SelectedItem.ToString();


                INSERT.ExecuteNonQuery();
                Conexao.Close();

                txtNome.Text = "";
                txtDescricao.Text = "";
                txtEstocado.Text = "";
                comboLote.Text = "";
              

            }
            catch
            {
                MessageBox.Show("erro de conexao");

            }
        }
    }
}
