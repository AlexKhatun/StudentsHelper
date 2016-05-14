using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Discipline
    {
        public int DisciplineId { get; set; }

        public string Title { get; set; }

        public virtual ICollection<LabWork> LabWorks { get; set; } 

        public virtual ICollection<Education> Educations { get; set; }
    }
}
