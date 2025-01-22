namespace Design_Patterns_Dotnet.Strategy.ShippingExample
{
    // Concrete Strategies
    public class USPSShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Order order)
        {
            // USPS specific shipping cost calculation logic
            Console.WriteLine("\nCalculating shipping cost with USPS...");
            return 8.75m; // Replace with actual calculation
        }
    }
}
