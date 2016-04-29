using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class Test
    {
        public Test()
        {
            StudentsHelperContext db = new StudentsHelperContext();
            db.Group.Add(new Group() { GroupId = 1, Title = "blabla" });
        }
    }
}
