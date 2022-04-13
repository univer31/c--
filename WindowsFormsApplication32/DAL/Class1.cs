using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Users1
    {
        public bool Add(Model.Users1 teachers)
        {
            string sql =
                "insert into teachers values(@姓名,@性别,@教职工号,@专业,@年级,@学院,@研究方向,@手机号码,@邮箱)";
            SqlParameter[] sps = new SqlParameter[9];
            sps[0] = new SqlParameter("姓名", teachers.姓名);
            sps[1] = new SqlParameter("@性别", teachers.性别);
            sps[2] = new SqlParameter("@教职工号", teachers.教职工号);
            sps[3] = new SqlParameter("@专业", teachers.专业);
            sps[4] = new SqlParameter("@年级", teachers.年级);
            sps[5] = new SqlParameter("@学院", teachers.学院);
            sps[6] = new SqlParameter("@研究方向", teachers.研究方向);
            sps[7] = new SqlParameter("@手机号码", teachers.手机号码);
            sps[8] = new SqlParameter("@邮箱", teachers.邮箱);




            int res = SqlDbHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, sps);

            if (res == 1)
                return true;
            else
                return false;
        }
        public bool delete(Model.Users1 teachers)
        {
            string sql = "delete from teachers where 教职工号=@教职工号";

            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@教职工号", teachers.教职工号);

            int re = DAL.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, sps);

            bool res = Convert.ToBoolean(re);
            return res;
        }

        public bool update(Model.Users1 teachers)
        {
            string sql = "update teachers set 姓名=@姓名,性别=@性别,教职工号=@教职工号,专业=@专业,年级=@年级,学院=@学院,研究方向=@研究方向,手机号码=@手机号码,邮箱=@邮箱 where 教职工号=@教职工号";
            SqlParameter[] sps = new SqlParameter[9];
            sps[0] = new SqlParameter("姓名", teachers.姓名);
            sps[1] = new SqlParameter("@性别", teachers.性别);
            sps[2] = new SqlParameter("@教职工号", teachers.教职工号);
            sps[3] = new SqlParameter("@专业", teachers.专业);
            sps[4] = new SqlParameter("@年级", teachers.年级);
            sps[5] = new SqlParameter("@学院", teachers.学院);
            sps[6] = new SqlParameter("@研究方向", teachers.研究方向);
            sps[7] = new SqlParameter("@手机号码", teachers.手机号码);
            sps[8] = new SqlParameter("@邮箱", teachers.邮箱);

            int re = DAL.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, sps);

            bool res = Convert.ToBoolean(re);
            return res;
        }
    }
   
    public class Users
    {
        public bool Add(Model.User user)
        {
            //插入代码，此处可以添加sql相关对象操作
            return true;
        }

        public bool login(Model.User m_user)
        {
            bool res = false;

            string uid, pwd;
            uid = m_user.uid;
            pwd = m_user.pwd;

            using (SqlConnection m_cnADONetConnection = new SqlConnection())
            {
                m_cnADONetConnection.ConnectionString = connnection.connect_str;
                m_cnADONetConnection.Open();
                string sql = string.Format("select * from [users] where uid ='{0}' and pwd = '{1}'", uid, pwd);
                SqlDataAdapter sda = new SqlDataAdapter(sql, m_cnADONetConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int i = dt.Rows.Count;
                if (i == 1)
                    res = true;

            }
            
            return res;
        }
    }
}
