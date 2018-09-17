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
    public partial class CadastroRacasETipos : Form
    {
        public CadastroRacasETipos()
        {
            InitializeComponent();

            ImgFechar.Parent = pictureBox1;
            ImgFechar.BackColor = Color.Transparent;
            ImgMinimizar.Parent = pictureBox1;
            ImgMinimizar.BackColor = Color.Transparent;

        }

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            CadastroAnimais cadastro = new CadastroAnimais();
            cadastro.Show();
            this.Visible = false;
        }

        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros tela = new TelaCadastros();
            tela.Show();
            this.Visible = false;
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();

        }
    }
}
