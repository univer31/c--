using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication32;
 


namespace WindowsFormsApplication32
{
    public partial class 组队管理 : Form
    {
        BLL.Groupinfo bll = new BLL.Groupinfo();
        DataTable groups = new DataTable();
        int g_id;
        public 组队管理()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            Model.Groupinfo model = new Model.Groupinfo();
            model.g_name = textBox1.Text;
            model.project_name = textBox2.Text;
            model.project_info = textBox3.Text;
            model.g_lead = Model.loginfo.userID.ToString();
            model.grade = Model.loginfo.grade;
            model.major_id = Model.loginfo.major_id;

            string outmsg;
            try
            {
                if (bll.Add(model, out outmsg))
                    MessageBox.Show("ok!");
            }
            catch (Tools.AddException )
            {
                MessageBox.Show("ok!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            getList();
        }

        private void getList()
        {
            StringBuilder filter = new StringBuilder();
            filter.Append(string.Format("grade={0} and major_id={1}", loginfo.grade, loginfo.major_id));

            groups = bll.GetList(filter.ToString());
            dataGridView1.DataSource = groups;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            textBox1.Text = groups.Rows[idx]["g_name"].ToString();
            textBox2.Text = groups.Rows[idx]["project_name"].ToString();
            textBox3.Text = groups.Rows[idx]["project_info"].ToString();

            BLL.Student b_stu = new BLL.Student();
            g_id = Convert.ToInt32(groups.Rows[idx]["g_id"]);
            DataTable dt = b_stu.GetList(string.Format("g_id='{0}'", g_id));
            dataGridView2.DataSource = dt;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (g_id == 0)
            {
                MessageBox.Show("没有选组！");
                return;
            }

            Model.Student m_stu = new Model.Student();
            m_stu.g_id = g_id;
            m_stu.s_no = Model.loginfo.userID;
            BLL.Student b_stu = new BLL.Student();
            string message;
  
            if (b_stu.Update_groupid(m_stu, out message))
            {
                MessageBox.Show("加入成功！");
                Model.loginfo.g_id = g_id;
            }
            else
                MessageBox.Show("ok");
        }


        private void 组队管理_Load(object sender, EventArgs e)
        {
            getList();
            label5.Text = "学号：" + Model.loginfo.userID.ToString();
            label6.Text = "姓名：" + Model.loginfo.userName;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
