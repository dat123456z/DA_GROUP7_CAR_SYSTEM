using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLCustomer
    {
        DBMain db = new DBMain();

        public DataSet GetCustomers()
        {
            string sql = "SELECT * FROM Customer";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public bool AddCustomer(string fullName, string address, string phoneNumber, string email, ref string error)
        {
            string sql = $"INSERT INTO Customer (FullName, Address, PhoneNumber, Email) VALUES (N'{fullName}', N'{address}', N'{phoneNumber}', N'{email}')";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public bool UpdateCustomer(int customerID, string fullName, string address, string phoneNumber, string email, ref string error)
        {
            string sql = $"UPDATE Customer SET FullName = N'{fullName}', Address = N'{address}', PhoneNumber = N'{phoneNumber}', Email = N'{email}' WHERE CustomerID = {customerID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public bool DeleteCustomer(int customerID, ref string error)
        {
            string sql = $"DELETE FROM Customer WHERE CustomerID = {customerID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
