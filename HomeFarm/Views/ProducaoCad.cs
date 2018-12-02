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
    public partial class ProducaoCad : Form
    {
        public ProducaoCad()
        {
            InitializeComponent();
/*
            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;
            ImgMax.Parent = ImgLogo;
            ImgMax.BackColor = Color.Transparent; 
            */
            
          

            CarregaComboAnimal();

        }


        private void CarregaComboAnimal()
        {
            comboAnimal.DataSource = AnimalDALL.RetornaListaAnimal();
            comboAnimal.DisplayMember = "NOME";
            comboAnimal.ValueMember = "ID";
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);


            try
            {
                Conexao.Open();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO producao (DATAREALIZADA,QUANTIDADE,DATADECADASTRO,DATAALTERACAO,OBSERVACAO,VALOR,ANIMAL_ID) VALUES (@datar,@quantidade,@datac,@dataa, @observacao,@valor,@animal)", Conexao);


                INSERT.Parameters.AddWithValue("@datar", this.dateTimeRealizada.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                INSERT.Parameters.AddWithValue("@datac", this.dateTimeDatacadastro.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@dataa", DateTime.Now.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                INSERT.Parameters.AddWithValue("@valor", txtValor.Text);
                INSERT.Parameters.Add("@animal", MySqlDbType.VarChar, 45).Value = comboAnimal.SelectedValue.ToString();

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

             
                txtQuantidade.Text = "";
               
                
                txtObservacao.Text = "";

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro de conexão!!" + erro);
            }


            }

        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
        
            txtQuantidade.Text = "";
          
            txtObservacao.Text = "";
        }

        private void ImgProducao_Click(object sender, EventArgs e)
        {
            TelaProducao prod = new TelaProducao();
            prod.Show();
            this.Visible = false;
        }
    }
}
