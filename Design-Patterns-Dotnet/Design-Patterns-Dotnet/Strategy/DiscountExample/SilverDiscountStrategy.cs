namespace Design_Patterns_Dotnet.Strategy.DiscountExample
{
    // Concrete Strategies
    public class SilverDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            // Silver members get a 10% discount
            Console.WriteLine("Applying Silver discount (10%)...");
            return amount * 0.90m;
        }
    }
}
