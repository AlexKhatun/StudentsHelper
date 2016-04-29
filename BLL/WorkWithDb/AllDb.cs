using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.WorkWithDb
{
    public class AllDb
    {
        public GroupDb GroupDb { get; set; }

        public StudentDb StudentDb { get; set; }

        public DisciplineDb DisciplineDb { get; set; }

        public EducationDb EducationDb { get; set; }
    }
}
