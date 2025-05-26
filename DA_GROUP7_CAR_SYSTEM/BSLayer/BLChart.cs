using System.Data;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    public class BLChart
    {
        private DBMain db = new DBMain();

        
        public DataTable GetVehicleLeftByBrand()
        {
            string sql = @"
        SELECT B.BrandName AS Brand, SUM(V.Quantity) AS StockLeft
        FROM Vehicle V
        JOIN Brand B ON V.BrandID = B.BrandID
        GROUP BY B.BrandName
        ORDER BY StockLeft DESC";

            return db.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
        }



        // Biểu đồ màu sắc xe trong kho
        public DataTable GetVehicleCountByColor()
        {
            string sql = @"
                SELECT Color, COUNT(*) AS SoLuong
                FROM Vehicle
                GROUP BY Color
                ORDER BY SoLuong DESC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
        }
        public DataTable GetSalesCountByEmployee()
        {
            string sql = @"
        SELECT E.FullName, COUNT(I.InvoiceID) AS SalesCount
        FROM Employee E
        JOIN Invoice I ON E.EmployeeID = I.EmployeeID
        GROUP BY E.FullName
        ORDER BY SalesCount DESC";

            return db.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
        }

    }
}
