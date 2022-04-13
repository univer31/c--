using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Student
    {
        DAL.Student dal = new DAL.Student();

        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        public bool Add(Model.Student model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public bool Delete(Model.Student model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public bool Update(Model.Student model, out string msg)
        {
            msg = "ok!";

            return true;
        }

        public bool Update_groupid(Model.Student model, out string msg)
        {
            msg = "ok!";
            //有什么问题？
            if (dal.Update_groupid(model))
                return true;
            else
                return false;
        }

        public Model.Student GetModel(long id)
        {
            return dal.getModel(id);
        }

        public bool Login(Model.Student m_stu)
        {
            bool res = dal.Login(m_stu);
            return res;
        }
    }
}
