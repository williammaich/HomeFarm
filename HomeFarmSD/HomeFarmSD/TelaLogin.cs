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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if ((textSenha.Text == "william") && (textEmail.Text == "williammaich"))
            {
               TelaPrincipalSIS telaSis = new TelaPrincipalSIS();
                telaSis.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login ou Senha invalidas ");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           Registrar registro = new Registrar();
            registro.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
