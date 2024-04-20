using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlockChain
{
    public class Blockchain
    {
        public List<Block> Chain { get; set; }

        public Blockchain()
        {
            Chain = new List<Block>();
            AddGenesisBlock();
        }

        private void AddGenesisBlock()
        {
            Chain.Add(new Block(DateTime.Now, "Block 1"));
        }

        public void AddBlock(Block block)
        {
            block.Index = Chain.Count;
            block.PreviousHash = Chain[Chain.Count - 1].Hash;
            block.Hash = block.CalculateHash();
            Chain.Add(block);
        }
    }
}
