using System.Text;

namespace TestBlockChain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Blockchain blockchain = new Blockchain();

            // Thêm một số khối vào blockchain
            blockchain.AddBlock(new Block(DateTime.Now, "Vương Vũ Tiệp"));
            blockchain.AddBlock(new Block(DateTime.Now, "Maragret Wang"));
            blockchain.AddBlock(new Block(DateTime.Now, "Trần Hoài Ngọc"));
            blockchain.AddBlock(new Block(DateTime.Now, "Trần Mỹ Sương"));
            blockchain.AddBlock(new Block(DateTime.Now, "Bạch Mỹ Ngọc"));

            // In ra blockchain
            foreach (var block in blockchain.Chain)
            {
                Console.WriteLine($"Index: {block.Index}, Timestamp: {block.Timestamp}, Data: {block.Data}, Hash: {block.Hash}, Previous Hash: {block.PreviousHash}");
            }
        }
    }
}
