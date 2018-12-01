using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeFarm.Clases;
using MySql.Data.MySqlClient;

namespace HomeFarm.Views
{
    public partial class AplicacaoMedicamento : Form
    {
        public AplicacaoMedicamento()
        {
            InitializeComponent();

            txtDataAplicacao.Text =  DateTime.Now.ToString("dd/MM/yyyy");

            CarregaComboFuncionario();
            CarregaComboMedicamento();
            CarregaComboAnimal();
        }


        private void CarregaComboFuncionario()
        {
            comboFuncionario.DataSource = FuncionarioDall.RetornaListaFuncionario();
            comboFuncionario.DisplayMember = "NOME";
            comboFuncionario.ValueMember = "ID";
        }

        private void CarregaComboMedicamento()
        {
            comboMedicamento.DataSource = MedicamentoDall.RetornaListaMedicamento();
            comboMedicamento.DisplayMember = "NOME";
            comboMedicamento.ValueMember = "ID";
        }

        private void CarregaComboAnimal()
        {
            comboAnimal.DataSource = AnimalDALL.RetornaListaAnimal();
            comboAnimal.DisplayMember = "NOME";
            comboAnimal.ValueMember = "ID";
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            //verificação se a conexão foi ok ele insere os dados se não apresenta erro
            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO aplicacao_medicamento (DATAAPLICACAO, QUANTIDADE, OBSERVACAO, USUARIO_ID,MEDICAMENTO_ID,CARENCIA,ANIMAL_ID) VALUES (@Dataa, @Quantidade, @Obs, @CFuncionario, @CMedicamento,@Carencia, @CAnimal)", Conexao);
                INSERT.Parameters.AddWithValue("@Dataa", DateTime.Now.ToString("dd/MM/yyyy"));
                INSERT.Parameters.AddWithValue("@Quantidade", txtQuantidade.Text);
                INSERT.Parameters.AddWithValue("@Obs", txtObs.Text);
                INSERT.Parameters.AddWithValue("@CFuncionario", comboFuncionario.SelectedValue.ToString());
                INSERT.Parameters.AddWithValue("@CMedicamento", comboMedicamento.SelectedValue.ToString());
                INSERT.Parameters.AddWithValue("@Carencia", txtCarencia.Text);
                INSERT.Parameters.AddWithValue("@CAnimal", comboAnimal.SelectedValue.ToString());

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

                txtQuantidade.Text = "";
                txtObs.Text = "";
                comboFuncionario.Text = "";
                comboMedicamento.Text = "";
                txtCarencia.Text = "";
                comboAnimal.Text = "";
                // txtDataCadastro.Text = "";

            }
            catch
            {
                MessageBox.Show("erro de conexao");

            }
        }

        private void txtCSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboAdm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros cad = new TelaCadastros();
            cad.Show();
            this.Visible = false;
        }
    }
}
