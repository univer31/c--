using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace BLL
{
    public class Groupinfo
    {
        DAL.Groupinfo dal = new DAL.Groupinfo();
        public bool Add(Model.Groupinfo model, out string msg)
        {
            bool res = false;
            msg = "ok!";

            try
            {
                using (TransactionScope tx = new TransactionScope())//事务处理
                {
                    int groupid = dal.Add(model);

                    if (groupid != -1)
                    {
                        Model.Student m_stu = new Model.Student();
                        m_stu.g_id = groupid;
                        m_stu.s_no = Model.loginfo.userID;
                        Student b_stu = new Student();
                        string message;

                        if (b_stu.Update_groupid(m_stu, out message))
                            res = true;
                        else
                            res = false;
                    }
                    else
                        res = false;

                    tx.Complete();
                }
            }
            catch (SqlException ex)
            {
                int error_code = ex.ErrorCode;



                throw new Tools.AddException(string.Format("添加失败！ sql 错误代码{0}", error_code));
            }
            catch (Exception e)
            {
                throw e;
            }

            return res;
        }

        public bool Delete(Model.Groupinfo model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public bool Update(Model.Groupinfo model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public Model.Groupinfo GetModel(string id)
        {
            return new Model.Groupinfo();
        }

        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

    }
}
