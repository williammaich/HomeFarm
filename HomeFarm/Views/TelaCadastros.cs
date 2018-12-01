using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm
{
    public partial class TelaCadastros : Form
    {
        public TelaCadastros()
        {
            InitializeComponent();

        
        }

       

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            CadastroAnimais CadAnimais = new CadastroAnimais();
            CadAnimais.Show();
            this.Visible = false;
        }

     

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgRaca_Click(object sender, EventArgs e)
        {
            CadastroRacasETipos cadRacasETipos = new CadastroRacasETipos();
            cadRacasETipos.Show();
            this.Visible = false;
        }

        private void ImgFuncionarios_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
            cadFuncionarios.Show();
            this.Visible = false;
        }

        private void ImgCampos_Click(object sender, EventArgs e)
        {
            CadastroPropriedades propriedades = new CadastroPropriedades();
            propriedades.Show();
            this.Visible = false;
        }

        private void ImgRemedios_Click(object sender, EventArgs e)
        {
            CadastroRemedios remedio = new CadastroRemedios();
            remedio.Show();
            this.Visible = false;
        }

        private void ImgLote_Click(object sender, EventArgs e)
        {
            CadastroLote lote = new CadastroLote();
            lote.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
