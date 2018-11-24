using System;
using System.Collections.Generic;
using System.Text;
using KeyCoin.BlockFactory;
using UtilityLibrary;

namespace KeyCoin
{
    public static class StartUp
    {
        public static void Start()
        {
            BlockData bd = new BlockData(0, Transactions.GetTransactions);
            Block genesisBlock = new Block(0, DateTime.Now, bd, new byte[0]);
            Blockchain.AddBlock(genesisBlock);
        }
    }
}
