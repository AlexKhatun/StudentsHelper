using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL.Abstract;
using Ninject;

namespace BLL.WorkWithDb
{
    public class DisciplineDb : BaseDb
    {
        private readonly IDisciplineRepository rep;

        public DisciplineDb()
        {
            rep = AppKernel.Get<IDisciplineRepository>();
        }

        public ICollection<Discipline> GetAll()
        {
            return rep.GetAll();
        }

        public Discipline GetById(int id)
        {
            return rep.GetById(id);
        }

        public void Insert(Discipline discipline)
        {
            rep.Insert(discipline);
        }

        public void Update(Discipline discipline)
        {
            rep.Update(discipline);
        }

        public void Delete(int id)
        {
            rep.Delete(id);
        }
    }
}
