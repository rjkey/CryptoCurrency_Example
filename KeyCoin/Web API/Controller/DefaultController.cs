using System.Collections.Generic;
using System.Web.Http;
using KeyCoin;
using Newtonsoft.Json;
using UtilityLibrary;
using UtilityLibrary.Model;

namespace Web_API.Controller
{
    public class DefaultController : ApiController
    {
        //GET: /mine
        [Route("mine")]
        [HttpGet]
        public string Get()
        {
            Mining mining = new Mining();
            var minedBlock = mining.Mine();
            string blockAsJson = JsonConvert.SerializeObject(minedBlock);
            return blockAsJson;
        }

        //POST: /transaction
        [Route("transaction")]
        [HttpPost]
        public string Post([FromBody]Transaction value)
        {
            Transactions.AddTransaction(value);
            return "Transaction done";
        }
    }
}
