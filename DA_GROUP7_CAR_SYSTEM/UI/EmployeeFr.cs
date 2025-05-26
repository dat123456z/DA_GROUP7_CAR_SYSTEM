using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.BSLayer;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class EmployeeFr : Form
    {
        private DBMain db = new DBMain();
        private BLEmployee blEmployee = new BLEmployee();
        private BLSalary blSalary = new BLSalary();

        public EmployeeFr()
        {
            InitializeComponent();
            if (!this.DesignMode)
                LoadEmployeeData();
            this.Load += Loadsalary;

        }

        private void LoadEmployeeData()
        {
            try
            {
                DataSet ds = blEmployee.GetEmployees();
                dgvEmployee.DataSource = ds.Tables[0];
                dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private bool ValidateEmployeeInputs(out string errorField)
        {
            errorField = "";


            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorField = "Full Name";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                errorField = "Position";
                return false;
            }

            // Kiểm tra số điện thoại: phải 10 chữ số, bắt đầu bằng 0
            string phone = txtPhoneNumber.Text.Trim();
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0\d{9}$"))
            {
                errorField = "Phone Number (must be 10 digits and start with 0)";
                return false;
            }

            // Kiểm tra email phải kết thúc bằng @gmail.com
            string email = txtEmail.Text.Trim().ToLower();
            if (!email.EndsWith("@gmail.com"))
            {
                errorField = "Email (must end with @gmail.com)";
                return false;
            }

            return true;
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeInputs(out string errorField))
            {
                MessageBox.Show($"Please enter the correct information for the field: {errorField}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error = "";
            if (blEmployee.AddEmployee(txtFullName.Text, txtPosition.Text, txtPhoneNumber.Text, txtEmail.Text, ref error))
            {
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Error adding employee: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update!");
                return;
            }

            if (!ValidateEmployeeInputs(out string errorField))
            {
                MessageBox.Show($"Please enter the correct information for the field: {errorField}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["EmployeeID"].Value);
            string error = "";

            if (blEmployee.UpdateEmployee(employeeID, txtFullName.Text, txtPosition.Text, txtPhoneNumber.Text, txtEmail.Text, ref error))
            {
                MessageBox.Show("Employee update successful!");
                LoadEmployeeData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Update error: " + error);
            }

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtPosition.Text = row.Cells["Position"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select an employee to edit!");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete!");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int employeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["EmployeeID"].Value);
                string error = "";

                if (blEmployee.DeleteEmployee(employeeID, ref error))
                {
                    MessageBox.Show("Deleted successfully!");
                    LoadEmployeeData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Deletion error: " + error);
                }

            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
           
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtPosition.Text = row.Cells["Position"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
        }

        private void ClearInputs()
        {
            
            txtFullName.Clear();
            txtPosition.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }


        
        private void btn_CalculateSalary_Click(object sender, EventArgs e)
        {
            dgvSalary.Visible= true;
            label2.Visible= true;
            int month = int.Parse(cbbMonth.SelectedItem.ToString());
            int year = int.Parse(cbbYear.SelectedItem.ToString());

            DataSet ds = blSalary.GetMonthlySalary(month, year);
            dgvSalary.DataSource = ds.Tables[0];
            dgvSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSalary.AllowUserToResizeColumns = false;
        }
        private void Loadsalary(object sender, EventArgs e)
        {
            for (int m = 1; m <= 12; m++) cbbMonth.Items.Add(m);
            for (int y = 2020; y <= DateTime.Now.Year; y++) cbbYear.Items.Add(y);

            cbbMonth.SelectedItem = DateTime.Now.Month;
            cbbYear.SelectedItem = DateTime.Now.Year;
        }

        private void btn_SaveSalary_Click(object sender, EventArgs e)
        {
            int month = int.Parse(cbbMonth.SelectedItem.ToString());
            int year = int.Parse(cbbYear.SelectedItem.ToString());

            try
            {
                blSalary.SaveMonthlySalary(month, year);
                MessageBox.Show("Payroll saved to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payroll: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvSalary.Visible = false;
            label2.Visible = false;
        }
    }
}