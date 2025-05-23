using System;
using System.Data;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class EmployeeFr : Form
    {
        private DBMain db = new DBMain();

        public EmployeeFr()
        {
            InitializeComponent();
            if (!this.DesignMode)
                LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                string sql = "SELECT * FROM Employee";
                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
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

            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                errorField = "Employee ID";
                return false;
            }

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
                errorField = "Phone Number (phải có 10 chữ số và bắt đầu bằng 0)";
                return false;
            }

            // Kiểm tra email phải kết thúc bằng @gmail.com
            string email = txtEmail.Text.Trim().ToLower();
            if (!email.EndsWith("@gmail.com"))
            {
                errorField = "Email (phải kết thúc bằng @gmail.com)";
                return false;
            }

            return true;
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeInputs(out string errorField))
            {
                MessageBox.Show($"Vui lòng nhập đúng thông tin trường: {errorField}", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newID = int.Parse(txtEmployeeID.Text);
            string checkSql = $"SELECT COUNT(*) FROM Employee WHERE EmployeeID = {newID}";
            DataSet ds = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
            int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Employee ID đã tồn tại. Vui lòng nhập ID khác.", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $@"INSERT INTO Employee (EmployeeID, FullName, Position, PhoneNumber, Email)
                            VALUES ({txtEmployeeID.Text}, N'{txtFullName.Text}', N'{txtPosition.Text}', 
                                    N'{txtPhoneNumber.Text}', N'{txtEmail.Text}')";

            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadEmployeeData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để cập nhật!");
                return;
            }

            if (!ValidateEmployeeInputs(out string errorField))
            {
                MessageBox.Show($"Vui lòng nhập đúng thông tin trường: {errorField}", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int oldID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["EmployeeID"].Value);
            int newID = int.Parse(txtEmployeeID.Text);

            if (newID != oldID)
            {
                string checkSql = $"SELECT COUNT(*) FROM Employee WHERE EmployeeID = {newID}";
                DataSet ds = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                if (count > 0)
                {
                    MessageBox.Show("Employee ID mới đã tồn tại. Không thể cập nhật.", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string sql = $@"UPDATE Employee
                            SET EmployeeID = {newID},
                                FullName = N'{txtFullName.Text}',
                                Position = N'{txtPosition.Text}',
                                PhoneNumber = N'{txtPhoneNumber.Text}',
                                Email = N'{txtEmail.Text}'
                            WHERE EmployeeID = {oldID}";

            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Cập nhật nhân viên thành công!");
                LoadEmployeeData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtPosition.Text = row.Cells["Position"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int employeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["EmployeeID"].Value);
                string sql = $"DELETE FROM Employee WHERE EmployeeID = {employeeID}";

                string error = "";
                if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadEmployeeData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtPosition.Text = row.Cells["Position"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
        }

        private void ClearInputs()
        {
            txtEmployeeID.Clear();
            txtFullName.Clear();
            txtPosition.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }
    }
}