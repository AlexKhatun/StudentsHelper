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
    public class StudentDb : BaseDb
    {
        private readonly IStudentRepository rep;

        public StudentDb()
        {
            rep = AppKernel.Get<IStudentRepository>();
        }

        public ICollection<Student> GetAll()
        {
            return rep.GetAll();
        }

        public Student GetById(int id)
        {
            return rep.GetById(id);
        }

        public void Insert(Student student)
        {
            rep.Insert(student);
        }

        public void Update(Student student)
        {
            rep.Update(student);
        }

        public void Delete(int id)
        {
            rep.Delete(id);
        }
    }
}
