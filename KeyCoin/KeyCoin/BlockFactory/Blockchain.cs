using System;
using System.Collections.Generic;
using System.Text;

namespace KeyCoin.BlockFactory
{
    public static class Blockchain
    {
        private static List<Block> _blockchain = new List<Block>(); 

        public static void AddBlock(Block block)
        {
            _blockchain.Add(block);
        }

        public static Block LastBlock()
        {
            return _blockchain[_blockchain.Count - 1];
        }
    }
}
