using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW_New
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusern.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cs = "Data Source=NPN_PERERA ; Initial Catalog=wed_planning_managemnet; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                string sql = "SELECT * FROM userlogin WHERE username= @user AND password = @pw";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@user", txtusern.Text);
                com.Parameters.AddWithValue("@pw", textBox2.Text);

                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                reader.Close();
                com.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }
    }
}
