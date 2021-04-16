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

namespace SDP2_PROJECT
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SRILA-PC;Initial Catalog=DMRT;Integrated Security=True;Pooling=False");
            SqlDataAdapter cmd = new SqlDataAdapter("select count(*) from admin where user_name='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable at = new DataTable();
            cmd.Fill(at);
            if (at.Rows[0][0].ToString() == "1")
            {
               // new Form5().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
