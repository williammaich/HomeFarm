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
    public partial class TelaRelatorioRacao : Form
    {
        public TelaRelatorioRacao()
        {
            InitializeComponent();
        }

        private void TelaRelatorioRacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'homefarmDataSet3.racao'. Você pode movê-la ou removê-la conforme necessário.
            this.racaoTableAdapter.Fill(this.homefarmDataSet3.racao);

            this.reportViewer1.RefreshReport();
        }
    }
}
