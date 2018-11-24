namespace KeyCoin.BlockFactory
{
    interface IBlockFactory
    {
        Block CreateBlock(Block previousBlock);
    }
}
