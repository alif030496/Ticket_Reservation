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
    public partial class Form4 : Form
    {
        public Form4(string SetValueForText, string SetValueForText1, string SetValueForText2)
        {
            InitializeComponent();
            txtBoar.Text = SetValueForText;
            txtDrop.Text = SetValueForText1;
            textBox4.Text = SetValueForText2;

        }

        private int a = 1;
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LENOVO-IP500;Initial Catalog=DMRT;Integrated Security=True");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO user_details (first_name,last_name,mobile,email,address,date,nationality,gender,seat,seatfare,bording,dropping,type) VALUES (@first_name,@last_name,@mobile,@email,@address,@date,@nationality,@gender,@seat,@seatfare,@bording,@dropping,@type)", con);
                cmd.Parameters.AddWithValue("@first_name", textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@last_name", textBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", textBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@address", textBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@date", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@nationality", textBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", comboBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@seat", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@seatfare", txtTotalCost.Text.Trim());
                cmd.Parameters.AddWithValue("@bording", txtBoar.Text.Trim());
                cmd.Parameters.AddWithValue("@dropping", txtDrop.Text.Trim());
                cmd.Parameters.AddWithValue("@type", comboBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your ticket successfully booked. Happy Journey!!!", "Confirmation", MessageBoxButtons.OK);
                clear();
                new Form3().Show();
                this.Hide();
            }
        }
        void clear()
        {
            textBox5.Text = textBox11.Text = textBox3.Text = textBox6.Text = textBox7.Text = textBox4.Text = textBox8.Text = comboBox1.Text = txtTotalSeat.Text = txtTotalCost.Text = txtBoar.Text = txtDrop.Text = "";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(txtBoar.Text);
            int text2 = Convert.ToInt32(txtDrop.Text);
            int text3 = (text1 - text2);
            txtDes.Text = Convert.ToString(text3);

            int distance = Convert.ToInt32(txtDes.Text);
            int ticketPrice = distance * 6;
            txtSeat.Text = Convert.ToString(ticketPrice);

            int perSeat = Convert.ToInt32(txtSeat.Text);
            int totalSeat = Convert.ToInt32(txtTotalSeat.Text);
            int showTotalCost = perSeat * totalSeat;
            txtTotalCost.Text = Convert.ToString(showTotalCost);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text + " ";
            txtTotalSeat.Text = a.ToString();
            a++;
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
