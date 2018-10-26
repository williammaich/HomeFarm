using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeFarm.Relatorios;

namespace HomeFarm
{
    public partial class TelaRelatorios : Form
    {
        public TelaRelatorios()
        {
            InitializeComponent();

           
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            TelaRelatorioAnimais animais = new TelaRelatorioAnimais();
            animais.Show();
            this.Visible = false;
        }

        private void ImgFuncionarios_Click(object sender, EventArgs e)
        {
            TelaRelatorioUsuario relatorio = new TelaRelatorioUsuario();
            relatorio.Show();
            this.Visible = false;
        }
    }
}
