using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> GetPeople()
        {
            return new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey", AccountBalance = 19.45M },
                new PersonModel { FirstName = "Mary", LastName = "Jones", AccountBalance = 105.87M },
                new PersonModel { FirstName = "John", LastName = "Smith", AccountBalance = 115.32M }
            };
        }

        [HttpPost]
        public void Post(PersonModel person)
        {

        }
    }
}
