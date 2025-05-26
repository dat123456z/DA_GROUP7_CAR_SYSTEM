using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Data;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLEmployee
    {
        DBMain db = new DBMain();

        // Lấy tất cả dữ liệu nhân viên
        public DataSet GetEmployees()
        {
            string sql = @"
            SELECT EmployeeID, FullName, Position, PhoneNumber, Email
            FROM Employee
            WHERE IsActive = 1";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }


        // Thêm nhân viên mới
        public bool AddEmployee(string fullName, string position, string phoneNumber, string email, ref string error)
        {
            string sql = $"INSERT INTO Employee (FullName, Position, PhoneNumber, Email) " +
                         $"VALUES (N'{fullName}', N'{position}', N'{phoneNumber}', N'{email}')";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }


        // Cập nhật thông tin nhân viên
        public bool UpdateEmployee(int employeeID, string fullName, string position, string phoneNumber, string email, ref string error)
        {
            string sql = $"UPDATE Employee SET " +
                         $"FullName = N'{fullName}', " +
                         $"Position = N'{position}', " +
                         $"PhoneNumber = N'{phoneNumber}', " +
                         $"Email = N'{email}' " +
                         $"WHERE EmployeeID = {employeeID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        // Xoá nhân viên theo EmployeeID
        public bool DeleteEmployee(int employeeID, ref string error)
        {
            string sql = $"UPDATE Employee SET IsActive = 0 WHERE EmployeeID = {employeeID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

    }
}
