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
    public partial class ListagemBovinoUserControl1 : UserControl
    {
        public ListagemBovinoUserControl1()
        {
            InitializeComponent();
        }

        private void dataGridBovino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          


        }

        private void btnConecta_Click(object sender, EventArgs e)
        {
            ClassDLL dll = new ClassDLL();
            try
            {

                dataGridBovino.DataSource = dll.ExibirDadosDal();


            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }
        }
    }
}
