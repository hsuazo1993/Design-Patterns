namespace Design_Patterns_Dotnet.Strategy.DiscountExample
{
    // Concrete Strategies
    public class BronzeDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            // Bronze members get a 5% discount
            Console.WriteLine("Applying Bronze discount (5%)...");
            return amount * 0.95m;
        }
    }
}
