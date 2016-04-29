using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL.Abstract
{
    public interface IDisciplineRepository
    {
        ICollection<Discipline> GetAll();

        Discipline GetById(int id);

        void Insert(Discipline discipline);

        void Update(Discipline discipline);

        void Delete(int id);

        void Save();
    }
}
