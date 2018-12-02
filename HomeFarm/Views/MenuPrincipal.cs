using HomeFarm.Calendario;
using HomeFarm.Controle;
using HomeFarm.Estoque;
using HomeFarm.Graficos;
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

            DLL dll = new DLL();
            try
            {

                dataAgenda.DataSource = dll.ExibirDadosDalAgenda();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }


        }



        private void ImgCadastros_Click(object sender, EventArgs e)
        {
            TelaCadastros Cadastros = new TelaCadastros();
            Cadastros.Show();
            

        }

        private void ImgListagem_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.Show();
            
        }

        private void ImgProducao_Click(object sender, EventArgs e)
        {
            TelaProducao prod = new TelaProducao();
            prod.Show();
       
        }

        private void ImgRelatorios_Click(object sender, EventArgs e)
        {
            TelaRelatorios relatorios = new TelaRelatorios();
            relatorios.Show();
            

        }

        private void ImgEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.Show();
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AplicacaoMedicamento aplicacao = new AplicacaoMedicamento();
            aplicacao.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            CalendarioAgenda cal = new CalendarioAgenda();
            cal.Show();
         


        

        }

        private void ImgConfiguracao_Click(object sender, EventArgs e)
        {
            MenuGraficos menu = new MenuGraficos();
            menu.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MenuControle controle = new MenuControle();
            controle.Show();
           
        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;
        }
    }
}
