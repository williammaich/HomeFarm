using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Relatorios
{
    public partial class TelaRelatorioAnimais : Form
    {
        public TelaRelatorioAnimais()
        {
            InitializeComponent();

 
        }

        private void TelaRelatorioAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'homefarmDataSet3.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.homefarmDataSet3.animal);

            //this.usuarioTableAdapter.Fill(this.homefarm.usuario);

            this.reportViewerAnimais.RefreshReport();


        }

       
    }
}
