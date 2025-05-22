using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DA_GROUP7_CAR_SYSTEM.BSLayer
{
    class BLBuyCar
    {
        DBMain db = new DBMain();

        public DataSet loadData(string loginName)
        {
            string strSQL = $@"SELECT s.PhoneNumber, s.Address, s.EmailAddress, s.LoginName, s.Password 
                             FROM SignUp s
                             INNER JOIN Login l ON s.LoginName = l.LoginName
                             WHERE l.LoginName = '{loginName}'";
            
            return db.ExecuteQueryDataSet(strSQL, CommandType.Text);
        }
    }
}
