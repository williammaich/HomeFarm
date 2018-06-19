﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarmSD
{
    public partial class TelaPrincipalSIS : Form
    {
        public TelaPrincipalSIS()
        {
            InitializeComponent();
            PainelDeslisante.Height = btnHome.Height;
            PainelDeslisante.Top = btnHome.Top;
            homeUserControl11.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnHome.Height;
            PainelDeslisante.Top = btnHome.Top;
            homeUserControl11.BringToFront(); 
        }

     
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnCadastros.Height;
            PainelDeslisante.Top = btnCadastros.Top;
            cadastrosUserControl11.BringToFront();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnEstoque.Height;
            PainelDeslisante.Top = btnEstoque.Top;
            estoqueUserControl11.BringToFront();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnRelatorios.Height;
            PainelDeslisante.Top = btnRelatorios.Top;
            relatoriosUserControl11.BringToFront();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnConfiguracao.Height;
            PainelDeslisante.Top = btnConfiguracao.Top;
            configuracoesUserControl11.BringToFront();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnProducao.Height;
            PainelDeslisante.Top = btnProducao.Top;
            producaoUserControl11.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnListagem.Height;
            PainelDeslisante.Top = btnListagem.Top;
            listagemUserControl11.BringToFront();
        }
    }
}
