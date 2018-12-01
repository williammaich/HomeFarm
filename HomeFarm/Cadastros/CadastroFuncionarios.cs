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
    public partial class CadastroFuncionarios : Form
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();

            comboAdm.Items.Add("Sim");
            comboAdm.Items.Add("Não");

          

              /*
            
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ("server=localhost; userid=root; database=homefarm; SslMode=none");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "SELECT ID,LOGRADOURO FROM PROPRIEDADE";
            MySqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboPropriedade.ValueMember = "ID";
            comboPropriedade.DisplayMember = "LOGRADOURO";
            comboPropriedade.DataSource = dt;
            */


            CarregaComboPropriedade();
            
            /*
            comboPropriedade.Items.Add  ("Vila Pantanoso");
            comboPropriedade.Items.Add  ("Cerro do estado");
            comboPropriedade.Items.Add  ("Cerro das almas");
            comboPropriedade.Items.Add  ("Pavão");
            comboPropriedade.Items.Add  ("Vila Ferreira");
            comboPropriedade.Items.Add  ("Vila Florida");
            */
        }


        private void CarregaComboPropriedade()
        {
            comboPropriedade.ValueMember = "ID";
            comboPropriedade.DisplayMember = "LOGRADOURO";
            
            comboPropriedade.DataSource = DALL.RetornaListaPropriedade();
        }

    
      

        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros cad = new TelaCadastros();
            cad.Show();
            this.Visible = false;
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conexao = new MySqlConnection(Conection);

            //verificação se a conexão foi ok ele insere os dados se não apresenta erro
            try
            {
                Conexao.Open();

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO usuario (NOME, SOBRENOME, LOGIN, SENHA,ADMIN,PROPRIEDADE_ID) VALUES (@Nome, @Sobrenome, @Login, @Senha, @Admin,@Propriedade)", Conexao);
                INSERT.Parameters.AddWithValue("@Nome", txtNome.Text);
                INSERT.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);



                if (txtEmail.Text == txtCEmail.Text)
                {
                    INSERT.Parameters.AddWithValue("@Login", txtEmail.Text);
                    if (txtSenha.Text == txtCSenha.Text)
                    {
                        INSERT.Parameters.AddWithValue("@Senha", txtSenha.Text);

                        INSERT.Parameters.Add("@Admin", MySqlDbType.VarChar, 45).Value = comboAdm.SelectedItem.ToString();



                        INSERT.Parameters.Add("@Propriedade", MySqlDbType.VarChar, 45).Value = comboPropriedade.SelectedValue.ToString();

                        INSERT.ExecuteNonQuery();
                        Conexao.Close();

                        MessageBox.Show("seu cadastro foi concluido");

                        txtNome.Text = " ";
                        txtSobrenome.Text = " ";
                        txtEmail.Text = " ";
                        txtCEmail.Text = " ";
                        txtSenha.Text = "";
                        txtCSenha.Text = "";
                        comboAdm.Text = " ";
                        comboPropriedade.Text = " ";
                    }
                    else
                    {
                        MessageBox.Show(" Senha não conferem");
                    }
                }
                else
                {
                    MessageBox.Show("Email ou Senha não conferem");
                }

            }
            catch(Exception erro)
            {


                MessageBox.Show("ERRO DE CONEXÃO" + erro);

            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
            txtSobrenome.Text = " ";
            txtEmail.Text = " ";
            txtCEmail.Text = " ";
            txtSenha.Text = "";
            txtCSenha.Text = "";
            comboAdm.Text = " ";
            comboPropriedade.Text = " ";
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conecta = new MySqlConnection(Conector);
            try
            {
                Conecta.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE usuario SET NOME=?,SOBRENOME=?,LOGIN=?,SENHA=?,ADMIN=?,PROPRIEDADE=? WHERE ID", Conecta);

                comando.Parameters.Clear();



                
                comando.Parameters.Add("@nome", MySqlDbType.VarChar, 85).Value = txtNome.Text;
                comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar, 45).Value = txtSobrenome.Text;
                comando.Parameters.Add("@login", MySqlDbType.VarChar, 85).Value = txtEmail.Text;
                comando.Parameters.Add("@senha", MySqlDbType.VarChar, 85).Value = txtSenha.Text;
                comando.Parameters.Add("@admin", MySqlDbType.VarChar, 45).Value = comboAdm.SelectedItem.ToString();
                comando.Parameters.Add("@propriedade", MySqlDbType.VarChar, 45).Value = comboPropriedade.SelectedValue.ToString();



                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();

                Conecta.Close();
                MessageBox.Show("Atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO DE CONEXÃO " + erro);
            }

        }

        private void ImgRaca_Click(object sender, EventArgs e)
        {
            CadastroRacasETipos raca = new CadastroRacasETipos();
            raca.Show();
            this.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Conecta = new MySqlConnection(Conector);

            try
            {


                Conecta.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM usuario WHERE nome = ? or login = ?", Conecta);
                Comando.Parameters.Clear();
                
                Comando.Parameters.Add("@nome", MySqlDbType.VarChar, 85).Value = txtNome.Text;
                Comando.Parameters.Add("@login", MySqlDbType.VarChar, 45).Value = txtEmail.Text;
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                MessageBox.Show("Registro removido !");
                Conecta.Close();

                txtNome.Text = " ";
                txtSobrenome.Text = " ";
                txtEmail.Text = " ";
                txtCEmail.Text = " ";
                txtSenha.Text = "";
                txtCSenha.Text = "";
                comboAdm.Text = " ";
                comboPropriedade.Text = " ";



            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }

        }

        private void ImgProcurar_Click(object sender, EventArgs e)
        {
            String Conector = "server=localhost; userid=root; database=homefarm; SslMode=none";
            MySqlConnection Ligar = new MySqlConnection(Conector);
            try
            {
                Ligar.Open();

                MySqlCommand com = new MySqlCommand();
                com.Connection = Ligar;
                com.CommandText = "SELECT ID,NOME,SOBRENOME,LOGIN,SENHA,ADMIN,PROPRIEDADE_ID FROM usuario WHERE NOME= ? OR LOGIN = ?";

                com.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                com.Parameters.Add("@login", MySqlDbType.VarChar, 80).Value = txtEmail.Text;
                com.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = com.ExecuteReader();

                dr.Read();


                
                txtNome.Text = dr.GetString(1);
                txtSobrenome.Text = dr.GetString(2);
                txtEmail.Text = dr.GetString(3);
                txtCEmail.Text = dr.GetString(3);
                txtSenha.Text = dr.GetString(4);
                txtCSenha.Text = dr.GetString(4);
                comboAdm.Text = dr.GetString(5);
                comboPropriedade.Text = dr.GetString(6); 
                



                Ligar.Close();
            }
            catch 
            {

                MessageBox.Show("Registro não encontrado!!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CadastroPropriedades cadPropriedades = new CadastroPropriedades();
            cadPropriedades.Show();
            this.Visible = false;
        }

       
    }
}