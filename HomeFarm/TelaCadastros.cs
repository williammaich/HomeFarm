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
    public partial class TelaCadastros : Form
    {
        public TelaCadastros()
        {
            InitializeComponent();

            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;

            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu  = new MenuPrincipal();
            Menu.Show();
            this.Visible = false;
        }

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            CadastroAnimais CadAnimais = new CadastroAnimais();
            CadAnimais.Show();
            this.Visible = false;
        }

     

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgRaca_Click(object sender, EventArgs e)
        {
            CadastroRacasETipos cadRacasETipos = new CadastroRacasETipos();
            cadRacasETipos.Show();
            this.Visible = false;
        }
    }
}
