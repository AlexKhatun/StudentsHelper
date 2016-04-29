using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL.Abstract
{
    public interface IStudentRepository
    {
        ICollection<Student> GetAll();

        Student GetById(int id);

        void Insert(Student student);

        void Update(Student student);

        void Delete(int id);

        void Save();
    }
}
