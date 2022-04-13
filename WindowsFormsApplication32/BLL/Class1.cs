using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Users1
    {
        public bool Add(Model.Users1 students)
        {
            DAL.Users1 d_user = new DAL.Users1();
            bool res = d_user.Add(students);

            return res;
        }
        public bool update(Model.Users1 teachers)
        {
            DAL.Users1 d_user = new DAL.Users1();
            bool res = d_user.update(teachers);
            return res;

        }
        public bool delete(Model.Users1 teachers)
        {
            DAL.Users1 d_user = new DAL.Users1();
            bool res = d_user.delete(teachers);
            return res;

        }
    }
    
    public class Users
    {
        public bool Add(Model.User m_user)
        {

            DAL.Users d_user = new DAL.Users();
            //三次操作判断。
            bool res = d_user.Add(m_user);

            return res;
        }

        public bool login(Model.User m_user, out string outmessage)
        {
            #region
            //DateTime dt = DateTime.ParseExact("20200501080000", "yyyyMMddhhmmss", System.Globalization.CultureInfo.CurrentCulture);
            //if (DateTime.Now > dt)
            //{
            //    outmessage = "已经超时";
            //    return false;
            //}
            #endregion
            DAL.Users d_user = new DAL.Users();
            bool result = d_user.login(m_user);
            if (!result)
                outmessage = "用户名和密码不对";
            else
                outmessage = "登录成功";
            return result;
        }
    }
}
