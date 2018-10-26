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
    public partial class ListagemPropriedades : Form
    {
        public ListagemPropriedades()
        {
            InitializeComponent();


         



            DLL dll = new DLL();
            try
            {

                dataGridPropriedades.DataSource = dll.ExibirDadosDalPropriedades();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }




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
