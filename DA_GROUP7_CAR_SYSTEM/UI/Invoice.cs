using System;
using System.Data;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.BSLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class Invoice : Form
    {
        private BLInvoice blInvoice = new BLInvoice();

        public Invoice()
        {
            InitializeComponent();
            if (!this.DesignMode)
                LoadInvoiceData();

            // Attach DataBindingComplete event handler
            dgvInvoice.DataBindingComplete += dgvInvoice_DataBindingComplete;
        }

        private void LoadInvoiceData()
        {
            try
            {
                DataSet ds = blInvoice.GetInvoices();
                dgvInvoice.DataSource = ds.Tables[0];

                // Set the DataGridView to fill its container
                dgvInvoice.Dock = DockStyle.Fill;

                // Ensure the DataGridView stays within its container
                dgvInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInvoice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // Configure the DataGridView to fit within its container
                dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInvoice.AllowUserToResizeColumns = true;
                dgvInvoice.AllowUserToResizeRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error configuring invoice columns: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInvoiceInputs(out string errorField)
        {
            errorField = "";
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

            int customerID = int.Parse(txtCustomerID.Text);
            int employeeID = int.Parse(txtEmployeeID.Text);
            decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
            DateTime invoiceDate = dtpInvoiceDate.Value;

            string error = "";
            if (blInvoice.AddInvoice( invoiceDate, customerID, employeeID, totalAmount, ref error))
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
            //txtInvoiceID.Text = row.Cells["InvoiceID"].Value.ToString();
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

            int invoiceID = Convert.ToInt32(dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value);
            int customerID = int.Parse(txtCustomerID.Text);
            int employeeID = int.Parse(txtEmployeeID.Text);
            decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
            DateTime invoiceDate = dtpInvoiceDate.Value;

            string error = "";
            if (blInvoice.UpdateInvoice(invoiceID, invoiceDate, customerID, employeeID, totalAmount, ref error))
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
            int invoiceID = Convert.ToInt32(dgvInvoice.SelectedRows[0].Cells["InvoiceID"].Value);
            
            string error = "";
            if (blInvoice.DeleteInvoice(invoiceID, ref error))
            {
                MessageBox.Show("Invoice deleted.");
                LoadInvoiceData();
                ClearInputs();
            }
            else MessageBox.Show("Error: " + error);
        }

        private void ClearInputs()
        {
            txtCustomerID.Clear();
            txtEmployeeID.Clear();
            txtTotalAmount.Clear();
        }
    }
}