using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.WorkWithDb
{
    public class AllDb
    {
        public GroupDb GroupDb;

        public StudentDb StudentDb;

        public DisciplineDb DisciplineDb;

        public EducationDb EducationDb;

        public LabWorkDb LabWorkDb;

        public AllDb()
        {
            GroupDb = new GroupDb();
            StudentDb = new StudentDb();
            DisciplineDb = new DisciplineDb();
            EducationDb = new EducationDb();
            LabWorkDb = new LabWorkDb();
        }
    }
}
