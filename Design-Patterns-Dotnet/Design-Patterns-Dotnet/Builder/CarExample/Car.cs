namespace Design_Patterns_Dotnet.Builder.CarExample
{
    public class Car
    {
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Color: {Color}, Year: {Year}";
        }
    }
}
