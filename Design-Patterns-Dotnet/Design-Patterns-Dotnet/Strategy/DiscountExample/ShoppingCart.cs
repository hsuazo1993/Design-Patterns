namespace Design_Patterns_Dotnet.Strategy.DiscountExample
{
    // Context class
    public class ShoppingCart
    {
        public IDiscountStrategy DiscountStrategy { get; set; } = default!;

        public decimal CalculateTotalAmount(decimal amount)
        {
            return DiscountStrategy.ApplyDiscount(amount);
        }
    }
}
