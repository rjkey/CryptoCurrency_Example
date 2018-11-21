using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCoin.BlockFactory
{
    class ConcreteBlockFactory : BlockFactory
    {
        public override IBlockFactory GetBlock(BlockEnum.BlockTypes blockType)
        {
            switch (blockType)
            {
                case BlockEnum.BlockTypes.GenesisBlock:
                    return new GenesisBlock();
                case BlockEnum.BlockTypes.NextBlock:
                    return new NextBlock();
                default:
                    return null;
            }
        }
    }
}
