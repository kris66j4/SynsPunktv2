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
using System.IO;

namespace SynsPunkt
{
    public partial class Ordre : Form
    {
        SqlConnection con = new SqlConnection("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID = mssqldatabase4; Password=corona!");
        public Ordre()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            List<int> total = new List<int>();
            OrdreClass o = new OrdreClass();
            string q = $"select * from ordre where dato between '{textBox1.Text}' and '{textBox2.Text}'";
            SqlDataReader sqld = null;
            SqlCommand cmd = new SqlCommand(q, con);
            sqld = cmd.ExecuteReader();
            int totalpris = 0;
            if (sqld.HasRows)
            {
                while (sqld.Read())
                {
                    o.Kundenr = Convert.ToInt32(sqld[0]);
                    o.Navn = sqld[1].ToString();
                    o.Dato = sqld[2].ToString();
                    o.Pris = Convert.ToInt32(sqld[3]);

                    total.Add(o.Pris);

                    listBox1.Items.Add(o.Kundenr + "\t" + o.Navn + "\t" + o.Dato + "\t" + o.Pris);


                }
                con.Close();
                foreach(int element in total)
                {
                    totalpris = totalpris + element;
                }
                listBox1.Items.Add("");
                listBox1.Items.Add("\t\t\t\t\t I alt kr.   " + totalpris);


            }
            else
            {
                con.Close();
                MessageBox.Show("Fejl");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int i = 0; i < listBox1.Items.Count; i++)
                    writer.WriteLine((string)listBox1.Items[i]);

                writer.Close();
            }
            dlg.Dispose();
        }
    }
}
