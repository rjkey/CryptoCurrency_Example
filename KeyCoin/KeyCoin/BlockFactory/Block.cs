using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace KeyCoin.BlockFactory
{
    public class Block
    {
        public Block(int index, DateTime timestamp, BlockData data, byte[] previousHash)
        {
            Index = index;
            Timestamp = timestamp;
            Data = data;
            PreviousHash = previousHash;
            Hash = Hash_block();
        }

        public int Index { get; set; }

        public DateTime Timestamp { get; set; }

        public BlockData Data { get; set; }

        public byte[] PreviousHash { get; set; }

        public byte[] Hash { get; set; }

        private byte[] Hash_block()
        {
            using (SHA512 sha512 = new SHA512Managed())
            {
                byte[] index_as_bytes = BitConverter.GetBytes(Index);
                sha512.TransformBlock(index_as_bytes, 0, index_as_bytes.Length, index_as_bytes, 0);

                byte[] timestamp_as_bytes = BitConverter.GetBytes(Timestamp.Ticks);
                sha512.TransformBlock(timestamp_as_bytes, 0, timestamp_as_bytes.Length, timestamp_as_bytes, 0);

                byte[] data_as_bytes = ObjectToByteArray(Data);

                sha512.TransformBlock(data_as_bytes, 0, data_as_bytes.Length, data_as_bytes, 0);

                sha512.TransformFinalBlock(PreviousHash, 0, PreviousHash.Length);

                byte[] hash_of_block = sha512.Hash;

                return hash_of_block;
            }
        }

        private byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
    }
}
