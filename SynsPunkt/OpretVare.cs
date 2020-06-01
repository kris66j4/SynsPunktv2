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

namespace SynsPunkt
{
    public partial class OpretVare : Form
    {
        public OpretVare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID = mssqldatabase4; Password=corona!");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into vare(varegruppe, mærke, glastype, lagerstatus, pris, farve, køn) values ('" + txtBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','"+ textBox4.Text.ToString() + "','"+ textBox5.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox6.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fint");
            }
            else
            {
                MessageBox.Show("Fejl");
            }
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
