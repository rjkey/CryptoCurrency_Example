using System.Collections.Generic;
using System.Web.Http;
using Web_API.Model;

namespace Web_API.Controller
{
    public class DefaultController : ApiController
    {
        private List<Transaction> _transactions;

        public DefaultController()
        {
            _transactions = new List<Transaction>();
        }
        //GET: api/default
        [HttpGet]
        public string Get()
        {
            return "Hello from DefaultController";
        }

        //POST: api/default
        [HttpPost]
        public string Post([FromBody]Transaction value)
        {
            _transactions.Add(value);
            return "Transaction done";
        }
    }
}
