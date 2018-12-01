﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm
{
    public partial class ListagemAnimais : Form
    {
        public ListagemAnimais()
        {
            InitializeComponent();

       



            DLL dll = new DLL();
            try
            {

                dataGridAnimais.DataSource = dll.ExibirDadosDal();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }

        }

       

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.Show();
            this.Visible = false;
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
