﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarmSD
{
    public partial class ListagemCamposUserControl1 : UserControl
    {
        public ListagemCamposUserControl1()
        {
            InitializeComponent();
        }

        private void btnConecta_Click(object sender, EventArgs e)
        {
            ClassDLL dll = new ClassDLL();
            try
            {

                dataGridCampos.DataSource = dll.ExibirDadosDalCampo();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }
        }

        private void ListagemCamposUserControl1_Load(object sender, EventArgs e)
        {
            ClassDLL dll = new ClassDLL();
            try
            {

                dataGridCampos.DataSource = dll.ExibirDadosDalCampo();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }

        }
    }
}
