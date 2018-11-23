using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Graficos
{
    public partial class MenuGraficos : Form
    {
        public MenuGraficos()
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
            GrafAnimais animais = new GrafAnimais();
            animais.Show();
            this.Visible = false;
        }
    }
}
