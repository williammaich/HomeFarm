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
    public partial class CadastrosUserControl1 : UserControl
    {
        public CadastrosUserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroAnimais_Click(object sender, EventArgs e)
        {
            cadastroAnimaisUserControl11.BringToFront();
        }

        private void cadastroAnimaisUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            cadastroFuncionarioUserControl11.BringToFront();
        }

        private void btnCadastroRaca_Click(object sender, EventArgs e)
        {
            cadastroRacaUserControl11.BringToFront();
        }

        private void cadastroRacaUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void cadastroTipo_Click(object sender, EventArgs e)
        {
            cadastroTipoUserControl11.BringToFront();
        }
    }
}
