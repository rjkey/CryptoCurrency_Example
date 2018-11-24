using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API.Model
{
    public class Transaction
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }
    }
}