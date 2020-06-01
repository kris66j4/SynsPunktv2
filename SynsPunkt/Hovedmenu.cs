using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SynsPunkt
{
    public partial class Hovedmenu : Form
    {
        string stdDetails = "{0, -10}{1, -20}{2, -20}{3, -20}{4, -20}{5, -10}";
        SqlConnection con = new SqlConnection("Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID = mssqldatabase4; Password=corona!");
        public Hovedmenu()
        {
            InitializeComponent();
        }

        private void sletVareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new ÆndreVare();
            f3.Show();
        }

        private void opretVareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form f2 = new OpretVare();
            f2.Show();
        }

        private void sletVareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f4 = new SletVare();
            f4.Show();
        }

        private void opretKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f5 = new OpretKunde();
            f5.Show();
        }

        private void sletKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f6 = new ÆndreKunde();
            f6.Show();
        }

        private void sletKundeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f7 = new SletKunde();
            f7.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            con.Open();
            string q = "select * from vare";
                SqlDataReader sqld = null;
                SqlCommand cmd = new SqlCommand(q, con);
                sqld = cmd.ExecuteReader();
                List<Vare> vare = new List<Vare>();
                listBox1.Items.Add("Varenr	Gruppe	Mærke   Type    Stk.    Pris");
                if (sqld.HasRows)
                {
                    while (sqld.Read())
                    {
                        Vare v = new Vare();

                        v.vnr = Convert.ToInt32(sqld[0]);
                        v.Varegruppe = sqld[1].ToString();
                        v.Mærke = sqld[2].ToString();
                        v.Glastype = sqld[3].ToString();
                        v.Lagerstatus = Convert.ToInt32(sqld[4]);
                        v.Pris = Convert.ToInt32(sqld[5]);

                        vare.Add(v);
                        
                        listBox1.Items.Add(v.vnr +"\t" + v.Varegruppe + "\t" + v.Mærke + "\t" + v.Glastype + "\t" + v.Lagerstatus + "\t" + v.Pris);


                }
                    con.Close();
                    


                }
                else
                {
                    con.Close();
                    MessageBox.Show("Fejl");
                }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int i = 0; i < listBox1.Items.Count; i++)
                    writer.WriteLine((string)listBox1.Items[i]);

                writer.Close();
            }
            dlg.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form ordre = new Ordre();
            
            ordre.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form rådgivning = new Rådgivning();
            rådgivning.Show();
        }
    }
}
