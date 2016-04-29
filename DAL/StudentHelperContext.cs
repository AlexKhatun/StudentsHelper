using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentsHelperContext : DbContext
    {
        public StudentsHelperContext() : base("StudentsHelper") { }

        public DbSet<Student> Student { get; set; }

        public DbSet<Discipline> Discipline { get; set; }

        public DbSet<Group> Group { get; set; }

        public DbSet<Education> Education { get; set; }
    }
}
