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
    public partial class Rådgivning : Form
    {
        public Rådgivning()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID = mssqldatabase4; Password=corona!");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = $"select * from vare where køn like '%{textBox5.Text}%' and mærke like '%{textBox4.Text}%' and glastype like '%{textBox3.Text}%' and farve like '%{textBox1.Text}%' and størrelse like '%{textBox2.Text}%' and pris < {textBox6.Text}";
            SqlDataReader sqld = null;
            SqlCommand cmd = new SqlCommand(q, con);
            sqld = cmd.ExecuteReader();
            listBox1.Items.Add("Varenr	Gruppe	Mærke   Type    Stk.    Pris");
            if (sqld.HasRows)
            {
                while (sqld.Read())
                {
                    Vare v = new Vare();

                    v.Køn = sqld[7].ToString();
                    v.Mærke = sqld[2].ToString();
                    v.Glastype = sqld[3].ToString();
                    v.Farve = sqld[6].ToString();
                    v.Størrelse = sqld[8].ToString();
                    v.Pris = Convert.ToInt32(sqld[5]);

                    listBox1.Items.Add(v.Køn + "\t" + v.Mærke + "\t" + v.Glastype + "\t" + v.Farve + "\t" + v.Størrelse + "\t" + v.Pris);

                }
                con.Close();



            }
            else
            {
                con.Close();
                MessageBox.Show("Fejl");
            }
        }
    }
}
