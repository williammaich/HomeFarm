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
    public partial class Carregamento : Form
    {
        public Carregamento()
        {
            InitializeComponent();
        }

        private void Carregamento_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;


            }



            else
            {
                timer1.Enabled = false; //desativa timer
                                         //Application.Exit(); //encerra aplicação aqui manda para proxima tela




                TelaLogin AbrirForm = new TelaLogin();

                AbrirForm.Show();
                this.Visible = false;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
