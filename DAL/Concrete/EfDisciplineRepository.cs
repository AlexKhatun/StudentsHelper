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
    public class EfDisciplineRepository : BaseRepository, IDisciplineRepository
    {
        public ICollection<Discipline> GetAll()
        {
            return db.Discipline.ToList();
        }

        public Discipline GetById(int id)
        {
            return db.Discipline.Find(id);
        }

        public void Insert(Discipline discipline)
        {
            db.Discipline.Add(discipline);
            Save();
        }

        public void Update(Discipline discipline)
        {
            db.Entry(discipline).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            db.Discipline.Remove(GetById(id));
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
