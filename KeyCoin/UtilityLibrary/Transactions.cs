using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary.Model;

namespace UtilityLibrary
{
    public static class Transactions
    {
        private static List<Transaction> _transactions = new List<Transaction>();

        public static void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public static void ClearTransactions()
        {
            _transactions.Clear();
        }

        public static List<Transaction> GetTransactions
        {
            get { return _transactions; }
        }
    }
}
