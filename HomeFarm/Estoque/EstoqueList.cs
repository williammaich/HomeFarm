using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Estoque
{
    public partial class EstoqueList : Form
    {
        public EstoqueList()
        {
            InitializeComponent();

          


            DLL dll = new DLL();
            try
            {

                dataGridRacao.DataSource = dll.ExibirDadosDalRacao();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }

        }



        private void ImgListagem_Click(object sender, EventArgs e)
        {
            TelaEstoque estoque = new TelaEstoque();
            estoque.Show();
            this.Visible = false;


        }
    }
}
