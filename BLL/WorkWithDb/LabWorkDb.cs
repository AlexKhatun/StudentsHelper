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
    public class LabWorkDb : BaseDb
    {
        private readonly ILabWorkRepository rep;

        public LabWorkDb()
        {
            rep = AppKernel.Get<ILabWorkRepository>();
        }

        public ICollection<LabWork> GetAll()
        {
            return rep.GetAll();
        }

        public LabWork GetById(int id)
        {
            return rep.GetById(id);
        }

        public void Insert(LabWork labWork)
        {
            rep.Insert(labWork);
        }

        public void Update(LabWork labWork)
        {
            rep.Update(labWork);
        }

        public void Delete(int id)
        {
            rep.Delete(id);
        }
    }
}
