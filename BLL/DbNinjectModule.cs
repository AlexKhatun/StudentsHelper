using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using DAL.Concrete;
using Ninject.Modules;

namespace BLL
{
    public class DbNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGroupRepository>().To<EfGroupRepository>();
            Bind<IStudentRepository>().To<EfStudentRepository>();
            Bind<IEducationRepository>().To<EfEducationRepository>();
            Bind<IDisciplineRepository>().To<EfDisciplineRepository>();
        }
    }
}
