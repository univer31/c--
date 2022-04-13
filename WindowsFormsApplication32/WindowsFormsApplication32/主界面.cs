using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication32
{
    public partial class 主界面 : Form
    {
       
        public 主界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            个人信息 f = new 个人信息();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            //f.Show();
            查询 f = new 查询();
            f.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            组队管理 f = new 组队管理();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            结果显示 f = new 结果显示();
            f.Show();
        }
        protected void Clear(Control ctrl)
        {
            //ctrl.Text = "";
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)(c)).Text = "";
                }
                c.Text = "";
                Clear(c);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
              Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void StudentMessage_Activated(object sender, EventArgs e)
        {
            //textBox1.Text = Model.loginfo.userName;
            //textBox2.Text = Model.loginfo.userID.ToString();
            //textBox3.Text = Model.loginfo.grade.ToString();
            //textBox4.Text = Model.loginfo.major_id.ToString();
            //textBox5.Text = Model.loginfo.g_id.ToString();
            //textBox6.Text = Model.loginfo.banji.ToString();
            //textBox7.Text = Model.loginfo.phone.ToString();
            //textBox8.Text = Model.loginfo.qq.ToString();
            //textBox9.Text = Model.loginfo.xueyuan;
          
        }

        private void 主界面_Load(object sender, EventArgs e)
        {
            textBox1.Text = "小王";
            textBox2.Text = "女";
            textBox3.Text = "444";
            textBox4.Text = "生工";
            textBox5.Text = "20";
            textBox6.Text = "生工";
            textBox7.Text = "计算机";
            textBox8.Text = "123";
            textBox9.Text = "qq@com";
        }

       

      

    }
}
