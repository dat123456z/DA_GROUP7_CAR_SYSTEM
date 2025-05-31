using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_GROUP7_CAR_SYSTEM.UI
{
    public partial class FRMain : Form
    {
        public FRMain()
        {
            InitializeComponent();
            

        }
        private void FRMain_Load(object sender, EventArgs e)
        {
            btn_Homeload_Click();
        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Pl_Main.Controls.Add(childForm);
            Pl_Main.Tag = childForm;

            childForm.BringToFront();
            //  Pl_Main.PerformLayout();
            childForm.Show();
        }

        private void btn_Vehicle_Click(object sender, EventArgs e)
        {
            openChildForm(new VehicleFr());
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerFr());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeFr());
        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            openChildForm(new Invoice());
        }

        private void btn_InvoiceDetail_Click(object sender, EventArgs e)
        {
            openChildForm(new InvoiceDetail());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            openChildForm(new Statistical());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {

            
            FormPage fg =new FormPage(Name);
            fg.Offlabel();
            openChildForm(fg);
        }
        private void btn_Homeload_Click()
        {
            FormPage fg = new FormPage(Name);
            fg.Offlabel();
            openChildForm(fg);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            openChildForm(new ReportAnnual());
        }
    }
}
