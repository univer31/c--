using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Student
    {
        public bool Update_groupid(Model.Student model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Student set ");
            strSql.Append("g_id=@g_id where s_no=@s_no");
            SqlParameter[] parameters = {
					new SqlParameter("@g_id", SqlDbType.Int,10),
                    new SqlParameter("@s_no", SqlDbType.BigInt,11),
                };
            parameters[0].Value = model.g_id;
            parameters[1].Value = model.s_no;

            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from student where ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }


        public bool Login(Model.Student m_stu)
        {
            string sql = "select count(*) from student where s_no=@s_no and pwd=@pwd";
            SqlParameter[] parameters = {
                    new SqlParameter("@s_no", m_stu.s_no),
                    new SqlParameter("@pwd", m_stu.pwd),
                };

            int res = (int)SqlDbHelper.ExecuteScalar(sql, CommandType.Text, parameters);

            if (res == 1)
                return true;
            else
                return false;
        }


        public Model.Student getModel(long id)
        {
            Model.Student model = new Model.Student();

            string sql = "select * from  student where s_no=@s_no";
            SqlParameter[] parameters = {
                    new SqlParameter("@s_no", id),
                };

            SqlDataReader sdr = SqlDbHelper.ExecuteReader(sql, CommandType.Text, parameters);
            if (sdr.Read())
            {
                model.s_name = sdr["s_name"].ToString();
                model.major_id = (int)sdr["major_id"];
                model.grade = (int)sdr["grade"];
                model.g_id = (int)sdr["g_id"];
            }

            return model;
        }
    }
}
