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
    public partial class ProducaoListagem : Form
    {
        public ProducaoListagem()
        {
            InitializeComponent();

            ImgFechar.Parent = ImgLogo;
            ImgFechar.BackColor = Color.Transparent;

            ImgMinimizar.Parent = ImgLogo;
            ImgMinimizar.BackColor = Color.Transparent;


            DLL dll = new DLL();
            try
            {
                dataGridProducao.DataSource = dll.ExibirDadosDalProducao();
            }
            catch(Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal Menu = new MenuPrincipal();
            Menu.Show();
            this.Visible = false;
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
      
        }
    }
}
