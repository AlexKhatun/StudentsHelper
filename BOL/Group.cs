using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Group
    {
        public int GroupId { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
