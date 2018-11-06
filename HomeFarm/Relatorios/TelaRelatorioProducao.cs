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
    public partial class TelaRelatorioProducao : Form
    {
        public TelaRelatorioProducao()
        {
            InitializeComponent();
        }

        private void TelaRelatorioProducao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'homefarmDataSet3.producao'. Você pode movê-la ou removê-la conforme necessário.
            this.producaoTableAdapter.Fill(this.homefarmDataSet3.producao);

            this.reportViewer1.RefreshReport();
        }
    }
}
