using System;
using System.Collections.Generic;
using System.Text;
using UtilityLibrary.Model;

namespace KeyCoin.BlockFactory
{
    [Serializable]
    public class BlockData
    {
        public BlockData(int proof, List<Transaction> transactions)
        {
            Proof = proof;
            Transactions = transactions;
        }
        public int Proof { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
