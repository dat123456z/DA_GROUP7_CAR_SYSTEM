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
        private BLCustomer blCustomer;
        private string currentLoginName;
        private DataTable allCustomers;
        private System.Windows.Forms.TextBox txtSearch;

        public CustomerFr()
        {
            try
            {
                InitializeComponent();
                blCustomer = new BLCustomer();

                // Ensure dgvCustomer is initialized and configure it early
                if (dgvCustomer != null)
                {
                    dgvCustomer.AutoGenerateColumns = false;
                    dgvCustomer.AllowUserToAddRows = false;
                    dgvCustomer.AllowUserToDeleteRows = false;
                    dgvCustomer.ReadOnly = true;
                    dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvCustomer.MultiSelect = false;
                    
                    // Apply layout settings
                    dgvCustomer.Dock = DockStyle.None;
                    dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    dgvCustomer.AllowUserToResizeColumns = true;
                    dgvCustomer.AllowUserToResizeRows = true;
                    dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dgvCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    dgvCustomer.ScrollBars = ScrollBars.Both;
                    dgvCustomer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    // Add columns
                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "CustomerID",
                        HeaderText = "Customer ID",
                        DataPropertyName = "CustomerID",
                        Width = 80
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "FullName",
                        HeaderText = "Full Name",
                        DataPropertyName = "FullName",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Address",
                        HeaderText = "Address",
                        DataPropertyName = "Address",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "PhoneNumber",
                        HeaderText = "Phone Number",
                        DataPropertyName = "PhoneNumber",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Email",
                        HeaderText = "Email",
                        DataPropertyName = "Email",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }

                if (!this.DesignMode)
                {
                    LoadCustomerData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public CustomerFr(string loginName)
        {
            try
            {
                InitializeComponent();
                blCustomer = new BLCustomer();
                currentLoginName = loginName;

                // Ensure dgvCustomer is initialized and configure it early
                if (dgvCustomer != null)
                {
                    dgvCustomer.AutoGenerateColumns = false;
                    dgvCustomer.AllowUserToAddRows = false;
                    dgvCustomer.AllowUserToDeleteRows = false;
                    dgvCustomer.ReadOnly = true;
                    dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvCustomer.MultiSelect = false;

                    // Apply layout settings
                    dgvCustomer.Dock = DockStyle.None;
                    dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    dgvCustomer.AllowUserToResizeColumns = true;
                    dgvCustomer.AllowUserToResizeRows = true;
                    dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dgvCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    dgvCustomer.ScrollBars = ScrollBars.Both;
                    dgvCustomer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    // Add columns
                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "CustomerID",
                        HeaderText = "Customer ID",
                        DataPropertyName = "CustomerID",
                        Width = 80
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "FullName",
                        HeaderText = "Full Name",
                        DataPropertyName = "FullName",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Address",
                        HeaderText = "Address",
                        DataPropertyName = "Address",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "PhoneNumber",
                        HeaderText = "Phone Number",
                        DataPropertyName = "PhoneNumber",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Email",
                        HeaderText = "Email",
                        DataPropertyName = "Email",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }

                LoadCustomerData();
                LoadCustomerInfoByLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerInfoByLogin()
        {
            try
            {
                if (string.IsNullOrEmpty(currentLoginName)) return;

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
                    if (txtCustomerID != null) txtCustomerID.Text = row["CustomerID"].ToString();
                    if (txtFullName != null) txtFullName.Text = row["FullName"].ToString();
                    if (txtAddress != null) txtAddress.Text = row["Address"].ToString();
                    if (txtPhoneNumber != null) txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                    if (txtEmail != null) txtEmail.Text = row["Email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerData()
        {
            try
            {
                if (blCustomer == null)
                {
                    blCustomer = new BLCustomer();
                }

                DataSet ds = blCustomer.GetCustomers();
                if (ds != null && ds.Tables.Count > 0)
                {
                    allCustomers = ds.Tables[0];
                    dgvCustomer.DataSource = allCustomers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                           VALUES (N'{(txtCustomerID != null ? txtCustomerID.Text : string.Empty)}',N'{(txtFullName != null ? txtFullName.Text : string.Empty)}', N'{(txtAddress != null ? txtAddress.Text : string.Empty)}', N'{(txtPhoneNumber != null ? txtPhoneNumber.Text : string.Empty)}', N'{(txtEmail != null ? txtEmail.Text : string.Empty)}')";

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
            if (dgvCustomer != null && dgvCustomer.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Ensure cell value is not null before conversion
                    if (dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value == null)
                    {
                        MessageBox.Show("Cannot delete: Customer ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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

            if (dgvCustomer != null && dgvCustomer.SelectedRows.Count > 0)
            {
                // Ensure cell value is not null before conversion
                 if (dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value == null)
                    {
                        MessageBox.Show("Cannot update: Original Customer ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                int oldCustomerID = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value);
                int newCustomerID;

                if (txtCustomerID == null || !int.TryParse(txtCustomerID.Text, out newCustomerID))
                {
                    MessageBox.Show("Please enter a valid Customer ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string error = "";
                string sql = $@"UPDATE Customer 
                              SET CustomerID = {newCustomerID},
                                  FullName = N'{(txtFullName != null ? txtFullName.Text : string.Empty)}',
                                  Address = N'{(txtAddress != null ? txtAddress.Text : string.Empty)}',
                                  PhoneNumber = N'{(txtPhoneNumber != null ? txtPhoneNumber.Text : string.Empty)}',
                                  Email = N'{(txtEmail != null ? txtEmail.Text : string.Empty)}'
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
            if (txtFullName != null) txtFullName.Clear();
            if (txtAddress != null) txtAddress.Clear();
            if (txtPhoneNumber != null) txtPhoneNumber.Clear();
            if (txtEmail != null) txtEmail.Clear();
            if (txtCustomerID != null) txtCustomerID.Clear();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCustomer != null && dgvCustomer.Rows.Count > e.RowIndex)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                // Ensure column names match your DataTable/DataGridView and cells are not null
                if (dgvCustomer.Columns != null && row.Cells != null)
                {
                    if (dgvCustomer.Columns.Contains("CustomerID") && row.Cells["CustomerID"].Value != null)
                        if (txtCustomerID != null) txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("FullName") && row.Cells["FullName"].Value != null)
                        if (txtFullName != null) txtFullName.Text = row.Cells["FullName"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("Address") && row.Cells["Address"].Value != null)
                        if (txtAddress != null) txtAddress.Text = row.Cells["Address"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("PhoneNumber") && row.Cells["PhoneNumber"].Value != null)
                        if (txtPhoneNumber != null) txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("Email") && row.Cells["Email"].Value != null)
                        if (txtEmail != null) txtEmail.Text = row.Cells["Email"].Value.ToString() ?? "";
                }
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer != null && dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomer.SelectedRows[0];
                 if (dgvCustomer.Columns != null && row.Cells != null)
                {
                    if (dgvCustomer.Columns.Contains("CustomerID") && row.Cells["CustomerID"].Value != null)
                       if (txtCustomerID != null) txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("FullName") && row.Cells["FullName"].Value != null)
                       if (txtFullName != null) txtFullName.Text = row.Cells["FullName"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("Address") && row.Cells["Address"].Value != null)
                       if (txtAddress != null) txtAddress.Text = row.Cells["Address"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("PhoneNumber") && row.Cells["PhoneNumber"].Value != null)
                       if (txtPhoneNumber != null) txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString() ?? "";
                    if (dgvCustomer.Columns.Contains("Email") && row.Cells["Email"].Value != null)
                       if (txtEmail != null) txtEmail.Text = row.Cells["Email"].Value.ToString() ?? "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // Đặt tỷ lệ chiều rộng các cột
                if (dgvCustomer.Columns.Count >= 5)
                {
                    dgvCustomer.Columns["Customer ID"].Width = 80;  // Cột ID nhỏ hơn
                    dgvCustomer.Columns["Full Name"].Width = 150;
                    dgvCustomer.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvCustomer.Columns["Phone Number"].Width = 120;
                    dgvCustomer.Columns["Email"].Width = 180;
                }

                // Cho phép xuống dòng
                dgvCustomer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error configuring columns after data binding: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Adjust layout when the form is resized
            AdjustDataGridViewLayout();
        }

        private void AdjustDataGridViewLayout()
        {
            try
            {
                // Ensure dgvCustomer and its columns are ready
                if (dgvCustomer == null || dgvCustomer.Columns == null || dgvCustomer.Columns.Count == 0) return;

                // Apply layout settings
                dgvCustomer.Dock = DockStyle.None;
                dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; // Keep Bottom anchor for resizing
                dgvCustomer.AllowUserToResizeColumns = true;
                dgvCustomer.AllowUserToResizeRows = true;
                dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvCustomer.ScrollBars = ScrollBars.Both;
                dgvCustomer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Manually set column widths/AutoSizeMode
                if (dgvCustomer.Columns.Contains("CustomerID"))
                {
                    dgvCustomer.Columns["CustomerID"].Width = 120; // Set a specific width
                    dgvCustomer.Columns["CustomerID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                if (dgvCustomer.Columns.Contains("FullName"))
                    dgvCustomer.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgvCustomer.Columns.Contains("Address"))
                    dgvCustomer.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgvCustomer.Columns.Contains("PhoneNumber"))
                    dgvCustomer.Columns["PhoneNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgvCustomer.Columns.Contains("Email"))
                    dgvCustomer.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvCustomer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adjusting DataGridView layout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (comBoxSearch.SelectedItem == null)
                {
                    MessageBox.Show("Please select a search criteria!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string searchCriteria = comBoxSearch.SelectedItem.ToString();
                string searchValue = txtbtnSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchValue))
                {
                    // If search text is empty, show all records
                    dgvCustomer.DataSource = allCustomers;
                    return;
                }

                // Create a DataView to filter the data
                DataView dv = allCustomers.DefaultView;
                
                // Build the filter expression based on the selected criteria
                string filterExpression = "";
                switch (searchCriteria)
                {
                    case "CustomerID":
                        if (int.TryParse(searchValue, out int customerId))
                        {
                            filterExpression = $"CustomerID = {customerId}";
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid Customer ID number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "Full Name":
                        filterExpression = $"FullName LIKE '%{searchValue}%'";
                        break;
                    case "Address":
                        filterExpression = $"Address LIKE '%{searchValue}%'";
                        break;
                    case "PhoneNumber":
                        filterExpression = $"PhoneNumber LIKE '%{searchValue}%'";
                        break;
                    case "Email":
                        filterExpression = $"Email LIKE '%{searchValue}%'";
                        break;
                    default:
                        MessageBox.Show("Invalid search criteria!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Apply the filter
                dv.RowFilter = filterExpression;
                dgvCustomer.DataSource = dv;

                // If no results found, show message
                if (dv.Count == 0)
                {
                    MessageBox.Show("No matching records found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, reset to show all records after the message if no results found
                    // dv.RowFilter = ""; 
                    // dgvCustomer.DataSource = allCustomers; // Assign original data source
                } 
                // Always update the DataSource with the filtered DataView, even if empty, to show no results
                dgvCustomer.DataSource = dv;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error performing search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}