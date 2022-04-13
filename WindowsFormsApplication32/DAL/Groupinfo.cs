using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Groupinfo
    {
        public int Add(Model.Groupinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            SqlParameter[] parameters;

            strSql.Append("select count(*) from Groupinfo where grade=@grade and major_id=@m_id");
            parameters = new SqlParameter[] {
					new SqlParameter("@grade", SqlDbType.Int),
					new SqlParameter("@m_id", SqlDbType.Int)};
            parameters[0].Value = model.grade;
            parameters[1].Value = model.major_id;
            int group_count = (int)SqlDbHelper.ExecuteScalar(strSql.ToString(), CommandType.Text, parameters);
            group_count++;
            model.g_id = Convert.ToInt32(model.grade + "" + model.major_id + "" + group_count);

            strSql.Clear();
            strSql.Append("insert into Groupinfo(");
            strSql.Append("g_id, g_name,major_id,grade, g_lead, project_name,project_info)");
            strSql.Append(" values (");
            strSql.Append("@g_id, @g_name,@major_id,@grade, @g_lead, @project_name,@project_info)");

            parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@g_id", model.g_id);
            parameters[1] = new SqlParameter("@g_name", model.g_name);
            parameters[2] = new SqlParameter("@major_id", model.major_id);
            parameters[3] = new SqlParameter("@grade", model.grade);
            parameters[4] = new SqlParameter("@g_lead", model.g_lead);
            parameters[5] = new SqlParameter("@project_name", model.project_name);
            parameters[6] = new SqlParameter("@project_info", model.project_info);

            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return model.g_id;
            }
            else
            {
                return -1;
            }
        }

        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Groupinfo where ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }
    }
}
