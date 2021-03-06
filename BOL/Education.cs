﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Education
    {
        public int EducationId { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        public int DisciplineId { get; set; }

        public virtual Discipline Discipline { get; set; }

        public int LabNumber { get; set; }

        public int Estimation { get; set; }

        public bool IsPass { get; set; }
    }
}
