using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class T
    {
        DAL.T DAL_t = new DAL.T();

        public DataTable selet()
        {
            DataTable res = DAL_t.select();
            return res;
        }

        public bool update(DataTable t)
        {
            bool res = DAL_t.update(t);
            return res;
        }
    }
}
