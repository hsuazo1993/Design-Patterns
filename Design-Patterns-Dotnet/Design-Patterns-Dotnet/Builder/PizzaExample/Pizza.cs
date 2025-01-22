namespace Design_Patterns_Dotnet.Builder.PizzaExample
{
    // Define the product (Pizza)
    public class Pizza
    {
        public string Dough { get; set; } = string.Empty;
        public string Sauce { get; set; } = string.Empty;
        public string Topping { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Dough: {Dough}\n" +
                   $"Sauce: {Sauce}\n" +
                   $"Topping: {Topping}";
        }
    }
}
