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
    public partial class vendor : UserControl
    {
        public vendor()
        {
            InitializeComponent();
            LoadData();
        }

        string cs = "Data Source=NPN_PERERA; Initial Catalog=wed_planning_managemnet; Integrated Security=True";

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Vendor";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Vendor WHERE VendorID = @VendorID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VendorID", txtVendorID.Text);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtVendorName.Text = reader["VendorName"].ToString();
                        txtContactNo.Text = reader["ContactNo"].ToString();
                        txtEmail.Text = reader["EmailAddress"].ToString();
                        cmbServiceType.Text = reader["ServiceType"].ToString();
                        txtServiceDescription.Text = reader["ServiceDescription"].ToString();
                        txtPricingDetails.Text = reader["PricingDetails"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vendor not found.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                // Check if any required fields are empty
                if (string.IsNullOrWhiteSpace(txtVendorID.Text) ||
                    string.IsNullOrWhiteSpace(txtVendorName.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(cmbServiceType.Text) ||
                    string.IsNullOrWhiteSpace(txtServiceDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtPricingDetails.Text))
                {
                    MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              

                // Validate Contact No (must be numeric and exactly 10 digits)
                if (!long.TryParse(txtContactNo.Text, out _) || txtContactNo.Text.Length != 10)
                {
                    MessageBox.Show("Contact No must be exactly 10 digits and numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Email Address (must contain @)
                if (!txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Email Address must contain '@'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO Vendor (VendorID, VendorName, ContactNo, EmailAddress, ServiceType, ServiceDescription, PricingDetails) VALUES (@VendorID, @VendorName, @ContactNo, @EmailAddress, @ServiceType, @ServiceDescription, @PricingDetails)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VendorID", txtVendorID.Text);
                    cmd.Parameters.AddWithValue("@VendorName", txtVendorName.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ServiceType", cmbServiceType.Text);
                    cmd.Parameters.AddWithValue("@ServiceDescription", txtServiceDescription.Text);
                    cmd.Parameters.AddWithValue("@PricingDetails", txtPricingDetails.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vendor added successfully.");
                    LoadData();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "UPDATE Vendor SET VendorName = @VendorName, ContactNo = @ContactNo, EmailAddress = @EmailAddress, ServiceType = @ServiceType, ServiceDescription = @ServiceDescription, PricingDetails = @PricingDetails WHERE VendorID = @VendorID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VendorID", txtVendorID.Text);
                    cmd.Parameters.AddWithValue("@VendorName", txtVendorName.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ServiceType", cmbServiceType.Text);
                    cmd.Parameters.AddWithValue("@ServiceDescription", txtServiceDescription.Text);
                    cmd.Parameters.AddWithValue("@PricingDetails", txtPricingDetails.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vendor updated successfully.");
                    LoadData();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE FROM Vendor WHERE VendorID = @VendorID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VendorID", txtVendorID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vendor deleted successfully.");
                    LoadData();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtVendorID.Clear();
            txtVendorName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            cmbServiceType.SelectedIndex = -1;
            txtServiceDescription.Clear();
            txtPricingDetails.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtVendorID.Text = row.Cells["VendorID"].Value.ToString();
                txtVendorName.Text = row.Cells["VendorName"].Value.ToString();
                txtContactNo.Text = row.Cells["ContactNo"].Value.ToString();
                txtEmail.Text = row.Cells["EmailAddress"].Value.ToString();
                cmbServiceType.Text = row.Cells["ServiceType"].Value.ToString();
                txtServiceDescription.Text = row.Cells["ServiceDescription"].Value.ToString();
                txtPricingDetails.Text = row.Cells["PricingDetails"].Value.ToString();
            }
        }
    }
}
