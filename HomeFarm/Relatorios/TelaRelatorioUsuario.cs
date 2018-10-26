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
    public partial class TelaRelatorioUsuario : Form
    {
        public TelaRelatorioUsuario()
        {
            InitializeComponent();

            
        }

       

        private void TelaRelatorioUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'homefarmDataSet31.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter1.Fill(this.homefarmDataSet31.usuario);
            // TODO: esta linha de código carrega dados na tabela 'homefarmDataSet1.usuario'. Você pode movê-la ou removê-la conforme necessário.


            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
