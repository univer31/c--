using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class G
    {
        public int Add(Model.g model)
        {
            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Assign.mdb";
            int count = 0;
            int g_id = model.gid;
            int g_c1 = model.c1;
            int g_c2 = model.c2;
            int g_c3 = model.c3;
            //string commandText = string.Format("insert into g(gid, c1, c2, c3, t) values ({0},{1},{2},{3}, -1)", g_id, g_c1,g_c2,g_c3);
            string commandText = "insert into g(gid, c1, c2, c3, t) values (@gid,@c1,@c2,@c3, -1)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@gid", SqlDbType.Int);
            parameters[0].Value = g_id;
            parameters[1] = new SqlParameter("@c1", SqlDbType.Int);
            parameters[1].Value = g_c1;
            parameters[2] = new SqlParameter("@c2", SqlDbType.Int);
            parameters[2].Value = g_c2;
            parameters[3] = new SqlParameter("@c3", SqlDbType.Int);
            parameters[3].Value = g_c3;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();//打开数据库连接
                    foreach (SqlParameter para in parameters)
                        command.Parameters.Add(para);
                    count = command.ExecuteNonQuery();
                }
            }
            return count;//返回执行增删改操作之后，数据库中受影响的行数
        }


        public int Addnew(Model.g model)
        {
            int count = 0;
            int g_id = model.gid;
            int g_c1 = model.c1;
            int g_c2 = model.c2;
            int g_c3 = model.c3;
            string commandText = "insert into g(gid, c1, c2, c3, t) values (@gid,@c1,@c2,@c3, -1)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@gid", SqlDbType.Int);
            parameters[0].Value = g_id;
            parameters[1] = new SqlParameter("@c1", SqlDbType.Int);
            parameters[1].Value = g_c1;
            parameters[2] = new SqlParameter("@c2", SqlDbType.Int);
            parameters[2].Value = g_c2;
            parameters[3] = new SqlParameter("@c3", SqlDbType.Int);
            parameters[3].Value = g_c3;
            count = SqlDbHelper.ExecuteNonQuery(commandText, CommandType.Text, parameters);
            return count;
        }

        public int Del(Model.g model)
        {
            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Assign.mdb";
            int count = 0;
            int g_id = model.gid;
            int g_c1 = model.c1;
            int g_c2 = model.c2;
            int g_c3 = model.c3;
            string commandText = "delete from g where gid=@gid";
            SqlParameter parameter = new SqlParameter();
            parameter = new SqlParameter("@gid", SqlDbType.Int);
            parameter.Value = g_id;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();//打开数据库连接
                    command.Parameters.Add(parameter);
                    count = command.ExecuteNonQuery();
                }
            }
            return count;//返回执行增删改操作之后，数据库中受影响的行数
        }

        public int Delete(Model.g model)
        {
            int count = 0;
            int g_id = model.gid;
            int g_c1 = model.c1;
            int g_c2 = model.c2;
            int g_c3 = model.c3;
            string commandText = "delete from g where gid=@gid";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@gid", SqlDbType.Int);
            parameter[0].Value = g_id;

            count = SqlDbHelper.ExecuteNonQuery(commandText, CommandType.Text, parameter);

            return count;//返回执行增删改操作之后，数据库中受影响的行数
        }

        public DataTable select()
        {
            DataTable res;
            res = SqlDbHelper.ExecuteDataTable("select * from g");

            return res;
        }

        public bool update(DataTable t)
        {
            bool res;
            res = SqlDbHelper.update_Table(t, "g");

            return res;
        }

        public bool update_custom(DataTable t)
        {
            bool res;
            SqlCommand[] scs = new SqlCommand[1];
            scs[0] = new SqlCommand("update g set c1=@c1, c2=@c2, c3=@c3 where gid=@gid");
            scs[0].Parameters.Add(new SqlParameter("@gid", SqlDbType.Int, 3, "gid"));
            scs[0].Parameters.Add(new SqlParameter("@c1", SqlDbType.Int, 3, "c1"));
            scs[0].Parameters.Add(new SqlParameter("@c2", SqlDbType.Int, 3, "c2"));
            scs[0].Parameters.Add(new SqlParameter("@c3", SqlDbType.Int, 3, "c3"));

            res = SqlDbHelper.update_Table(t, "g", scs);
            return res;
        }
    }
}
