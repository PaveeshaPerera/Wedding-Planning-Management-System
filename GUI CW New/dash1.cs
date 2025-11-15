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
    public partial class dash1 : UserControl
    {
        public dash1()
        {
            InitializeComponent();
            LoadCounts();
            LoadScheduledEvents();
        }
        string cs = "Data Source=NPN_PERERA; Initial Catalog=wed_planning_managemnet; Integrated Security=True";


        private void LoadCounts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    // Query for Scheduled Events (status = 'Pending' or 'Active')
                    string query1 = "SELECT COUNT(*) FROM Clients WHERE Status IN ('Pending', 'Active')";
                    using (SqlCommand cmd1 = new SqlCommand(query1, con))
                    {
                        int scheduledEventsCount = (int)cmd1.ExecuteScalar();
                        lbl1.Text = scheduledEventsCount.ToString();
                    }

                    // Query for Total Clients
                    string query2 = "SELECT COUNT(*) FROM Clients";
                    using (SqlCommand cmd2 = new SqlCommand(query2, con))
                    {
                        int totalClientsCount = (int)cmd2.ExecuteScalar();
                        lbl2.Text = totalClientsCount.ToString();
                    }

                    // Query for Completed Events (status = 'Completed')
                    string query3 = "SELECT COUNT(*) FROM Clients WHERE Status = 'Completed'";
                    using (SqlCommand cmd3 = new SqlCommand(query3, con))
                    {
                        int completedEventsCount = (int)cmd3.ExecuteScalar();
                        lbl3.Text = completedEventsCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadScheduledEvents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    // SQL query to get events in the current month
                    string query = @"
                SELECT EventID, ClientID, EventType, EventDate, Budget, Vendor1, Vendor2, Vendor3, VenueAddress
                FROM Events
                WHERE MONTH(EventDate) = MONTH(GETDATE()) AND YEAR(EventDate) = YEAR(GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind the data to the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dash1_Load(object sender, EventArgs e)
        {

        }
    }
}
