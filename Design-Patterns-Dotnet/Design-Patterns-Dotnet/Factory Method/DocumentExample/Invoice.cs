namespace Design_Patterns_Dotnet.Factory_Method.DocumentExample
{
    // Concrete Document classes
    public class Invoice : IDocument
    {
        public void Generate()
        {
            Console.WriteLine("Generating an Invoice document...");
            // Logic to generate invoice content (e.g., items, prices, totals)
        }
    }
}
