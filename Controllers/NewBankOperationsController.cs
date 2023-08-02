using Microsoft.AspNetCore.Mvc;
using NewBankAPICore.Schemas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewBankAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewBankOperationsController : ControllerBase
    {
        // GET: api/<NewBankOperationsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NewBankOperationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NewBankOperationsController>
        [HttpPost]
        public NewBankAPICore.Schemas.AccountResponse Post(AccountRequest msgAccountRequest)
        {
            AccountResponse msgAccountResponse = new AccountResponse();
            msgAccountResponse.accountBalance = "990.50";

            return msgAccountResponse;
        }

        // PUT api/<NewBankOperationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NewBankOperationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
