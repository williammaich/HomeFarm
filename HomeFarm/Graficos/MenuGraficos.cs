using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarm.Graficos
{
    public partial class MenuGraficos : Form
    {
        public MenuGraficos()
        {
            InitializeComponent();
        }

        

        private void ImgAnimais_Click(object sender, EventArgs e)
        {
            GrafAnimais animais = new GrafAnimais();
            animais.Show();
            this.Visible = false;
        }

        private void ImgFuncionarios_Click(object sender, EventArgs e)
        {
            GrafFuncionarios func = new GrafFuncionarios();
            func.Show();
            this.Visible = false;
        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
