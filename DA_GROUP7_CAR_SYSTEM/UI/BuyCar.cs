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
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM.UI
{
    public partial class BuyCar : Form
    {
        private BLBuyCar blBuyCar;
        private string currentLoginName;
        private BLCustomer blCustomer;

        public BuyCar(string loginName)
        {
            InitializeComponent();
            blBuyCar = new BLBuyCar();
            currentLoginName = loginName;
            blCustomer = new BLCustomer();
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                DataSet ds = blBuyCar.loadData(currentLoginName);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    
                    // Set textbox values
                    txtLoginName.Text = row["LoginName"].ToString();
                    txtPassword.Text = row["Password"].ToString();
                    txtPhone.Text = row["PhoneNumber"].ToString();
                    txtAddress.Text = row["Address"].ToString();
                    txtEmail.Text = row["EmailAddress"].ToString();

                    txtPassword.PasswordChar = '*';
                    // Make login name and password read-only
                    txtLoginName.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            UpdateUserData();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            UpdateUserData();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateUserData();
        }

        private void UpdateUserData()
        {
            try
            {
                string error = "";
                string sql = $@"UPDATE SignUp 
                              SET PhoneNumber = N'{txtPhone.Text}',
                                  Address = N'{txtAddress.Text}',
                                  EmailAddress = N'{txtEmail.Text}'
                              WHERE LoginName = N'{currentLoginName}'";

                DBMain db = new DBMain();
                if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
                {
                    // Update successful
                }
                else
                {
                    MessageBox.Show("Error updating data: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string error = "";
            if (blCustomer.AddCustomer(txtFullName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, ref error))
            {
                MessageBox.Show("Đã lưu thông tin khách hàng!");
                FormPage formPage = new FormPage(txtFullName.Text);
                formPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi lưu thông tin: " + error);
            }
        }
    }
}
