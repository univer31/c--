using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Users1
    {
        public string 姓名 { set; get; }
        public string 性别 { set; get; }
        public string 教职工号{ set; get; }
        public string 专业{ set; get; }
        public string 年级 { set; get; }
        public string 学院 { set; get; }
        public string 研究方向 { set; get; }
        public string 手机号码 { set; get; }
        public string 邮箱 { set; get; }
    }

    public class Users
    {
        public string uid;
        public string pwd;


    }

    public class User
    {
        public string uid
        {
            set;
            get;
        }
        public string pwd
        {
            set;
            get;
        }
    }
}
