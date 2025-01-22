namespace Design_Patterns_Dotnet.Builder.PizzaExample
{
    // Director (Waiter)
    public class Waiter
    {
        private readonly IPizzaBuilder _pizzaBuilder;

        public Waiter(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void ConstructPizza()
        {
            _pizzaBuilder.SetDough();
            _pizzaBuilder.SetSauce();
            _pizzaBuilder.SetTopping();
        }
    }
}
