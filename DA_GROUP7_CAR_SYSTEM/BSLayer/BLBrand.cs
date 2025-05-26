using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
     class BLBrand
    {
        DBMain db = new DBMain();

        // Lấy toàn bộ Brand
        public DataSet GetAllBrands()
        {
            string sql = "SELECT * FROM Brand";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Thêm hãng xe mới
        public bool AddBrand(string brandName, ref string error)
        {
            string sql = $"INSERT INTO Brand (BrandName) VALUES (N'{brandName}')";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        // Cập nhật tên hãng
        public bool UpdateBrand(int brandID, string newBrandName, ref string error)
        {
            string sql = $"UPDATE Brand SET BrandName = N'{newBrandName}' WHERE BrandID = {brandID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        
    
}
}
