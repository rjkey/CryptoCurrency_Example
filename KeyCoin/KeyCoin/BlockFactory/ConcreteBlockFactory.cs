namespace KeyCoin.BlockFactory
{
    class ConcreteBlockFactory : KeyCoin.BlockFactory.BlockFactory
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
