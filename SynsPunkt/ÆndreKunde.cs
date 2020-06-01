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
    public partial class ÆndreKunde : Form
    {
        public ÆndreKunde()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID = mssqldatabase4; Password=corona!");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = $"update kunde set navn='{txtBox1.Text}',adresse='{textBox2.Text}',tlf='{textBox3.Text}',id={textBox4.Text}" +
              $"where knr={textBox1.Text}";
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
