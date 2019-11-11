using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Transactions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        ConfigSettings configSettings { get; set; }
        public TransactionController(IOptions<ConfigSettings> settings)
        {
            configSettings = settings?.Value;
        }
        // GET: api/Transaction
        [HttpGet]
        public string Get()
        {
            return configSettings.message;
        }

        // GET: api/Transaction/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Transaction
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Transaction/5
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
