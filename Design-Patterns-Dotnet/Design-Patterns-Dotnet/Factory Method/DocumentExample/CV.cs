namespace Design_Patterns_Dotnet.Factory_Method.DocumentExample
{
    // Concrete Document classes
    public class CV : IDocument
    {
        public void Generate()
        {
            Console.WriteLine("Generating a CV document...");
            // Logic to generate CV content (e.g., personal info, experience, skills)
        }
    }
}
