namespace Design_Patterns_Dotnet.Builder.CarExample
{
    public sealed class CarBuilder
    {
        private Car _car = new Car();

        public CarBuilder WithMake(string make)
        {
            _car.Make = make;
            return this; // Return the builder instance for chaining
        }

        public CarBuilder WithModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder WithColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarBuilder WithYear(int year)
        {
            _car.Year = year;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
