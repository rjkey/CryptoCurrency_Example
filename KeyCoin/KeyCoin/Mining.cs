using System;
using KeyCoin.BlockFactory;
using UtilityLibrary;
using UtilityLibrary.Model;

namespace KeyCoin
{
    public class Mining
    {
        private string _miner_address = "q3nf394hjg-random-miner-address-34nf3i4nflkn3oi";

        public Block Mine()
        {
            Block lastBlock = Blockchain.LastBlock();
            int lastProof = lastBlock.Data.Proof;

            int proof = Proof_of_Work(lastProof);
            Transaction t = new Transaction
            {
                Amount = 1,
                From = "network",
                To = _miner_address
            };

            Transactions.AddTransaction(t);

            BlockData newBlockData = new BlockData(proof, Transactions.GetTransactions);

            int newBlockIndex = lastBlock.Index + 1;

            Transactions.ClearTransactions();

            Block minedBlock = new Block(newBlockIndex, DateTime.Now, newBlockData, lastBlock.Hash);

            Blockchain.AddBlock(minedBlock);

            return minedBlock;
        }
        public int Proof_of_Work(int last_proof)
        {
            int incrementor = last_proof + 1;

            while (incrementor % 9 == 0 && incrementor % last_proof == 0)
            {
                incrementor += 1;
            }

            return incrementor;
        }
    }
}
