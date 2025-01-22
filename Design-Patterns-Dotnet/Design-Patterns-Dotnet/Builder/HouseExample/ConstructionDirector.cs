namespace Design_Patterns_Dotnet.Builder.HouseExample
{
    // Director (ConstructionDirector)
    public class ConstructionDirector
    {
        private readonly IHouseBuilder _builder;

        public ConstructionDirector(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructModernHouse()
        {
            _builder.SetHouseType("Modern House");
            _builder.AddRoom("Living Room");
            _builder.AddRoom("Kitchen");
            _builder.AddRoom("Bedroom");
            _builder.BuildWalls();
            _builder.BuildDoors();
            _builder.BuildWindows();
            _builder.BuildRoof();
            _builder.BuildGarage();
        }

        public void ConstructVictorianHouse()
        {
            _builder.SetHouseType("Victorian House");
            _builder.AddRoom("Parlor");
            _builder.AddRoom("Dining Room");
            _builder.AddRoom("Library");
            _builder.BuildWalls();
            _builder.BuildDoors();
            _builder.BuildWindows();
            _builder.BuildRoof();
            _builder.BuildGarage();
        }
    }
}
