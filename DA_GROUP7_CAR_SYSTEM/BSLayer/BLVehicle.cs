using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Data;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLVehicle
    {
        DBMain db = new DBMain();

        // Lấy tất cả dữ liệu xe
        public DataSet GetVehicles()
        {
            string sql = "SELECT * FROM Vehicle";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Thêm xe mới
        public bool AddVehicle(int vehicleID, string vehicleName, string brand, string color, decimal price, int quantity, ref string error)
        {
            string sql = $"INSERT INTO Vehicle (VehicleID, VehicleName, Brand, Color, Price, Quantity) " +
                         $"VALUES ({vehicleID}, N'{vehicleName}', N'{brand}', N'{color}', {price}, {quantity})";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        // Cập nhật thông tin xe
        public bool UpdateVehicle(int vehicleID, string vehicleName, string brand, string color, decimal price, int quantity, ref string error)
        {
            string sql = $"UPDATE Vehicle SET " +
                         $"VehicleName = N'{vehicleName}', " +
                         $"Brand = N'{brand}', " +
                         $"Color = N'{color}', " +
                         $"Price = {price}, " +
                         $"Quantity = {quantity} " +
                         $"WHERE VehicleID = {vehicleID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        // Xoá xe theo VehicleID
        public bool DeleteVehicle(int vehicleID, ref string error)
        {
            string sql = $"DELETE FROM Vehicle WHERE VehicleID = {vehicleID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
