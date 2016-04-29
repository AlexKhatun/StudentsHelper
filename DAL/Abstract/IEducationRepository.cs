using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL.Abstract
{
    public interface IEducationRepository
    {
        ICollection<Education> GetAll();

        Education GetById(int id);

        void Insert(Education education);

        void Update(Education education);

        void Delete(int id);

        void Save();
    }
}
