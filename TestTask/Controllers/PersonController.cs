using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : DbController<Person, EfCorePersonRepository>
    {
        public PersonController(EfCorePersonRepository repository) : base(repository)
        {

        }
    }
}
