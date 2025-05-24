using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class VehicleFr : Form
    {
        private DBMain db = new DBMain();

        public VehicleFr()
        {
            InitializeComponent();
            if (!this.DesignMode)
                LoadVehicleData();
        }

        private void LoadVehicleData()
        {
            try
            {
                string sql = "SELECT * FROM Vehicle";
                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
                dgvVehicle.DataSource = ds.Tables[0];
                dgvVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateVehicleInputs(out string errorField)
        {
            errorField = "";

            if (string.IsNullOrWhiteSpace(txtVehicleID.Text))
            {
                errorField = "Vehicle ID";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVehicleName.Text))
            {
                errorField = "Vehicle Name";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                errorField = "Brand";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                errorField = "Color";
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                errorField = "Price (invalid number)";
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                errorField = "Quantity (invalid number)";
                return false;
            }

            return true;
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if (!ValidateVehicleInputs(out string errorField))
            {
                MessageBox.Show($"Please enter the correct information for the field: {errorField}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newID = int.Parse(txtVehicleID.Text);
            string checkSql = $"SELECT COUNT(*) FROM Vehicle WHERE VehicleID = {newID}";
            DataSet dsCheck = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
            int count = Convert.ToInt32(dsCheck.Tables[0].Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Vehicle ID already exists. Please enter a different ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $@"INSERT INTO Vehicle (VehicleID, VehicleName, Brand, Color, Price, Quantity)
                    VALUES ({txtVehicleID.Text}, N'{txtVehicleName.Text}', N'{txtBrand.Text}', 
                            N'{txtColor.Text}', {txtPrice.Text}, {txtQuantity.Text})";

            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Add vehicle successfully!");
                LoadVehicleData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Error: " + error);
            }
        }



        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvVehicle.SelectedRows[0];
                txtVehicleID.Text = row.Cells["VehicleID"].Value?.ToString() ?? "";
                txtVehicleName.Text = row.Cells["VehicleName"].Value?.ToString() ?? "";
                txtBrand.Text = row.Cells["Brand"].Value?.ToString() ?? "";
                txtColor.Text = row.Cells["Color"].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a vehicle to update!");
            }
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vehicle to save changes!");
                return;
            }

            if (!ValidateVehicleInputs(out string errorField))
            {
                MessageBox.Show($"Please enter the correct information for the field: {errorField}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int oldID = Convert.ToInt32(dgvVehicle.SelectedRows[0].Cells["VehicleID"].Value);
            int newID = int.Parse(txtVehicleID.Text);

            if (newID != oldID)
            {
                string checkSql = $"SELECT COUNT(*) FROM Vehicle WHERE VehicleID = {newID}";
                DataSet dsCheck = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
                int count = Convert.ToInt32(dsCheck.Tables[0].Rows[0][0]);

                if (count > 0)
                {
                    MessageBox.Show("New Vehicle ID already exists. Cannot update with duplicate ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string sql = $@"UPDATE Vehicle
                    SET VehicleID = {newID},
                        VehicleName = N'{txtVehicleName.Text}',
                        Brand = N'{txtBrand.Text}',
                        Color = N'{txtColor.Text}',
                        Price = {txtPrice.Text},
                        Quantity = {txtQuantity.Text}
                    WHERE VehicleID = {oldID}";

            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Update vehicle successfully!");
                LoadVehicleData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }



        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vehicle to delete!");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int vehicleID = Convert.ToInt32(dgvVehicle.SelectedRows[0].Cells["VehicleID"].Value);
                    string sql = $"DELETE FROM Vehicle WHERE VehicleID = {vehicleID}";

                    string error = "";
                    if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
                    {
                        MessageBox.Show("Vehicle deleted successfully!");
                        LoadVehicleData();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting vehicle: " + ex.Message);
                }
            }
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehicle.Rows[e.RowIndex];
                txtVehicleID.Text = row.Cells["VehicleID"].Value?.ToString() ?? "";
                txtVehicleName.Text = row.Cells["VehicleName"].Value?.ToString() ?? "";
                txtBrand.Text = row.Cells["Brand"].Value?.ToString() ?? "";
                txtColor.Text = row.Cells["Color"].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString() ?? "";
            }
        }

        private void ClearInputs()
        {
            txtVehicleID.Clear();
            txtVehicleName.Clear();
            txtBrand.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
    }
}
