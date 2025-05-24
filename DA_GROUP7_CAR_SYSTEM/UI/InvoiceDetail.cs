using System;
using System.Data;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class InvoiceDetail : Form
    {
        private DBMain db = new DBMain();
        public InvoiceDetail()
        {
            InitializeComponent();
            if (!this.DesignMode)
                LoadInvoiceDetailData();

            // Attach DataBindingComplete event handler
            dgvInvoiceDetail.DataBindingComplete += dgvInvoiceDetail_DataBindingComplete;
        }

        private void LoadInvoiceDetailData()
        {
            try
            {
                string sql = "SELECT * FROM InvoiceDetail";
                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
                dgvInvoiceDetail.DataSource = ds.Tables[0];

                // Set the DataGridView to fill its container
                dgvInvoiceDetail.Dock = DockStyle.Fill;

                // Ensure the DataGridView stays within its container
                dgvInvoiceDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Column configuration will be done in DataBindingComplete event
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Error loading invoice detail data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInvoiceDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // Configure column widths and sizing after data binding is complete
                if (dgvInvoiceDetail.Columns.Contains("InvoiceID"))
                    dgvInvoiceDetail.Columns["InvoiceID"].Width = 80;
                if (dgvInvoiceDetail.Columns.Contains("VehicleID"))
                    dgvInvoiceDetail.Columns["VehicleID"].Width = 80;
                if (dgvInvoiceDetail.Columns.Contains("Quantity"))
                    dgvInvoiceDetail.Columns["Quantity"].Width = 80;
                if (dgvInvoiceDetail.Columns.Contains("UnitPrice"))
                    dgvInvoiceDetail.Columns["UnitPrice"].Width = 100;

                // Configure the DataGridView to fit within its container
                dgvInvoiceDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInvoiceDetail.AllowUserToResizeColumns = true;
                dgvInvoiceDetail.AllowUserToResizeRows = true;
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Error configuring invoice detail columns: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateDetailInputs(out string errorField)
        {
            errorField = "";
            if (string.IsNullOrWhiteSpace(txtInvoiceID.Text)) { errorField = "Invoice ID"; return false; }
            if (string.IsNullOrWhiteSpace(txtVehicleID.Text)) { errorField = "Vehicle ID"; return false; }
            if (!int.TryParse(txtQuantity.Text, out _)) { errorField = "Quantity"; return false; }
            if (!decimal.TryParse(txtUnitPrice.Text, out _)) { errorField = "Unit Price"; return false; }
            return true;
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (!ValidateDetailInputs(out string errorField))
            {
                MessageBox.Show($"Invalid input for: {errorField}", "Validation Error");
                return;
            }

            string checkSql = $"SELECT COUNT(*) FROM InvoiceDetail WHERE InvoiceID = {txtInvoiceID.Text} AND VehicleID = {txtVehicleID.Text}";
            DataSet ds = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
            if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) > 0)
            {
                MessageBox.Show("This invoice detail already exists.");
                return;
            }

            string sql = $"INSERT INTO InvoiceDetail (InvoiceID, VehicleID, Quantity, UnitPrice) VALUES ({txtInvoiceID.Text}, {txtVehicleID.Text}, {txtQuantity.Text}, {txtUnitPrice.Text})";
            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Invoice detail added.");
                LoadInvoiceDetailData();
                ClearInputs();
            }
            else MessageBox.Show("Error: " + error);
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetail.SelectedRows.Count == 0) return;
            var row = dgvInvoiceDetail.SelectedRows[0];
            txtInvoiceID.Text = row.Cells["InvoiceID"].Value.ToString();
            txtVehicleID.Text = row.Cells["VehicleID"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
        }

        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            if (!ValidateDetailInputs(out string errorField))
            {
                MessageBox.Show($"Invalid input for: {errorField}", "Validation Error");
                return;
            }

            int invoiceID = int.Parse(txtInvoiceID.Text);
            int vehicleID = int.Parse(txtVehicleID.Text);
            string sql = $"UPDATE InvoiceDetail SET Quantity = {txtQuantity.Text}, UnitPrice = {txtUnitPrice.Text} WHERE InvoiceID = {invoiceID} AND VehicleID = {vehicleID}";
            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Invoice detail updated.");
                LoadInvoiceDetailData();
                ClearInputs();
            }
            else MessageBox.Show("Error: " + error);
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetail.SelectedRows.Count == 0) return;
            int invoiceID = Convert.ToInt32(dgvInvoiceDetail.SelectedRows[0].Cells["InvoiceID"].Value);
            int vehicleID = Convert.ToInt32(dgvInvoiceDetail.SelectedRows[0].Cells["VehicleID"].Value);
            string sql = $"DELETE FROM InvoiceDetail WHERE InvoiceID = {invoiceID} AND VehicleID = {vehicleID}";
            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Invoice detail deleted.");
                LoadInvoiceDetailData();
                ClearInputs();
            }
            else MessageBox.Show("Error: " + error);
        }

        private void ClearInputs()
        {
            txtInvoiceID.Clear();
            txtVehicleID.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
        }
    }
}
