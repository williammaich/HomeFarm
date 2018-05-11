using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFarmSD
{
    public partial class TelaPrincipalSIS : Form
    {
        public TelaPrincipalSIS()
        {
            InitializeComponent();
            PainelDeslisante.Height = btnHome.Height;
            PainelDeslisante.Top = btnHome.Top;
            homeUserControl11.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnHome.Height;
            PainelDeslisante.Top = btnHome.Top;
            homeUserControl11.BringToFront(); 
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            PainelDeslisante.Height = btnAnimais.Height;
            PainelDeslisante.Top = btnAnimais.Top;
            animalUserControl11.BringToFront();
        }
    }
}
