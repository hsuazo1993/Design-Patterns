namespace Design_Patterns_Dotnet.Strategy.ShippingExample
{
    // Concrete Strategies
    public class FedExShippingStrategy : IShippingStrategy
    {
        public decimal CalculateShippingCost(Order order)
        {
            // FedEx specific shipping cost calculation logic
            // (e.g., based on weight, distance, etc.)
            Console.WriteLine("\nCalculating shipping cost with FedEx...");
            return 10.00m; // Replace with actual calculation
        }
    }
}
