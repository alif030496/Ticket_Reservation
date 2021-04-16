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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userbox.Text != "" && passwordbox.Text != "")
            {

                SqlConnection con = new SqlConnection(@"Data Source=LENOVO-IP500;Initial Catalog=DMRT;Integrated Security=True");
                SqlDataAdapter cmd = new SqlDataAdapter("select count(*) from Registration where user_name='" + userbox.Text + "' and password='" + passwordbox.Text + "'", con);
                DataTable at = new DataTable();
                cmd.Fill(at);
                if (at.Rows[0][0].ToString() == "1")
                {
                    new Form3().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter the correct username and password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please give Username and Password");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
