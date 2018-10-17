using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace HomeFarm
{
    public partial class ConfirmaAnimais : Form
    {
        public ConfirmaAnimais()
        {
            InitializeComponent();
            
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ("server=localhost; userid=root; database=homefarm; SslMode=none");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "SELECT ID,LOGRADOURO FROM PROPRIEDADE";
            MySqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "LOGRADOURO";
            comboBox1.DataSource = dt;
            


            //CarregaComboPropriedade();


        }

        private void CarregaComboPropriedade()
        {
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "LOGRADOURO";
            comboBox1.DataSource = DALL.RetornaListaPropriedade();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Para resolver o problema do combo box para envio da chave
            MessageBox.Show(comboBox1.SelectedValue.ToString());

            //MessageBox.Show(DirectCast(comboBox1.SelectedItem.ToString()));
        

        }
    }
}
