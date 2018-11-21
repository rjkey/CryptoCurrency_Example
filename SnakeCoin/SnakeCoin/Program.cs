using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeCoin.BlockFactory;

namespace SnakeCoin
{
    class Program
    {
        private static List<Block> _blockChain = new List<Block>();
        private static int _numberOfBlocksToAdd = 20;

        static void Main(string[] args)
        {        
            BlockFactory.BlockFactory factory = new ConcreteBlockFactory();

            IBlockFactory genesis = factory.GetBlock(BlockEnum.BlockTypes.GenesisBlock);
            IBlockFactory nextBlock = factory.GetBlock(BlockEnum.BlockTypes.NextBlock);
            
            _blockChain.Add(genesis.CreateBlock(null));

            Block previousBlock = _blockChain[0];

            for (int i = 1; i < _numberOfBlocksToAdd; i++)
            {
                var block_to_add = nextBlock.CreateBlock(previousBlock);
                _blockChain.Add(block_to_add);
                previousBlock = block_to_add;

                Console.WriteLine("Block #" + block_to_add.Index + " has been added to the blockchain!");
                Console.WriteLine("Hash: " + ToHex(block_to_add.Hash));
                Console.WriteLine("");
            }
        }

        public static string ToHex(byte[] bytes)
        {
            StringBuilder result = new StringBuilder(bytes.Length * 2);

            for (int i = 0; i < bytes.Length; i++)
                result.Append(bytes[i].ToString("x2"));

            return result.ToString();
        }
    }
}
