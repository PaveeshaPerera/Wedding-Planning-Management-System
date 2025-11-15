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
    public partial class wedding : UserControl
    {
        public wedding()
        {
            InitializeComponent();
            LoadData();
        }
        string cs = "Data Source=NPN_PERERA; Initial Catalog=wed_planning_managemnet; Integrated Security=True";


        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Events";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewEvents.DataSource = table;
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Events WHERE EventID = @EventID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EventID", txtEventID.Text);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtClientID.Text = reader["ClientID"].ToString();
                        cmbEventType.Text = reader["EventType"].ToString();
                        dtpEventDate.Value = Convert.ToDateTime(reader["EventDate"]);
                        txtBudget.Text = reader["Budget"].ToString();
                        cmbVendor1.Text = reader["Vendor1"].ToString();
                        cmbVendor2.Text = reader["Vendor2"].ToString();
                        cmbVendor3.Text = reader["Vendor3"].ToString();
                        txtVenueAddress.Text = reader["VenueAddress"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Event not found.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                // Check if any required fields are empty
                if (string.IsNullOrWhiteSpace(txtEventID.Text) ||
                    string.IsNullOrWhiteSpace(txtClientID.Text) ||
                    string.IsNullOrWhiteSpace(cmbEventType.Text) ||
                    string.IsNullOrWhiteSpace(txtBudget.Text) ||
                    string.IsNullOrWhiteSpace(cmbVendor1.Text) ||
                    string.IsNullOrWhiteSpace(cmbVendor2.Text) ||
                    string.IsNullOrWhiteSpace(cmbVendor3.Text) ||
                    string.IsNullOrWhiteSpace(txtVenueAddress.Text))
                {
                    MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Event ID (must start with 'E')
                if (!txtEventID.Text.StartsWith("E"))
                {
                    MessageBox.Show("Event ID must start with 'E'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Client ID (must start with 'C')
                if (!txtClientID.Text.StartsWith("C"))
                {
                    MessageBox.Show("Client ID must start with 'C'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Budget (must be numeric)
                if (!decimal.TryParse(txtBudget.Text, out _))
                {
                    MessageBox.Show("Budget must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO Events (EventID, ClientID, EventType, EventDate, Budget, Vendor1, Vendor2, Vendor3, VenueAddress) VALUES (@EventID, @ClientID, @EventType, @EventDate, @Budget, @Vendor1, @Vendor2, @Vendor3, @VenueAddress)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EventID", txtEventID.Text);
                    cmd.Parameters.AddWithValue("@ClientID", txtClientID.Text);
                    cmd.Parameters.AddWithValue("@EventType", cmbEventType.Text);
                    cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value);
                    cmd.Parameters.AddWithValue("@Budget", txtBudget.Text);
                    cmd.Parameters.AddWithValue("@Vendor1", cmbVendor1.Text);
                    cmd.Parameters.AddWithValue("@Vendor2", cmbVendor2.Text);
                    cmd.Parameters.AddWithValue("@Vendor3", cmbVendor3.Text);
                    cmd.Parameters.AddWithValue("@VenueAddress", txtVenueAddress.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event added successfully.");
                    LoadData(); // Refresh DataGridView
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "UPDATE Events SET ClientID = @ClientID, EventType = @EventType, EventDate = @EventDate, Budget = @Budget, Vendor1 = @Vendor1, Vendor2 = @Vendor2, Vendor3 = @Vendor3, VenueAddress = @VenueAddress WHERE EventID = @EventID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EventID", txtEventID.Text);
                    cmd.Parameters.AddWithValue("@ClientID", txtClientID.Text);
                    cmd.Parameters.AddWithValue("@EventType", cmbEventType.Text);
                    cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value);
                    cmd.Parameters.AddWithValue("@Budget", txtBudget.Text);
                    cmd.Parameters.AddWithValue("@Vendor1", cmbVendor1.Text);
                    cmd.Parameters.AddWithValue("@Vendor2", cmbVendor2.Text);
                    cmd.Parameters.AddWithValue("@Vendor3", cmbVendor3.Text);
                    cmd.Parameters.AddWithValue("@VenueAddress", txtVenueAddress.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event updated successfully.");
                    LoadData(); // Refresh DataGridView
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE FROM Events WHERE EventID = @EventID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EventID", txtEventID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event deleted successfully.");
                    LoadData(); // Refresh DataGridView
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtEventID.Clear();
            txtClientID.Clear();
            cmbEventType.SelectedIndex = -1;
            dtpEventDate.Value = DateTime.Now;
            txtBudget.Clear();
            cmbVendor1.SelectedIndex = -1;
            cmbVendor2.SelectedIndex = -1;
            cmbVendor3.SelectedIndex = -1;
            txtVenueAddress.Clear();
        }

        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEvents.Rows[e.RowIndex];
                txtEventID.Text = row.Cells["EventID"].Value.ToString();
                txtClientID.Text = row.Cells["ClientID"].Value.ToString();
                cmbEventType.Text = row.Cells["EventType"].Value.ToString();
                dtpEventDate.Value = Convert.ToDateTime(row.Cells["EventDate"].Value);
                txtBudget.Text = row.Cells["Budget"].Value.ToString();
                cmbVendor1.Text = row.Cells["Vendor1"].Value.ToString();
                cmbVendor2.Text = row.Cells["Vendor2"].Value.ToString();
                cmbVendor3.Text = row.Cells["Vendor3"].Value.ToString();
                txtVenueAddress.Text = row.Cells["VenueAddress"].Value.ToString();
            }
        }
    }
}
