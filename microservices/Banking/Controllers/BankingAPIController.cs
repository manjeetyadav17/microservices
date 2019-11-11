using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingAPIController : ControllerBase
    {
        ConfigSettings configSettings { get; set; }
        public BankingAPIController(IOptions<ConfigSettings> settings)
        {
            configSettings = settings?.Value;
        }
        // GET: api/BankingAPI
        [HttpGet]
        public string Get()
        {
            return configSettings.message;
        }

        // GET: api/BankingAPI/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BankingAPI
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/BankingAPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
