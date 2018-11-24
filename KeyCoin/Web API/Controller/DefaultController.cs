using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
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
        public string Get()
        {
            return "Hello from DefaultController";
        }

        //POST: api/default
        public string Post(string value)
        {
            Transaction newTrans = JsonConvert.DeserializeObject<Transaction>(value);
            _transactions.Add(newTrans);
            return "Transaction done";
        }
    }
}
