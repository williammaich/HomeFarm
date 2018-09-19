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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void ImgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
