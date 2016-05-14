using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;
using DAL.Abstract;

namespace DAL.Concrete
{
    public class EfGroupRepository : BaseRepository, IGroupRepository
    {
        public ICollection<Group> GetAll()
        {
            return db.Group.ToList();
        }

        public Group GetById(int id)
        {
            return db.Group.Find(id);
        }

        public void Insert(Group group)
        {
            db.Group.Add(group);
            Save();
        }

        public void Update(Group group)
        {
            db.Entry(group).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            db.Group.Remove(this.GetById(id));
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
