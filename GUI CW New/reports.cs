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
    public partial class reports : UserControl
    {
        public reports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
             eventschedule eventschedule = new eventschedule();
            eventschedule.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(eventschedule);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            cusdetails cusdetails = new cusdetails();
            cusdetails.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(cusdetails);
        }
    }
}
