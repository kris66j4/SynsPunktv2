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
    public partial class OpretKunde : Form
    {
        public OpretKunde()
        {
            InitializeComponent();
        }

        private void OpretKunde_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID = mssqldatabase4; Password=corona!");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = $"insert into kunde(navn, adresse, tlf, id) values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}',{textBox4.Text})";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fint");
            }
            else
            {
                MessageBox.Show("Fejl");
            }
        }
    }
}
