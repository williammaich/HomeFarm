﻿using System;
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


    public partial class CadastroLote : Form
    {
     
      

        public CadastroLote()
        {
            InitializeComponent();
            

           
            


        }

        private void ImgRemedios_Click(object sender, EventArgs e)
        {
            CadastroRemedios remedio = new CadastroRemedios();
            remedio.Show();
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

                MySqlCommand INSERT = new MySqlCommand("INSERT INTO lote (NUMEROLOTE, DATAFABRICACAO, DATAVALIDADE, OBSERVACAO,DATACADASTRO,DATAALTERACAO) VALUES (@Numero, @DataFab, @DataVal, @Obs, @DataCad,@Dataa)", Conexao);
                INSERT.Parameters.AddWithValue("@Numero", txtNLote.Text);
                INSERT.Parameters.AddWithValue("@DataFab", this.DataFabricacao.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@DataVal", this.dataValidade.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@Obs", txtObservacao.Text);            
                INSERT.Parameters.AddWithValue("@DataCad", this.dataCadastro.Value.ToString("yyyy/MM/dd"));
                INSERT.Parameters.AddWithValue("@Dataa",DateTime.Now.ToString("yyyy/MM/dd"));

                INSERT.ExecuteNonQuery();
                Conexao.Close();

                MessageBox.Show("Cadastro Realizado com Sucesso!!");

                txtNLote.Text = "";
               
                txtObservacao.Text = "";
               // txtDataCadastro.Text = "";
                
            }
            catch
            {
                MessageBox.Show("erro de conexao");

            }
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
