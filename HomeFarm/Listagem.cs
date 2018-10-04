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

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;
        }

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            ListagemAnimais listaAnimais = new ListagemAnimais();
            listaAnimais.Show();
            this.Visible = false;

        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;

        }

        private void ImgFuncionarios_Click(object sender, EventArgs e)
        {
            ListagemFuncionarios listafun = new ListagemFuncionarios();
            listafun.Show();
            this.Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ImgRemedios_Click(object sender, EventArgs e)
        {
            ListagemRemedios lestaRemedios = new ListagemRemedios();
            listaRemedios.Show();
            this.Visible = false;
        }
    }
}
