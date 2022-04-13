using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Teacher
    {
        public bool Add(Model.Teacher model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public bool Delete(Model.Teacher model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public bool Update(Model.Teacher model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public Model.Teacher GetModel(string id)
        {
            return new Model.Teacher();
        }
    }
}
