using System;
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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

       

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            ListagemAnimais listaAnimais = new ListagemAnimais();
            listaAnimais.Show();
            this.Visible = false;

        }

      

        private void ImgFuncionarios_Click(object sender, EventArgs e)
        {
            ListagemFuncionarios listafun = new ListagemFuncionarios();
            listafun.Show();
            this.Visible = false;

        }


        private void ImgRemedios_Click(object sender, EventArgs e)
        {
            ListagemRemedios listaRemedios = new ListagemRemedios();
            listaRemedios.Show();
            this.Visible = false;
        }

        private void ImgCampos_Click(object sender, EventArgs e)
        {
            ListagemPropriedades propriedades = new ListagemPropriedades();
            propriedades.Show();
            this.Visible = false;

        }
    }
}
