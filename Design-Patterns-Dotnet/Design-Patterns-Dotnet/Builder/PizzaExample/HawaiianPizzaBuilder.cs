namespace Design_Patterns_Dotnet.Builder.PizzaExample
{
    // Concrete builder (HawaiianPizzaBuilder)
    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void SetDough()
        {
            _pizza.Dough = "Thin Crust";
        }

        public void SetSauce()
        {
            _pizza.Sauce = "Tomato";
        }

        public void SetTopping()
        {
            _pizza.Topping = "Ham and Pineapple";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
