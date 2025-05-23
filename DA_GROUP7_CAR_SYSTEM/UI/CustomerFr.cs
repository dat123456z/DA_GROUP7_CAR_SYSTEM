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
using System.Data.SqlClient;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class CustomerFr : Form
    {
        BLCustomer blCustomer = null;
        private string currentLoginName;

        public CustomerFr()
        {
            InitializeComponent();
            txtCustomerID.ReadOnly = false;
            txtCustomerID.Enabled = true;
            blCustomer = new BLCustomer();
            //txtCustomerID.ReadOnly = true;
            LoadCustomerData();
        }

        public CustomerFr(string loginName)
        {
            InitializeComponent();
            txtCustomerID.ReadOnly = false;
            txtCustomerID.Enabled = true;
            blCustomer = new BLCustomer();
            //txtCustomerID.ReadOnly = true;
            currentLoginName = loginName;
            LoadCustomerData();
            LoadCustomerInfoByLogin();
        }

        private void LoadCustomerInfoByLogin()
        {
            try
            {
                string error = "";
                string sql = $@"SELECT c.* 
                              FROM Customer c
                              INNER JOIN SignUp s ON c.FullName = s.FullName
                              INNER JOIN Login l ON s.LoginName = l.LoginName
                              WHERE l.LoginName = N'{currentLoginName}'";

                DBMain db = new DBMain();
                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    txtCustomerID.Text = row["CustomerID"].ToString();
                    txtFullName.Text = row["FullName"].ToString();
                    txtAddress.Text = row["Address"].ToString();
                    txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerData()
        {
            try
            {
                DataSet ds = blCustomer.GetCustomers();
                DataTable dt = ds.Tables[0];

                dgvCustomer.DataSource = dt;

                // Đảm bảo DataSource đã gán xong mới set Width
                if (dgvCustomer.Columns["FullName"] != null)
                    dgvCustomer.Columns["FullName"].Width = 150;
                if (dgvCustomer.Columns["Address"] != null)
                    dgvCustomer.Columns["Address"].Width = 200;
                if (dgvCustomer.Columns["PhoneNumber"] != null)
                    dgvCustomer.Columns["PhoneNumber"].Width = 100;
                if (dgvCustomer.Columns["Email"] != null)
                    dgvCustomer.Columns["Email"].Width = 180;

                dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvCustomer.AllowUserToResizeColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter customer name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter phone number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return false;
            }

            if (!IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter a valid phone number (10-11 digits)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Remove any non-digit characters
            string digitsOnly = new string(phoneNumber.Where(char.IsDigit).ToArray());
            // Check if the length is between 10 and 11 digits
            return digitsOnly.Length >= 10 && digitsOnly.Length <= 11;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string error = "";
            string sql = $@"INSERT INTO Customer (CustomerID,FullName, Address, PhoneNumber, Email)
                           VALUES (N'{txtCustomerID.Text}',N'{txtFullName.Text}', N'{txtAddress.Text}', N'{txtPhoneNumber.Text}', N'{txtEmail.Text}')";

            DBMain db = new DBMain();
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int customerID = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value);
                    string error = "";
                    string sql = $@"DELETE FROM Customer WHERE CustomerID = {customerID}";

                    DBMain db = new DBMain();
                    if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
                    {
                        MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomerData();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (dgvCustomer.SelectedRows.Count > 0)
            {
                int oldCustomerID = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value);
                int newCustomerID;

                if (!int.TryParse(txtCustomerID.Text, out newCustomerID))
                {
                    MessageBox.Show("Please enter a valid Customer ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string error = "";
                string sql = $@"UPDATE Customer 
                              SET CustomerID = {newCustomerID},
                                  FullName = N'{txtFullName.Text}',
                                  Address = N'{txtAddress.Text}',
                                  PhoneNumber = N'{txtPhoneNumber.Text}',
                                  Email = N'{txtEmail.Text}'
                              WHERE CustomerID = {oldCustomerID}";

                DBMain db = new DBMain();
                if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
                {
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearInputs()
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtCustomerID.Clear();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                // Ensure column names match your DataTable/DataGridView
                if (dgvCustomer.Columns.Contains("CustomerID"))
                    txtCustomerID.Text = row.Cells["CustomerID"].Value?.ToString() ?? "";
                if (dgvCustomer.Columns.Contains("FullName"))
                    txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                if (dgvCustomer.Columns.Contains("Address"))
                    txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                if (dgvCustomer.Columns.Contains("PhoneNumber"))
                    txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                if (dgvCustomer.Columns.Contains("Email"))
                    txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomer.SelectedRows[0];
                txtCustomerID.Text = row.Cells["CustomerID"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}