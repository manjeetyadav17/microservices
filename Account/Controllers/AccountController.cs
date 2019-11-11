using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Account.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Account.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        ConfigSettings configSettings { get; set; }
        public AccountController(IOptions<ConfigSettings> settings)
        {
            configSettings = settings?.Value;
        }
        // GET: api/Account
        [HttpGet]
        public string Get()
        {
            var data = AccountService.GetTransactions();
            return configSettings.message + "Response from Account contoller and transaction data is reterived from trabsaction service " + data;
        }

        // GET: api/Account/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Response from account get by ID=" + id;
        }

        // POST: api/Account
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "Response from account post";
        }

        // PUT: api/Account/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Response from account put";
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Response from account delete";
        }
    }
}
