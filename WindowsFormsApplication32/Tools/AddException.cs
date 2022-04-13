using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class AddException : Exception
    {
        public AddException()
            : base("默认错误测试")
        {

        }

        public AddException(string message)//指定错误消息
            : base(message)
        {

        }
    }
}
