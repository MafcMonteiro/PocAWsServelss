using Domain.ProjetoSunshine.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PocAWsServelss.Controllers
{
    [Route("api/[controller]")]
    public class SunshineController : ControllerBase
    {

        private readonly IProjetoSunshineService projetoSunshineService;

        public SunshineController(IProjetoSunshineService projetoSunshineService)
        {
            this.projetoSunshineService = projetoSunshineService;
        }


        // GET api/values
        [HttpGet]
        public string Get()
        {
           return projetoSunshineService.sunshineGet();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
