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
    public partial class ProducaoUserControl1 : UserControl
    {
        public ProducaoUserControl1()
        {
            InitializeComponent();
            producaoHomeUserControl11.BringToFront();
        }

        private void btnProducaoCampos_Click(object sender, EventArgs e)
        {
            producaoCamposUserControl11.BringToFront();
        }

        private void btnProducaoBovinos_Click(object sender, EventArgs e)
        {
            producaoBovinosUserControl11.BringToFront();
        }

        private void btnProducaoEquinos_Click(object sender, EventArgs e)
        {
            producaoEquinosUserControl11.BringToFront();
        }

        private void btnProducaoOvinos_Click(object sender, EventArgs e)
        {
            producaoOvinosUserControl11.BringToFront();
        }

        private void btnProducaoSuinos_Click(object sender, EventArgs e)
        {
            producaoSuinosUserControl11.BringToFront();
        }
    }
}
