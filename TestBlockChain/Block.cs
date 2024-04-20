using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlockChain
{
    public class Block
    {
        public int Index { get; set; }
        public DateTime Timestamp { get; set; }
        public string Data { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }

        public Block(DateTime timestamp, string data, string previousHash = "")
        {
            Index = 0; // chỉ định lại khi thêm vào blockchain
            Timestamp = timestamp;
            Data = data;
            PreviousHash = previousHash;
            Hash = CalculateHash();
        }

        public string CalculateHash()
        {
            return CryptoHelper.Sha256($"{Index}{Timestamp}{Data}{PreviousHash}");
        }
    }
}
