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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENOVO-IP500;Initial Catalog=DMRT;Integrated Security=True");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Registration (user_name,password) VALUES (@user_name,@password)", con);
                cmd.Parameters.AddWithValue("@user_name", userbox.Text.Trim());
                cmd.Parameters.AddWithValue("@password", passwordbox.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully", "Alert", MessageBoxButtons.OK);
                clear();
                new Form1().Show();
                this.Hide();
            }
        }
        void clear()
        {
            userbox.Text = passwordbox.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 loginPage = new Form1();
            loginPage.ShowDialog();
        }
    }
}
