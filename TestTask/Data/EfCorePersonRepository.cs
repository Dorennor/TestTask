using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Data
{
    public class EfCorePersonRepository : EfCoreRepository<Person, ApplicationContext>
    {
        public EfCorePersonRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
