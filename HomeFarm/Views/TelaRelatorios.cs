using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeFarm.Relatorios;

namespace HomeFarm
{
    public partial class TelaRelatorios : Form
    {
        public TelaRelatorios()
        {
            InitializeComponent();

           
        }


        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            TelaRelatorioAnimais animais = new TelaRelatorioAnimais();
            animais.Show();
            this.Visible = false;
        }

        private void ImgFuncionarios_Click(object sender, EventArgs e)
        {
            TelaRelatorioUsuario relatorio = new TelaRelatorioUsuario();
            relatorio.Show();
            this.Visible = false;
        }

        private void ImgProducao_Click(object sender, EventArgs e)
        {
            TelaRelatorioProducao relatorio = new TelaRelatorioProducao();
            relatorio.Show();
            this.Visible = false;
        }

        private void ImgEstoque_Click(object sender, EventArgs e)
        {
            TelaRelatorioRacao relatorio = new TelaRelatorioRacao();
            relatorio.Show();
            this.Visible = false;
        }

        private void ImgRemedios_Click(object sender, EventArgs e)
        {
            TelaRelatorioMedicamento relatorio = new TelaRelatorioMedicamento();
            relatorio.Show();
            this.Visible = false;
        }

        private void ImgCampos_Click(object sender, EventArgs e)
        {
            TelaRelatorioPropriedade relatorio = new TelaRelatorioPropriedade();
            relatorio.Show();
            this.Visible = false;
        }
    }
}
