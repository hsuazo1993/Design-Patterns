namespace Design_Patterns_Dotnet.Strategy.ShippingExample
{
    // Concrete Strategies
    public class UPSShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Order order)
        {
            // UPS specific shipping cost calculation logic
            Console.WriteLine("\nCalculating shipping cost with UPS...");
            return 12.50m; // Replace with actual calculation
        }
    }
}
