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
    public partial class client : UserControl
    {
        public client()
        {
            InitializeComponent();
            LoadClientData();
        }

        string cs = "Data Source=NPN_PERERA; Initial Catalog=wed_planning_managemnet; Integrated Security=True";


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                // Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(txtClientID.Text) ||
                    string.IsNullOrWhiteSpace(txtClientName.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                    string.IsNullOrWhiteSpace(cmbEventType.Text) ||
                    string.IsNullOrWhiteSpace(txtVenueAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtBudget.Text) ||
                    string.IsNullOrWhiteSpace(txtStatus.Text))
                {
                    MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Client ID (starts with 'C')
                if (!txtClientID.Text.StartsWith("C"))
                {
                    MessageBox.Show("Client ID must start with 'C'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Contact No (10 digits)
                if (txtContactNo.Text.Length != 10 || !long.TryParse(txtContactNo.Text, out _))
                {
                    MessageBox.Show("Contact No must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Budget (valid number)
                if (!decimal.TryParse(txtBudget.Text, out _))
                {
                    MessageBox.Show("Budget must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    con.Open();
                    string query = "INSERT INTO Clients ( ClientID,ClientName, ContactNo, EventType, VenueAddress, EventDate, Budget, Status) " +
                                   "VALUES (@ClientID,@ClientName, @ContactNo, @EventType, @VenueAddress, @EventDate, @Budget, @Status)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ClientID", txtClientID.Text);
                    cmd.Parameters.AddWithValue("@ClientName", txtClientName.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@EventType", cmbEventType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@VenueAddress", txtVenueAddress.Text);
                    cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value);
                    cmd.Parameters.AddWithValue("@Budget", txtBudget.Text);
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client added successfully.");
                    LoadClientData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Clients SET ClientName=@ClientName, ContactNo=@ContactNo, EventType=@EventType, VenueAddress=@VenueAddress, " +
                                   "EventDate=@EventDate, Budget=@Budget, Status=@Status WHERE ClientID=@ClientID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ClientID", txtClientID.Text);
                    cmd.Parameters.AddWithValue("@ClientName", txtClientName.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@EventType", cmbEventType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@VenueAddress", txtVenueAddress.Text);
                    cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value);
                    cmd.Parameters.AddWithValue("@Budget", txtBudget.Text);
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client updated successfully.");

                    LoadClientData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Clients WHERE ClientID=@ClientID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ClientID", txtClientID.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client deleted successfully.");

                    LoadClientData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtClientID.Text = string.Empty;
            txtClientName.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtVenueAddress.Text = string.Empty;
            txtBudget.Text = string.Empty;
            cmbEventType.SelectedIndex = -1;
            dtpEventDate.Value = DateTime.Now;
            txtStatus.Text = string.Empty;
        }


        private void LoadClientData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Clients"; // Adjust query based on your table
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewClients.DataSource = dt; // Set DataGridView data source
                    dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust column sizes
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Clients WHERE ClientID = @ClientID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ClientID", txtClientID.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Check if a record is found
                    {
                        // Load data into text boxes
                        txtClientName.Text = reader["ClientName"].ToString();
                        txtContactNo.Text = reader["ContactNo"].ToString();
                        cmbEventType.SelectedItem = reader["EventType"].ToString();
                        txtVenueAddress.Text = reader["VenueAddress"].ToString();
                        dtpEventDate.Value = Convert.ToDateTime(reader["EventDate"]);
                        txtBudget.Text = reader["Budget"].ToString();
                        txtStatus.Text = reader["Status"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No client found with the entered ID.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
