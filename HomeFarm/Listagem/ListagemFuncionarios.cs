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
    public partial class ListagemFuncionarios : Form
    {
        public ListagemFuncionarios()
        {
            InitializeComponent();

       

            DLL dll = new DLL();
            try
            {

                dataGridFuncionarios.DataSource = dll.ExibirDadosDalFuncionario();


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Listagem lista = new Listagem();
            lista.Show();
            this.Visible = false;
        }

     

        private void ImgProcurar_Click(object sender, EventArgs e)
        {

        }
    }
}
