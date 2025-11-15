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
    public partial class register : Form
    {
        public register()
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
            if (string.IsNullOrWhiteSpace(txtusern.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cs = "Data Source=NPN_PERERA ; Initial Catalog=wed_planning_managemnet; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                // Check if the username already exists
                string checkSql = "SELECT COUNT(*) FROM userlogin WHERE username = @user";
                SqlCommand checkCmd = new SqlCommand(checkSql, con);
                checkCmd.Parameters.AddWithValue("@user", txtusern.Text);

                int userExists = (int)checkCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert the new user into the database with the current date
                string sql = "INSERT INTO userlogin (username, password, datereg) VALUES (@user, @pw, @regdate)";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@user", txtusern.Text);
                com.Parameters.AddWithValue("@pw", textBox3.Text);
                com.Parameters.AddWithValue("@regdate", DateTime.Now); // Use current date and time

                int rowsAffected = com.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusern.Clear();
                    textBox3.Clear();

                    Loginform log = new Loginform();
                    log.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                com.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBox3.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Loginform log = new Loginform();
            log.Show();
            this.Hide();
        }
    }
}
