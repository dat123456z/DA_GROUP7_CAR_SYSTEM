using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class MainFr : Form
    {
        public MainFr()
        {
            InitializeComponent();
            customizeDesing();
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
      /*  private void MainFr_Resize(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Dock = DockStyle.Fill; // Gắn lại nếu bị lỗi
                activeForm.Refresh();             // Cập nhật lại giao diện
            }
        }*/

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeFr());
        }

        private void MainFr_Load(object sender, EventArgs e)
        {
           // this.Resize += MainFr_Resize;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerFr());
        }

        private void btn_Vehicle_Click(object sender, EventArgs e)
        {
            openChildForm(new VehicleFr());
          //  hideSubMenu();  
        }
        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            openChildForm(new Invoice());
        }
        private void btn_InvoiceDetail_Click(object sender, EventArgs e)
        {
            openChildForm(new InvoiceDetail());
        }
        private void customizeDesing()
        {
            Pn_SubCarManagement.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (Pn_SubCarManagement.Visible == true)
                Pn_SubCarManagement.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
              //  hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btn_CarManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(Pn_SubCarManagement);
        }

        private void btn_CustomerManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void btn_EmployManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btn_InvoiceManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
        }

        
    }
}
