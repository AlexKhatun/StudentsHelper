using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL.Abstract;

namespace DAL.Concrete
{
    public class EfEducationRepository : BaseRepository, IEducationRepository
    {
        public ICollection<Education> GetAll()
        {
            return db.Education.ToList();
        }

        public Education GetById(int id)
        {
            return db.Education.Find(id);
        }

        public void Insert(Education education)
        {
            db.Education.Add(education);
            Save();
        }

        public void Update(Education education)
        {
            db.Entry(education).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            db.Education.Remove(GetById(id));
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
