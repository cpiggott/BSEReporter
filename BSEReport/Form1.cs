using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSEReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxButtonAggregateData_Click(object sender, EventArgs e)
        {
            //On Click open the Aggregate Data Form
            FormAggregateData formAggregateData = new FormAggregateData();
            formAggregateData.Show();
        }

        private void uxButtonGenerateReports_Click(object sender, EventArgs e)
        {
            //On Click open the Report Data Form
        }
    }
}
