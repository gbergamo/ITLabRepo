using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITLabTest.AppService.Interfaces;
using ITLabTest.AppService.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ITLabTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IPersonAppService personAppService;

        public PersonController(IPersonAppService personAppService)
        {
            this.personAppService = personAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonViewModel>> Get()
        {
            return Ok(personAppService.All());
        }

        [HttpGet("{id}")]
        public ActionResult<PersonViewModel> Get(Guid id)
        {
            return Ok(personAppService.ListById(id));
        }

        [HttpPost]
        public ActionResult<string> GetFilter(PersonViewModel filter)
        {
            return Ok(personAppService.List(filter));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] PersonViewModel person)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}