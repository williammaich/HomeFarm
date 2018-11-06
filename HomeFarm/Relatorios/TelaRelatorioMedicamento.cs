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
    public partial class TelaRelatorioMedicamento : Form
    {
        public TelaRelatorioMedicamento()
        {
            InitializeComponent();
        }

        private void TelaRelatorioMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'homefarmDataSet3.medicamento'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentoTableAdapter.Fill(this.homefarmDataSet3.medicamento);

            this.reportViewer1.RefreshReport();
        }
    }
}
