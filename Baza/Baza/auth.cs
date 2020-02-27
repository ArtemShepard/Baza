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
        SqlConnection conn = new SqlConnection("Data Source = 303-13; Initial Catalog=Practica; Integrated Security=true;");//1
        int Time = 0;
        int Bad = 0;

        public auth()
        {
            InitializeComponent();
        }
        
        private void auth_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();//2
            SqlCommand com = new SqlCommand($"SELECT login FROM Login where login = '{textBox1.Text}' and password = '{textBox2.Text}'", conn);//3
            SqlDataReader dr = com.ExecuteReader();//4

            if (dr.HasRows && Time == 0)
            {
                DataBase dataBase = new DataBase();
                dataBase.Show();
            }            
            else
            {
                Bad++;
                if(Bad >= 3)
                {
                    timer1.Enabled = true;
                    label3.Visible = true;
                }
                
            }
            dr.Close();
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time < 60)
            {
                Time++;
            }
            else
            {
                timer1.Enabled = false;
                Time = 0;
                label3.Visible = false;
                Bad = 0;
            }
            
        }
    }
}
