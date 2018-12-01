using HomeFarm.Calendario;
using HomeFarm.Controle;
using HomeFarm.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Views
{
    public partial class MenuFunc : Form
    {
        public MenuFunc()
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


      



  


    

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MenuControle controle = new MenuControle();
            controle.Show();
            
        }

        private void ImgCadastros_Click_1(object sender, EventArgs e)
        {
            TelaCadastros Cadastros = new TelaCadastros();
            Cadastros.Show();
            
        }

        private void ImgListagem_Click_1(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.Show();
            
        }

        private void ImgProducao_Click(object sender, EventArgs e)
        {
            TelaProducao prod = new TelaProducao();
            prod.Show();
            
        }

        private void ImgEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.Show();
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            CalendarioAgenda cal = new CalendarioAgenda();
            cal.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AplicacaoMedicamento aplicacao = new AplicacaoMedicamento();
            aplicacao.Show();
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            MenuControle controle = new MenuControle();
            controle.Show();
           
        }
    }


}


