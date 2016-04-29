using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL.Abstract;
using DAL.Concrete;
using Ninject;

namespace BLL.WorkWithDb
{
    public class GroupDb : BaseDb
    {
        private readonly IGroupRepository rep;

        public GroupDb()
        {
            rep = AppKernel.Get<IGroupRepository>();
        }

        public ICollection<Group> GetAll()
        {
            return rep.GetAll();
        }

        public Group GetById(int id)
        {
            return rep.GetById(id);
        }

        public void Insert(Group group)
        {
            rep.Insert(group);
        }

        public void Update(Group group)
        {
            rep.Update(group);
        }

        public void Delete(int id)
        {
            rep.Delete(id);
        }
    }
}
