namespace Design_Patterns_Dotnet.Strategy.CompressionExample
{
    // Context class
    public class FileCompressor
    {
        public ICompressionStrategy CompressionStrategy { get; set; } = default!;

        public void Compress(string filePath)
        {
            CompressionStrategy.CompressFile(filePath);
        }
    }
}
