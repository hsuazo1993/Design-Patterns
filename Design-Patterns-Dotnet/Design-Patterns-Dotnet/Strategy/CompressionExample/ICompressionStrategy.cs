namespace Design_Patterns_Dotnet.Strategy.CompressionExample
{
    // Define the Strategy interface
    public interface ICompressionStrategy
    {
        void CompressFile(string filePath);
    }
}
