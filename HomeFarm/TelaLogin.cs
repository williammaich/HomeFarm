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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

            ImgFace.Parent = ImgLogin;
            ImgFace.BackColor = Color.Transparent;

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            MenuPrincipal Tprincipal = new MenuPrincipal();
            Tprincipal.Show();
            this.Visible = false;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar Registro = new Registrar();
            Registro.Show();
            this.Visible = false;
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
