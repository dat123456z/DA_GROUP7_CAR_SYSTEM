using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Data;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLVehicle
    {
        DBMain db = new DBMain();

        // Lấy tất cả dữ liệu xe (hiển thị thêm tên hãng từ bảng Brand)
        public DataSet GetVehicles()
        {
            string sql = @"SELECT V.VehicleID, V.VehicleName, B.BrandName, V.Color, V.Price, V.Quantity
                           FROM Vehicle V
                           INNER JOIN Brand B ON V.BrandID = B.BrandID";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Thêm xe mới (KHÔNG truyền VehicleID, truyền BrandID thay vì BrandName)
        public bool AddVehicle(string vehicleName, int brandID, string color, decimal price, int quantity, ref string error)
        {
            string sql = $"INSERT INTO Vehicle (VehicleName, BrandID, Color, Price, Quantity) " +
                         $"VALUES (N'{vehicleName}', {brandID}, N'{color}', {price}, {quantity})";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        // Cập nhật xe (truyền VehicleID để xác định xe cần sửa)
        public bool UpdateVehicle(int vehicleID, string vehicleName, int brandID, string color, decimal price, int quantity, ref string error)
        {
            string sql = $"UPDATE Vehicle SET " +
                         $"VehicleName = N'{vehicleName}', " +
                         $"BrandID = {brandID}, " +
                         $"Color = N'{color}', " +
                         $"Price = {price}, " +
                         $"Quantity = {quantity} " +
                         $"WHERE VehicleID = {vehicleID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
        // Lọc xe theo brandID, màu và khoảng giá
        public DataSet FilterVehicles(int? brandID, string color, decimal? priceMin, decimal? priceMax)
        {
            string sql = @"SELECT V.VehicleID, V.VehicleName, B.BrandName, V.Color, V.Price, V.Quantity
                   FROM Vehicle V INNER JOIN Brand B ON V.BrandID = B.BrandID WHERE 1=1";

            // Lọc theo hãng
            if (brandID.HasValue && brandID.Value > 0)
                sql += $" AND V.BrandID = {brandID.Value}";

            // Lọc theo màu
            if (!string.IsNullOrWhiteSpace(color))
                sql += $" AND V.Color LIKE N'%{color.Trim()}%'";

            // Lọc theo giá
            if (priceMin.HasValue)
                sql += $" AND V.Price >= {priceMin.Value}";
            if (priceMax.HasValue)
                sql += $" AND V.Price <= {priceMax.Value}";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Xóa xe theo VehicleID
        public bool DeleteVehicle(int vehicleID, ref string error)
        {
            string sql = $"DELETE FROM Vehicle WHERE VehicleID = {vehicleID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
