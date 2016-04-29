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
    public class EfStudentRepository : BaseRepository, IStudentRepository
    {
        public ICollection<Student> GetAll()
        {
            return db.Student.ToList();
        }

        public Student GetById(int id)
        {
            return db.Student.Find(id);
        }

        public void Insert(Student student)
        {
            db.Student.Add(student);
            Save();
        }

        public void Update(Student student)
        {
            db.Entry(student).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            db.Student.Remove(GetById(id));
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
