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
            try
            {
                // First check if the login name already exists
                string checkSql = $"SELECT * FROM SignUp WHERE LoginName = N'{loginName}'";
                DataSet checkDs = db.ExecuteQueryDataSet(checkSql, CommandType.Text);
                
                if (checkDs.Tables[0].Rows.Count > 0)
                {
                    error = "Username already exists!";
                    return false;
                }

                // Insert into SignUp table
                string signUpSql = $@"INSERT INTO SignUp (LoginName, Password, PhoneNumber, Address, EmailAddress) 
                            VALUES (N'{loginName}', N'{password}', N'{phoneNumber}', N'{address}', N'{emailAddress}')";

                if (!db.MyExecuteNonQuery(signUpSql, CommandType.Text, ref error))
                {
                    return false;
                }

                // Insert into Login table
                string loginSql = $@"INSERT INTO Login (LoginName, Password) 
                            VALUES (N'{loginName}', N'{password}')";

                if (!db.MyExecuteNonQuery(loginSql, CommandType.Text, ref error))
                {
                    // If login insert fails, we should rollback the SignUp insert
                    string rollbackSql = $"DELETE FROM SignUp WHERE LoginName = N'{loginName}'";
                    db.MyExecuteNonQuery(rollbackSql, CommandType.Text, ref error);
                    return false;
                }


                return true;

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Hàm kiểm tra đăng nhập
        public bool CheckLogin(string loginName, string password, string phoneNumber, string address, string email, ref string error)
        {
            return SignUp(loginName, password, phoneNumber, address, email, ref error);
        }
    }
}
