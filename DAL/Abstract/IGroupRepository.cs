using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL.Abstract
{
    public interface IGroupRepository
    {
        ICollection<Group> GetAll();

        Group GetById(int id);

        void Insert(Group group);

        void Update(Group group);

        void Delete(int id);

        void Save();
    }
}
