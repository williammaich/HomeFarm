using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarmSD
{
    public partial class ListagemUserControl1 : UserControl
    {
        public ListagemUserControl1()
        {
            InitializeComponent();

            listagemHomeUserControl11.BringToFront();
        }

        private void ListagemUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnProducaoBovinos_Click(object sender, EventArgs e)
        {
            listagemBovinoUserControl11.BringToFront();
        }

        private void btnProducaoEquinos_Click(object sender, EventArgs e)
        {
            listagemEquinoUserControl11.BringToFront();
        }

        private void btnProducaoOvinos_Click(object sender, EventArgs e)
        {
            listagemOvinosUserControl11.BringToFront();
        }

        private void btnProducaoSuinos_Click(object sender, EventArgs e)
        {
            listagemSuinoUserControl11.BringToFront();
        }

        private void btnProducaoCampos_Click(object sender, EventArgs e)
        {
            listagemCamposUserControl11.BringToFront();
        }
    }
}
