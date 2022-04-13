using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class G
    {
        DAL.G DAL_g = new DAL.G();

        public bool Add(Model.g model, out string msg)
        {
            int res = DAL_g.Addnew(model);
            if (res == 1)
            {
                msg = "ok!";
                return true;
            }
            else
            {
                msg = "no!";
                return false;
            }
        }

        public bool Del(Model.g model, out string msg)
        {
            int res = DAL_g.Delete(model);
            if (res == 1)
            {
                msg = "ok!";
                return true;
            }
            else
            {
                msg = "no!";
                return false;
            }
        }


        public DataTable selet()
        {
            DataTable res = DAL_g.select();
            return res;
        }

        public bool update(DataTable t)
        {
            //bool res = DAL_g.update(t);
            bool res = DAL_g.update_custom(t);

            return res;
        }
    }
}
