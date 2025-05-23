using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Data;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLInvoice
    {
        DBMain db = new DBMain();

        public DataSet GetInvoices()
        {
            string sql = "SELECT * FROM Invoice";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public bool AddInvoice(int invoiceID, DateTime invoiceDate, int customerID, int employeeID, decimal totalAmount, ref string error)
        {
            string sql = $"INSERT INTO Invoice (InvoiceID, InvoiceDate, CustomerID, EmployeeID, TotalAmount) " +
                         $"VALUES ({invoiceID}, '{invoiceDate:yyyy-MM-dd}', {customerID}, {employeeID}, {totalAmount})";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public bool UpdateInvoice(int invoiceID, DateTime invoiceDate, int customerID, int employeeID, decimal totalAmount, ref string error)
        {
            string sql = $"UPDATE Invoice SET " +
                         $"InvoiceDate = '{invoiceDate:yyyy-MM-dd}', " +
                         $"CustomerID = {customerID}, " +
                         $"EmployeeID = {employeeID}, " +
                         $"TotalAmount = {totalAmount} " +
                         $"WHERE InvoiceID = {invoiceID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public bool DeleteInvoice(int invoiceID, ref string error)
        {
            string sql = $"DELETE FROM Invoice WHERE InvoiceID = {invoiceID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
