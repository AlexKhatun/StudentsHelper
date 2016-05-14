using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class LabWork
    {
        public int LabWorkId { get; set; }

        public string Theme { get; set; }

        public int DisciplineId { get; set; }

        public virtual Discipline Discipline { get; set; }

        public int LabNumber { get; set; }
    }
}
