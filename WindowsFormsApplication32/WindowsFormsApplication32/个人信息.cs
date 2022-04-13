using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication32
{
    public partial class 个人信息 : Form
    {
        public 个人信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    SqlConnection sqlConn = new SqlConnection();
                    sqlConn.ConnectionString = "server =DESKTOP-CHKORO1\\SQLEXPRESS; uid = sa; pwd =14778522508g; database = assign;";//设置连接字符串
                    sqlConn.Open();


                    SqlCommand myCommand = sqlConn.CreateCommand();
                    //int mycount=0;
                    myCommand.CommandText = "select  姓名,性别,教职工号,专业,年级,学院,研究方向,手机号码,邮箱 from teachers";


                    SqlDataReader myReader = myCommand.ExecuteReader();
                    myReader.Read();



                    while (myReader.Read())
                    {
                        textBox1.Text = Convert.ToString(myReader["姓名"]);
                        textBox2.Text = Convert.ToString(myReader["性别"]);
                        textBox3.Text = Convert.ToString(myReader["教职工号"]);
                        textBox4.Text = Convert.ToString(myReader["专业"]);
                        textBox5.Text = Convert.ToString(myReader["年级"]);
                        textBox6.Text = Convert.ToString(myReader["学院"]);
                        textBox7.Text = Convert.ToString(myReader["研究方向"]);
                        textBox8.Text = Convert.ToString(myReader["手机号码"]);
                        textBox9.Text = Convert.ToString(myReader["邮箱"]);





                    }
                    myReader.Close();
                    sqlConn.Close();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "小王";
            textBox2.Text = "女";
            textBox3.Text ="444" ;
            textBox4.Text = "生工";
            textBox5.Text ="20" ;
            textBox6.Text ="生工" ;
            textBox7.Text ="计算机" ;
            textBox8.Text ="0";
            textBox9.Text ="qq@com" ;
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model.Users1 teachers = new Model.Users1();
            teachers.姓名 = textBox1.Text;
            teachers.性别 = textBox2.Text;
            teachers.教职工号 = textBox3.Text;
            teachers.专业 = textBox4.Text;
            teachers.年级 = textBox5.Text;
            teachers.学院 = textBox6.Text;
            teachers.研究方向 = textBox7.Text;
            teachers.手机号码 = textBox8.Text;
            teachers.邮箱 = textBox9.Text;

            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("教职工号不能为空");
            }

            else
            {
                BLL.Users1 b_user = new BLL.Users1();
                MessageBox.Show("修改成功");
                bool res = b_user.update(teachers);
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Model.Users1 teachers = new Model.Users1();
            teachers.姓名 = textBox1.Text;
            teachers.性别 = textBox2.Text;
            teachers.教职工号 = textBox3.Text;
            teachers.专业 = textBox4.Text;
            teachers.年级 = textBox5.Text;
            teachers.学院 = textBox6.Text;
            teachers.研究方向 = textBox7.Text;
            teachers.手机号码 = textBox8.Text;
            teachers.邮箱 = textBox9.Text;

            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("教职工号不能为空");
            }

            else
            {
                BLL.Users1 b_user = new BLL.Users1();
                MessageBox.Show("删除成功");
                bool res = b_user.delete(teachers);
            }
           
        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            联系管理员 f = new 联系管理员();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Model.Users1 teachers= new Model.Users1();
            teachers.姓名 = textBox1.Text;
            teachers.性别 = textBox2.Text;
            teachers.教职工号 = textBox3.Text;
            teachers.专业 = textBox4.Text;
            teachers.年级 = textBox5.Text;
            teachers.学院 = textBox6.Text;
            teachers.研究方向 = textBox7.Text;
            teachers.手机号码 = textBox8.Text;
            teachers.邮箱 = textBox9.Text;


            BLL.Users1 b_user = new BLL.Users1();
            bool res = b_user.Add(teachers);
            if (res != true)
                MessageBox.Show("添加失败！");
            else
                MessageBox.Show("添加成功！");
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //    textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        //    textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        //    textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        //    textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            
        //}
    }
}
