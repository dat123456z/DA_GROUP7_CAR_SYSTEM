using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLSignUp
    {
        DBMain db = null;
        public BLSignUp()
        {
            db = new DBMain();
        }

        // Hàm đăng ký tài khoản
        public bool SignUp(string loginName, string password, string phoneNumber, string address, string emailAddress, ref string error)
        {
            string sqlString = $"INSERT INTO SignUp (LoginName, Password, PhoneNumber, Address, EmailAddress) " +
                               $"VALUES (N'{loginName}', N'{password}', N'{phoneNumber}', N'{address}', N'{emailAddress}')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        // Hàm kiểm tra đăng nhập
        public bool CheckLogin(string loginName, string password, string phoneNumber, string address, string email, ref string error)
        {
            try
            {
                // First check if the login name already exists
                string checkSql = $"SELECT * FROM SignUp WHERE LoginName = N'{loginName}'";
                DataSet checkDs = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
                
                if (checkDs.Tables[0].Rows.Count > 0)
                {
                    error = "Tên đăng nhập đã tồn tại!";
                    return false;
                }

                // Insert new user
                string insertSql = $@"INSERT INTO Login (LoginName, Password) 
                            VALUES (N'{loginName}', N'{password}')";

                db.MyExecuteNonQuery(insertSql, CommandType.Text, ref error);
                return true;

                db.MyExecuteNonQuery(insertSql, CommandType.Text,ref error);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
