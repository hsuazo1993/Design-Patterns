namespace Design_Patterns_Dotnet.Strategy.ShippingExample
{
    // Context class
    public class Order
    {
        public IShippingStrategy ShippingStrategy { get; set; } = default!;

        public decimal CalculateTotalCost()
        {
            // Order processing logic...
            decimal shippingCost = ShippingStrategy.CalculateShippingCost(this);
            // ... other cost calculations
            return shippingCost; // Simplified return for this example
        }
    }
}