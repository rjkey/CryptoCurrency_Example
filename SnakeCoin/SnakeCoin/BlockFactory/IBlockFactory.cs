using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCoin.BlockFactory
{
    interface IBlockFactory
    {
        Block CreateBlock(Block previousBlock);
    }
}
