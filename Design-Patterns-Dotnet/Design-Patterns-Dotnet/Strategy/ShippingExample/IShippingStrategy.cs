namespace Design_Patterns_Dotnet.Strategy.ShippingExample
{
    // Define the Strategy interface
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(Order order);
    }
}
