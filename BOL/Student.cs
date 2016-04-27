using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
    }
}
