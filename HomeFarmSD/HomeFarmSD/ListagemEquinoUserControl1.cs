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
    public partial class ListagemEquinoUserControl1 : UserControl
    {
        public ListagemEquinoUserControl1()
        {
            InitializeComponent();
        }

        private void btnConecta_Click(object sender, EventArgs e)
        {
            ClassDLL dll = new ClassDLL();
            try
            {

                dataGridEquino.DataSource = dll.ExibirDadosDalEquino();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }
        }
    }
}
