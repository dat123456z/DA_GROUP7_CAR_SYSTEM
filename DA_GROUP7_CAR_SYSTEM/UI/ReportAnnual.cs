using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.BSLayer;

namespace DA_GROUP7_CAR_SYSTEM.UI
{
    public partial class ReportAnnual : Form
    {
        private readonly BLReport blReport = new BLReport();
        public ReportAnnual()
        {
            InitializeComponent();
        }
        private void ReportAnnual_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 12; i++) cbbMonth.Items.Add(i);
            for (int y = DateTime.Now.Year - 3; y <= DateTime.Now.Year + 1; y++) cbbYear.Items.Add(y);

            cbbMonth.SelectedItem = DateTime.Now.Month;
            cbbYear.SelectedItem = DateTime.Now.Year;

        }

      

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbbMonth.SelectedItem == null || cbbYear.SelectedItem == null)
            {
                MessageBox.Show("Please select month and year!");
                return;
            }

            int month = Convert.ToInt32(cbbMonth.SelectedItem);
            int year = Convert.ToInt32(cbbYear.SelectedItem);

            dgvSalary.DataSource = blReport.GetSalaryReport(month, year);
            dgvInvoice.DataSource = blReport.GetInvoiceReport(month, year);
        }

        
    }
}
