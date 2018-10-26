using HomeFarm.Estoque;
using HomeFarm.Views;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

        
        }

  

        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros Cadastros = new TelaCadastros();
            Cadastros.Show();
            this.Visible = false;

        }

        private void ImgListagem_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.Show();
            this.Visible = false;
        }

        private void ImgProducao_Click(object sender, EventArgs e)
        {
            TelaProducao prod = new TelaProducao();
            prod.Show();
            this.Visible = false;
        }

        private void ImgRelatorios_Click(object sender, EventArgs e)
        {
            TelaRelatorios relatorios = new TelaRelatorios();
            relatorios.Show();
            this.Visible = false;

        }

        private void ImgEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AplicacaoMedicamento aplicacao = new AplicacaoMedicamento();
            aplicacao.Show();
            this.Visible = false;
        }
    }
}
