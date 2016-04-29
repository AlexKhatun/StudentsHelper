using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public abstract class BaseRepository
    {
        public StudentsHelperContext db;

        public BaseRepository()
        {
            db = new StudentsHelperContext();
        }
    }
}
