using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.BSLayer;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class VehicleFr : Form
    {
        private DBMain db = new DBMain();
        private BLVehicle blVehicle = new BLVehicle();

        private BLBrand blBrand = new BLBrand();
        private int? selectedBrandID = null;
        public VehicleFr()
        {
            InitializeComponent();
            if (!this.DesignMode)
                LoadVehicleData();
            LoadBrandComboBox();
            LoadBrandData();
        }

        private void LoadVehicleData()
        {
            try
            {
                string sql = @"SELECT V.VehicleID, V.VehicleName, B.BrandName AS Brand, V.Color, V.Price, V.Quantity
                       FROM Vehicle V INNER JOIN Brand B ON V.BrandID = B.BrandID";
                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
                dgvVehicle.DataSource = ds.Tables[0];
                dgvVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }
        private void LoadBrandData()
        {
            try
            {
                DataSet ds = blBrand.GetAllBrands();
                dgvBrand.DataSource = ds.Tables[0];
                dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading brands: " + ex.Message);
            }
        }


        private void LoadBrandComboBox()
        {
            string sql = "SELECT BrandID, BrandName FROM Brand";
            DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
            Cbb_Brand.DataSource = ds.Tables[0];
            Cbb_Brand.DisplayMember = "BrandName";
            Cbb_Brand.ValueMember = "BrandID";
            // Gán cho ComboBox lọc
            cboBrandFilter.DataSource = ds.Tables[0].Copy(); // dùng Copy() để tránh xung đột binding
            cboBrandFilter.DisplayMember = "BrandName";
            cboBrandFilter.ValueMember = "BrandID";
            cboBrandFilter.SelectedIndex = -1;
        }


        private bool ValidateVehicleInputs(out string errorField)
        {
            errorField = "";

            if (string.IsNullOrWhiteSpace(txtVehicleName.Text))
            {
                errorField = "Vehicle Name";
                return false;
            }

            if (Cbb_Brand.SelectedIndex < 0)
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
                errorField = "Price (invalid)";
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                errorField = "Quantity (invalid)";
                return false;
            }

            return true;
        }


        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if (!ValidateVehicleInputs(out string errorField))
            {
                MessageBox.Show($"Invalid input: {errorField}");
                return;
            }

            string name = txtVehicleName.Text;
            int brandID = (int)Cbb_Brand.SelectedValue;
            string color = txtColor.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            string sql = $@"INSERT INTO Vehicle (VehicleName, BrandID, Color, Price, Quantity)
                    VALUES (N'{name}', {brandID}, N'{color}', {price}, {quantity})";

            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Vehicle added successfully!");
                LoadVehicleData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }




        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvVehicle.SelectedRows[0];
                txtVehicleName.Text = row.Cells["VehicleName"].Value?.ToString();
                Cbb_Brand.Text = row.Cells["Brand"].Value?.ToString();
                txtColor.Text = row.Cells["Color"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Please select a vehicle to edit.");
            }
        }


        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vehicle to update.");
                return;
            }

            if (!ValidateVehicleInputs(out string errorField))
            {
                MessageBox.Show($"Invalid input in: {errorField}");
                return;
            }

            int vehicleID = Convert.ToInt32(dgvVehicle.SelectedRows[0].Cells["VehicleID"].Value);
            string name = txtVehicleName.Text;
            int brandID = (int)Cbb_Brand.SelectedValue;
            string color = txtColor.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            string sql = $@"UPDATE Vehicle 
                    SET VehicleName = N'{name}', 
                        BrandID = {brandID}, 
                        Color = N'{color}', 
                        Price = {price}, 
                        Quantity = {quantity} 
                    WHERE VehicleID = {vehicleID}";

            string error = "";
            if (db.MyExecuteNonQuery(sql, CommandType.Text, ref error))
            {
                MessageBox.Show("Vehicle updated successfully!");
                LoadVehicleData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Error: " + error);
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

        }


        private void ClearInputs()
        {
            txtVehicleName.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            Cbb_Brand.SelectedIndex = -1;
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            int? brandID = null;
            if (cboBrandFilter.SelectedIndex >= 0)
                brandID = (int)cboBrandFilter.SelectedValue;

            string color = txtColorFilter.Text.Trim();

            decimal? priceMin = null, priceMax = null;
            if (decimal.TryParse(txtPriceMin.Text, out decimal min))
                priceMin = min;
            if (decimal.TryParse(txtPriceMax.Text, out decimal max))
                priceMax = max;

            try
            {
                DataSet ds = blVehicle.FilterVehicles(brandID, color, priceMin, priceMax);
                dgvVehicle.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }

        private void btn_Addbrand_Click(object sender, EventArgs e)
        {
            string name = txt_Brandname.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Brand name cannot be empty.");
                return;
            }

            string error = "";
            if (blBrand.AddBrand(name, ref error))
            {
                MessageBox.Show("Brand added successfully.");
                LoadBrandData();
                txt_Brandname.Clear();
            }
            else
            {
                MessageBox.Show("Error adding brand: " + error);
            }
        }

        private void btn_Updatebrand_Click(object sender, EventArgs e)
        {
            if (dgvBrand.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBrand.SelectedRows[0];
                selectedBrandID = Convert.ToInt32(row.Cells["BrandID"].Value);
                txt_Brandname.Text = row.Cells["BrandName"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Please select a brand to update.");
            }
        }

        private void btn_Savebrand_Click(object sender, EventArgs e)
        {
            if (selectedBrandID == null)
            {
                MessageBox.Show("No brand selected for update.");
                return;
            }

            string name = txt_Brandname.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Brand name cannot be empty.");
                return;
            }

            string error = "";
            if (blBrand.UpdateBrand(selectedBrandID.Value, name, ref error))
            {
                MessageBox.Show("Brand updated successfully.");
                LoadBrandData();
                txt_Brandname.Clear();
                selectedBrandID = null;
            }
            else
            {
                MessageBox.Show("Error updating brand: " + error);
            }
        }
        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
