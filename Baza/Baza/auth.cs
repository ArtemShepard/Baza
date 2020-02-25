using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baza
{
    public partial class auth : Form
    {
        SqlConnection conn = new SqlConnection("Data Source Server=.\\SQLEXPRESS;Initial Catalog=Practica;Integrated Security=true;");

        public auth()
        {
            InitializeComponent();//?????
        }

        //conection string c#
        
        private void auth_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source Server=.\\SQLEXPRESS;Initial Catalog=Practica;Integrated Security=true;");
            conn.Open();
            SqlCommand com = new SqlCommand("SELECT login FROM Login = '{textBox1.Text}' and password = '{textBox2.Text}'", conn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows)
                MessageBox.Show("Good");
            else
            {

            }
        }
    }
}
