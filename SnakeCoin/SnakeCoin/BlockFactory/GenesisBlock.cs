using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCoin.BlockFactory
{
    class GenesisBlock : IBlockFactory
    {
        public Block CreateBlock(Block previousBlock)
        {
            return new Block(0, DateTime.Now, "Genesis block", new byte[0]);
        }
    }
}
