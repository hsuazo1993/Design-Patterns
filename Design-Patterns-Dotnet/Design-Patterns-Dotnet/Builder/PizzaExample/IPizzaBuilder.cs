namespace Design_Patterns_Dotnet.Builder.PizzaExample
{
    // Define the builder interface (IPizzaBuilder)
    public interface IPizzaBuilder
    {
        void SetDough();
        void SetSauce();
        void SetTopping();
        Pizza GetPizza();
    }
}
