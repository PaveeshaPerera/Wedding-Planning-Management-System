using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace GUI_CW_New
{
    public partial class eventschedule : UserControl
    {
        public eventschedule()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Load and display the Crystal Report
            ReportDocument reportDocument = new ReportDocument();
            try
            {
                // Provide the correct path to your .rpt file
                string reportPath = @"C:\Users\pavee\Documents\NIBM\C# Nibm\GUI CW 17th\GUI CW New\GUI CW New\evensche2.rpt"; // Update this path
                reportDocument.Load(reportPath);

                // Assign the report to the CrystalReportViewer control
                crystalReportViewer1.ReportSource = reportDocument;
            }
            catch (Exception ex)
            {
                // Display an error message in case of issues
                MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
