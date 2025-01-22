namespace Design_Patterns_Dotnet.Strategy.DiscountExample
{
    // Concrete Strategies
    public class GoldDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            // Gold members get a 15% discount
            Console.WriteLine("Applying Gold discount (15%)...");
            return amount * 0.85m;
        }
    }
}
