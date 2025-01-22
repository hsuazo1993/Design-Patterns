namespace Design_Patterns_Dotnet.Strategy.DiscountExample
{
    // Define the Strategy interface
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal amount);
    }
}
