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
    public class EducationDb : BaseDb
    {
        private readonly IEducationRepository rep;

        public EducationDb()
        {
            rep = AppKernel.Get<IEducationRepository>();
        }

        public ICollection<Education> GetAll()
        {
            return rep.GetAll();
        }

        public Education GetById(int id)
        {
            return rep.GetById(id);
        }

        public void Insert(Education education)
        {
            rep.Insert(education);
        }

        public void Update(Education education)
        {
            rep.Update(education);
        }

        public void Delete(int id)
        {
            rep.Delete(id);
        }
    }
}
