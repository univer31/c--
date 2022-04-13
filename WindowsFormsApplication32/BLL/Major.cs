using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Major
    {
        public bool Add(Model.Major model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public bool Delete(Model.Major model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public bool Update(Model.Major model, out string msg)
        {
            msg = "ok!";
            return true;
        }

        public Model.Major GetModel(string id)
        {
            return new Model.Major();
        }
    }
}
