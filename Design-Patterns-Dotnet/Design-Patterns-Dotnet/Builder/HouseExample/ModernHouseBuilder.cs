namespace Design_Patterns_Dotnet.Builder.HouseExample
{
    // Concrete builder (ModernHouseBuilder)
    public class ModernHouseBuilder : IHouseBuilder
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
            _house.Walls = "Concrete and Glass Walls";
        }

        public void BuildDoors()
        {
            _house.Doors = "Sliding Glass Doors";
        }

        public void BuildWindows()
        {
            _house.Windows = "Floor-to-Ceiling Windows";
        }

        public void BuildRoof()
        {
            _house.Roof = "Flat Roof with Solar Panels";
        }

        public void BuildGarage()
        {
            _house.Garage = "Attached Garage with Electric Car Charger";
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}
