namespace Design_Patterns_Dotnet.Builder.PizzaExample
{
    // Concrete builder (PepperoniPizzaBuilder)
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void SetDough()
        {
            _pizza.Dough = "Thick Crust";
        }

        public void SetSauce()
        {
            _pizza.Sauce = "Tomato";
        }

        public void SetTopping()
        {
            _pizza.Topping = "Pepperoni";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
