namespace Design_Patterns_Dotnet.Builder.HouseExample
{
    // Concrete builder (VictorianHouseBuilder)
    public class VictorianHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void SetHouseType(string type)
        {
            _house.Type = type;
        }
        public void AddRoom(string room)
        {
            _house.Rooms.Add(room);
        }

        public void BuildWalls()
        {
            _house.Walls = "Brick Walls with Ornate Details";
        }

        public void BuildDoors()
        {
            _house.Doors = "Wooden Doors with Stained Glass";
        }

        public void BuildWindows()
        {
            _house.Windows = "Bay Windows with Shutters";
        }

        public void BuildRoof()
        {
            _house.Roof = "Steeply Pitched Roof with Gables";
        }

        public void BuildGarage()
        {
            _house.Garage = "Detached Carriage House";
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}
