using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPrograCuqueRuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANDRÉS-CUQUE\MSSQLSERVER2;Initial Catalog=loginBebe; Integrated Security=True");
            con.Open();
            string query = "select count (*) from loginapp where username=@username AND pasword=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Acceso exitoso!");
                Crud cambio = new Crud();
                this.Hide();
                cambio.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Acceso denegado");
            this.Close();
        }
    
    }
}
