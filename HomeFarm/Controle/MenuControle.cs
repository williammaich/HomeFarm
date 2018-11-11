using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Controle
{
    public partial class MenuControle : Form
    {
        public MenuControle()
        {
            InitializeComponent();
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }

        private void ImgBaixas_Click(object sender, EventArgs e)
        {
            TelaBaixas baixas = new TelaBaixas();
            baixas.Show();
            this.Visible = false;
        }

        private void ImgPrenhes_Click(object sender, EventArgs e)
        {
            TelaPrenhes prenhes = new TelaPrenhes();
            prenhes.Show();
            this.Visible = false;
        }
    }
}
