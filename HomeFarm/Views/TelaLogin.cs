using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeFarm.Views;
using MySql.Data.MySqlClient;

namespace HomeFarm
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

            ImgFace.Parent = ImgLogin;
            ImgFace.BackColor = Color.Transparent;

            Logo.Parent = ImgLogin;
            Logo.BackColor = Color.Transparent;

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {




            if (admin.Checked ){


                String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
                MySqlConnection Conexao = new MySqlConnection(Conection);
                int i;
                

                if ((txtSenha.Text == "admin") && (txtEmail.Text == "admin"))
                {
                    MenuPrincipal telaSis = new MenuPrincipal();
                    telaSis.Show();
                    this.Visible = false;
                }
                else
                {

                    try
                    {
                       
                        i = 0;

                        Conexao.Open();

                        MySqlCommand com = Conexao.CreateCommand();



                        com.CommandText = "select * from usuario where login='" + txtEmail.Text + "' and senha='" + txtSenha.Text + "' and admin = 'sim';";
                        com.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(com);
                        da.Fill(dt);

                        i = Convert.ToInt32(dt.Rows.Count.ToString());

                        if (i == 0)
                        {

                            MessageBox.Show("Usuario não encotrado!   Login ou Senha invalidas!");

                        }
                        else
                        {






                            /*
                                MenuFunc telaSi = new MenuFunc();
                                telaSi.Show();
                                this.Visible = false;


                                Conexao.Close();
                                */




                            MenuPrincipal telaSis = new MenuPrincipal();
                            telaSis.Show();
                            this.Visible = false;

                            Conexao.Close();
                        }








                    }
                    catch (Exception erro)
                    {




                        MessageBox.Show("Login ou Senha invalidas " + erro);
                    }


                }

            }
            else
            {

                String Conection = "server=localhost; userid=root; database=homefarm; SslMode=none";
                MySqlConnection Conexao = new MySqlConnection(Conection);
                int i;


                if ((txtSenha.Text == "admin") && (txtEmail.Text == "admin"))
                {
                    MenuPrincipal telaSis = new MenuPrincipal();
                    telaSis.Show();
                    this.Visible = false;
                }
                else
                {

                    try
                    {

                        i = 0;

                        Conexao.Open();

                        MySqlCommand com = Conexao.CreateCommand();



                        com.CommandText = "select * from usuario where login='" + txtEmail.Text + "' and senha='" + txtSenha.Text + "' and admin = 'não';";
                        com.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(com);
                        da.Fill(dt);

                        i = Convert.ToInt32(dt.Rows.Count.ToString());

                        if (i == 0)
                        {

                            MessageBox.Show("Usuario não encotrado!   Login ou Senha invalidas!");

                        }
                        else
                        {






                            
                                MenuFunc telaSi = new MenuFunc();
                                telaSi.Show();
                                this.Visible = false;


                                Conexao.Close();
                                
                        }








                    }
                    catch (Exception erro)
                    {




                        MessageBox.Show("Login ou Senha invalidas " + erro);
                    }


                }

            }








        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar Registro = new Registrar();
            Registro.Show();
            
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
