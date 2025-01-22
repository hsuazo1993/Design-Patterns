namespace Design_Patterns_Dotnet.Builder.HouseExample
{
    // Define the builder interface (IHouseBuilder)
    public interface IHouseBuilder
    {
        void SetHouseType(string type);
        void AddRoom(string room);
        void BuildWalls();
        void BuildDoors();
        void BuildWindows();
        void BuildRoof();
        void BuildGarage();
        House GetHouse();
    }
}
