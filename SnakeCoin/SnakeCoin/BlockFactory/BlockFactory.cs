using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCoin.BlockFactory
{
    abstract class BlockFactory
    {
        public abstract IBlockFactory GetBlock(BlockEnum.BlockTypes blockType);
    }
}
