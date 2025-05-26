using System;
using System.Data;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    public class BLSalary
    {
        DBMain db = new DBMain();

        public DataSet GetMonthlySalary(int month, int year)
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
                        WHEN ISNULL(SUM(I.TotalAmount), 0) >= 100000000 THEN P.BasicSalary + 1000000
                        ELSE P.BasicSalary
                    END AS TotalSalary
                FROM Employee E
                JOIN Position P ON E.Position = P.PositionName
                LEFT JOIN Invoice I ON E.EmployeeID = I.EmployeeID
                    AND MONTH(I.InvoiceDate) = {month}
                    AND YEAR(I.InvoiceDate) = {year}
                GROUP BY E.EmployeeID, E.FullName, E.Position, P.BasicSalary";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public void SaveMonthlySalary(int month, int year)
        {
            string sql = $@"
    INSERT INTO EmployeeSalary (EmployeeID, Month, Year, BasicSalary, KPIAchieved)
    SELECT 
        E.EmployeeID,
        {month},
        {year},
        P.BasicSalary,
        CASE 
            WHEN ISNULL(SUM(I.TotalAmount), 0) >= 100000000 THEN 1 ELSE 0
        END AS KPIAchieved
    FROM Employee E
    JOIN Position P ON E.Position = P.PositionName
    LEFT JOIN Invoice I ON E.EmployeeID = I.EmployeeID
        AND MONTH(I.InvoiceDate) = {month}
        AND YEAR(I.InvoiceDate) = {year}
    GROUP BY E.EmployeeID, P.BasicSalary";

            string error = "";
            db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

    }
}
