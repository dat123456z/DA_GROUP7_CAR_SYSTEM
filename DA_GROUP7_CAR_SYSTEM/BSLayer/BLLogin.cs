using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLLogin
    {
        DBMain db = null;
        public BLLogin()
        {
            db = new DBMain();
        }

        public bool CheckLogin(string loginName, string password, ref string error)
        {
            string sqlString = "SELECT * FROM Login WHERE LoginName = '" + loginName + "' AND Password = '" + password + "'";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return ds.Tables[0].Rows.Count > 0;
        }


    }
}
