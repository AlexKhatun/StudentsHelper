using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL.Abstract
{
    public interface ILabWorkRepository
    {
        ICollection<LabWork> GetAll();

        LabWork GetById(int id);

        void Insert(LabWork labWork);

        void Update(LabWork labWork);

        void Delete(int id);

        void Save();
    }
}
