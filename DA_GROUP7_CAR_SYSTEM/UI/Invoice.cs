using System;
using System.Data;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class Invoice : Form
    {
        private DBMain db = new DBMain();

        public Invoice()
        {
            InitializeComponent();
            if (!this.DesignMode)
                LoadInvoiceData();
        }

        private void LoadInvoiceData()
        {
            string sql = "SELECT * FROM Invoice";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            dgvInvoice.DataSource = ds.Tables[0];
        }

        private bool ValidateInvoiceInputs(out string errorField)
        {
            errorField = "";
            if (string.IsNullOrWhiteSpace(txtInvoiceID.Text)) { errorField = "Invoice ID"; return false; }
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text)) { errorField = "Customer ID"; return false; }
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text)) { errorField = "Employee ID"; return false; }
            if (!decimal.TryParse(txtTotalAmount.Text, out _)) { errorField = "Total Amount"; return false; }
            return true;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (!ValidateInvoiceInputs(out string errorField))
            {
                MessageBox.Show($"Invalid input for: {errorField}", "Validation Error");
                return;
            }

            int id = int.Parse(txtInvoiceID.Text);
            string checkSql = $"SELECT COUNT(*) FROM Invoice WHERE InvoiceID = {id}";
            DataSet ds = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
            if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) > 0)
            {
                MessageBox.Show("Invoice ID already exists.");
                return;
            }

            string sql = $"INSERT INTO Invoice VALUES ({id}, '{dtpInvoiceDate.Value:yyyy-MM-dd}', {txtCustomerID.Text}, {txtEmployeeID.Text}, {txtTotalAmount.Text})";
            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Invoice added.");
                LoadInvoiceData();
                ClearInputs();
            }
            else MessageBox.Show("Error: " + error);
        }

        private void btnUpdateInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.SelectedRows.Count == 0) return;
            var row = dgvInvoice.SelectedRows[0];
            txtInvoiceID.Text = row.Cells["InvoiceID"].Value.ToString();
            txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
            txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
            txtTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();
            dtpInvoiceDate.Value = Convert.ToDateTime(row.Cells["InvoiceDate"].Value);
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.SelectedRows.Count == 0) return;
            if (!ValidateInvoiceInputs(out string errorField))
            {
                MessageBox.Show($"Invalid input for: {errorField}", "Validation Error");
                return;
            }

            int id = Convert.ToInt32(dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value);
            string sql = $"UPDATE Invoice SET InvoiceDate = '{dtpInvoiceDate.Value:yyyy-MM-dd}', CustomerID = {txtCustomerID.Text}, EmployeeID = {txtEmployeeID.Text}, TotalAmount = {txtTotalAmount.Text} WHERE InvoiceID = {id}";
            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Invoice updated.");
                LoadInvoiceData();
                ClearInputs();
            }
            else MessageBox.Show("Error: " + error);
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value);
            string sql = $"DELETE FROM Invoice WHERE InvoiceID = {id}";
            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Invoice deleted.");
                LoadInvoiceData();
                ClearInputs();
            }
            else MessageBox.Show("Error: " + error);
        }

        private void ClearInputs()
        {
            txtInvoiceID.Clear();
            txtCustomerID.Clear();
            txtEmployeeID.Clear();
            txtTotalAmount.Clear();
        }
    }
}