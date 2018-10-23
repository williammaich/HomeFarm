using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Estoque
{
    public partial class TelaEstoque : Form
    {
        public TelaEstoque()
        {
            InitializeComponent();

            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;

        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }

        private void ImgCadEstoque_Click(object sender, EventArgs e)
        {
            EstoqueCad cadastro = new EstoqueCad();
            cadastro.Show();
            this.Visible = false;
        }

        private void ImgImgListagem_Click(object sender, EventArgs e)
        {
            EstoqueList lista = new EstoqueList();
            lista.Show();
            this.Visible = false;
        }
    }
}
