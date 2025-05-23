using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Data;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLInvoiceDetail
    {
        DBMain db = new DBMain();

        public DataSet GetInvoiceDetails()
        {
            string sql = "SELECT * FROM InvoiceDetail";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public bool AddInvoiceDetail(int invoiceID, int vehicleID, int quantity, decimal unitPrice, ref string error)
        {
            string sql = $"INSERT INTO InvoiceDetail (InvoiceID, VehicleID, Quantity, UnitPrice) " +
                         $"VALUES ({invoiceID}, {vehicleID}, {quantity}, {unitPrice})";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public bool UpdateInvoiceDetail(int invoiceID, int vehicleID, int quantity, decimal unitPrice, ref string error)
        {
            string sql = $"UPDATE InvoiceDetail SET " +
                         $"Quantity = {quantity}, UnitPrice = {unitPrice} " +
                         $"WHERE InvoiceID = {invoiceID} AND VehicleID = {vehicleID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        public bool DeleteInvoiceDetail(int invoiceID, int vehicleID, ref string error)
        {
            string sql = $"DELETE FROM InvoiceDetail WHERE InvoiceID = {invoiceID} AND VehicleID = {vehicleID}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}
