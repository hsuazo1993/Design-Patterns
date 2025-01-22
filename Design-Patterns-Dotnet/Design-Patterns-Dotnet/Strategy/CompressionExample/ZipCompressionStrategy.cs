namespace Design_Patterns_Dotnet.Strategy.CompressionExample
{
    // Concrete Strategies
    public class ZipCompressionStrategy : ICompressionStrategy
    {
        public void CompressFile(string filePath)
        {
            // ZIP compression logic (using a library like DotNetZip)
            Console.WriteLine($"Compressing {filePath} using ZIP...");
            // ... (Implementation for ZIP compression)
        }
    }
}
