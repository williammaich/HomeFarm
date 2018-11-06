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
    public partial class TelaRelatorioPropriedade : Form
    {
        public TelaRelatorioPropriedade()
        {
            InitializeComponent();
        }

        private void TelaRelatorioPropriedade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'homefarmDataSet3.propriedade'. Você pode movê-la ou removê-la conforme necessário.
            this.propriedadeTableAdapter.Fill(this.homefarmDataSet3.propriedade);

            this.reportViewer1.RefreshReport();
        }
    }
}
