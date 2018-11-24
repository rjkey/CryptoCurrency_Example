using System;
using System.Collections.Generic;

namespace UtilityLibrary.Model
{
    [Serializable]
    public class Transaction
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }
    }
}