namespace Design_Patterns_Dotnet.Factory_Method.DocumentExample
{
    // Document Factory
    public static class DocumentFactory
    {
        public static IDocument CreateDocument(string documentType)
        {
            switch (documentType.ToLower())
            {
                case "cv":
                    return new CV();
                case "invoice":
                    return new Invoice();
                default:
                    throw new ArgumentException("Invalid document type.");
            }
        }
    }
}
