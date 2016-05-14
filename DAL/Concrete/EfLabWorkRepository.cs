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
    public class EfLabWorkRepository : BaseRepository, ILabWorkRepository
    {
        public ICollection<LabWork> GetAll()
        {
            return db.LabWork.ToList();
        }

        public LabWork GetById(int id)
        {
            return db.LabWork.Find(id);
        }

        public void Insert(LabWork labWork)
        {
            db.LabWork.Add(labWork);
            Save();
        }

        public void Update(LabWork labWork)
        {
            db.Entry(labWork).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            db.LabWork.Remove(this.GetById(id));
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
