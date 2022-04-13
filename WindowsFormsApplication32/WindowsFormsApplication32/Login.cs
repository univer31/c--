using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication32
{
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Model.User m_user = new Model.User();
            m_user.uid = textBox1.Text;
            m_user.pwd = textBox2.Text;
            BLL.Users b_user = new BLL.Users();
            bool res;

            string outmessage;

            res = b_user.login(m_user, out outmessage);

            if (res)
            {
                主界面 f = new 主界面();
                f.Show();
                this.Hide();
            }
            else
            {
                {
                    MessageBox.Show("用户名或者密码错误！");
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
