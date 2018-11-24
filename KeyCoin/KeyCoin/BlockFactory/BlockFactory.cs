namespace KeyCoin.BlockFactory
{
    abstract class BlockFactory
    {
        public abstract IBlockFactory GetBlock(BlockEnum.BlockTypes blockType);
    }
}
