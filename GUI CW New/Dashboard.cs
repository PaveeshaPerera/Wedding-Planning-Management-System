using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW_New
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            mainpanel.Controls.Clear();
            dash1 d = new dash1();
            d.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(d);
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

           
            if (result == DialogResult.Yes)
            {
                Loginform login = new Loginform();
                login.Show();
                this.Hide();
            }
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
           dash1 d= new dash1();
            d.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(d);
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            client client = new client();
            client.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(client);
        }


        private void btnvendor_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            vendor vendor = new vendor();
            vendor.Dock = DockStyle.Fill;   
            mainpanel.Controls.Add(vendor); 
        }

        private void btnwed_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            wedding wedding = new wedding();
            wedding.Dock = DockStyle.Fill;  
            mainpanel.Controls.Add (wedding);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            reports reports = new reports();
            reports.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(reports);
        }
    }
}
