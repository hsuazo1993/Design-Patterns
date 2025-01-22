namespace Design_Patterns_Dotnet.Strategy.CompressionExample
{
    // Concrete Strategies
    public class RarCompressionStrategy : ICompressionStrategy
    {
        public void CompressFile(string filePath)
        {
            // RAR compression logic (using a library like SharpCompress)
            Console.WriteLine($"Compressing {filePath} using RAR...");
            // ... (Implementation for RAR compression)
        }
    }
}
