using System;

namespace KeyCoin.BlockFactory
{
    class NextBlock : IBlockFactory
    {
        public Block CreateBlock(Block previousBlock)
        {
            return new Block(previousBlock.Index + 1, DateTime.Now, "This is block number: " + previousBlock.Index + 1, previousBlock.PreviousHash);
        }
    }
}
