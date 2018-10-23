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
    public partial class ListagemRemedios : Form
    {
        public ListagemRemedios()
        {
            InitializeComponent();




            DLL dll = new DLL();
            try
            {

                dataGridRemedios.DataSource = dll.ExibirDadosDalEstoque();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }
        }

        private void ListagemRemedios_Load(object sender, EventArgs e)
        {

        }

        private void ImgHome_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Visible = false;

        }

        private void ImgListagem_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.Show();
            this.Visible = false;
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
