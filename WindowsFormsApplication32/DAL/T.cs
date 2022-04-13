using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class T
    {
        public DataTable select()
        {
            DataTable res;
            res = SqlDbHelper.ExecuteDataTable("select * from t");

            return res;
        }

        public bool update(DataTable t)
        {
            bool res;
            res = SqlDbHelper.update_Table(t, "t");

            return res;
        }
    }
}
