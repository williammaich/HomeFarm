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
    public partial class TelaProducao : Form
    {
        public TelaProducao()
        {
            InitializeComponent();

           
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImgImgListagem_Click(object sender, EventArgs e)
        {
            ProducaoListagem listagem = new ProducaoListagem();
            listagem.Show();
            this.Visible = false;
        }

        private void ImgCadProd_Click(object sender, EventArgs e)
        {
            ProducaoCad cad = new ProducaoCad();
            cad.Show();
            this.Visible = false;
        }

        private void ImgMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgLogo_Click(object sender, EventArgs e)
        {

        }

        private void TelaProducao_Load(object sender, EventArgs e)
        {

        }
    }
}
