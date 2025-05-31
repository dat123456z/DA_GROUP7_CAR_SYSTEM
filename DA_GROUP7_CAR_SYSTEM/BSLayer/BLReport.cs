using System;
using System.Data;
using System.Data.SqlClient;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    public class BLReport
    {
        private readonly DBMain db = new DBMain();

        // 1. Báo cáo lương theo tháng và năm
        public DataTable GetSalaryReport(int month, int year)
        {
            string sql = $@"
                SELECT 
                    E.EmployeeID,
                    E.FullName,
                    E.Position,
                    P.BasicSalary,
                    ISNULL(SUM(I.TotalAmount), 0) AS TotalSales,
                    CASE 
                        WHEN ISNULL(SUM(I.TotalAmount), 0) >= 100000000 THEN 1 ELSE 0
                    END AS KPIAchieved,
                    CASE 
                        WHEN ISNULL(SUM(I.TotalAmount), 0) >= 100000000 THEN 1000000 ELSE 0
                    END AS Bonus,
                    P.BasicSalary + 
                    CASE 
                        WHEN ISNULL(SUM(I.TotalAmount), 0) >= 100000000 THEN 1000000 ELSE 0
                    END AS TotalSalary
                FROM Employee E
                JOIN Position P ON E.Position = P.PositionName
                LEFT JOIN Invoice I 
                    ON E.EmployeeID = I.EmployeeID 
                    AND MONTH(I.InvoiceDate) = {month} 
                    AND YEAR(I.InvoiceDate) = {year}
                GROUP BY E.EmployeeID, E.FullName, E.Position, P.BasicSalary";

            return db.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
        }

        // 2. Báo cáo hóa đơn theo tháng và năm
        public DataTable GetInvoiceReport(int month, int year)
        {
            string sql = $@"
                SELECT 
                    I.InvoiceID,
                    I.InvoiceDate,
                    C.FullName AS CustomerName,
                    E.FullName AS EmployeeName,
                    I.TotalAmount
                FROM Invoice I
                JOIN Customer C ON I.CustomerID = C.CustomerID
                JOIN Employee E ON I.EmployeeID = E.EmployeeID
                WHERE MONTH(I.InvoiceDate) = {month} AND YEAR(I.InvoiceDate) = {year}
                ORDER BY I.InvoiceDate";

            return db.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
        }
    }
}
