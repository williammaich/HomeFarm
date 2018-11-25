﻿using HomeFarm.Calendario;
using HomeFarm.Controle;
using HomeFarm.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Views
{
    public partial class MenuFunc : Form
    {
        public MenuFunc()
        {
         


            InitializeComponent();

            DLL dll = new DLL();
            try
            {

                dataAgenda.DataSource = dll.ExibirDadosDalAgenda();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }

        }


        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros Cadastros = new TelaCadastros();
            Cadastros.Show();
            this.Visible = false;

        }

        private void ImgListagem_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.Show();
            this.Visible = false;
        }

        private void ImgProducao_Click(object sender, EventArgs e)
        {
            TelaProducao prod = new TelaProducao();
            prod.Show();
            this.Visible = false;
        }

     
        private void ImgEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AplicacaoMedicamento aplicacao = new AplicacaoMedicamento();
            aplicacao.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            CalendarioAgenda cal = new CalendarioAgenda();
            cal.Show();
            this.Visible = false;




        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MenuControle controle = new MenuControle();
            controle.Show();
            this.Visible = false;
        }
    }


}


