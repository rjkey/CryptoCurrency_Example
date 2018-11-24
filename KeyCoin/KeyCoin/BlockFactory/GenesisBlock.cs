using System;

namespace KeyCoin.BlockFactory
{
    class GenesisBlock : IBlockFactory
    {
        public Block CreateBlock(Block previousBlock)
        {
            return new Block(0, DateTime.Now, "Genesis block", new byte[0]);
        }
    }
}
