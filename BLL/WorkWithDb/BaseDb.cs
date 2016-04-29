using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace BLL.WorkWithDb
{
    public class BaseDb
    {
        public static IKernel AppKernel;

        public BaseDb()
        {
            AppKernel = new StandardKernel(new DbNinjectModule());
        }
    }
}
