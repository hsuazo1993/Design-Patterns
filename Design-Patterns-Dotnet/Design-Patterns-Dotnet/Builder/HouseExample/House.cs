using System.Text;

namespace Design_Patterns_Dotnet.Builder
{
    // Define the product (House)
    public class House
    {
        public string Type { get; set; } = string.Empty;
        public List<string> Rooms { get; set; } = new List<string>();
        public string Walls { get; set; } = string.Empty;
        public string Doors { get; set; } = string.Empty;
        public string Windows { get; set; } = string.Empty;
        public string Roof { get; set; } = string.Empty;
        public string Garage { get; set; } = string.Empty;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine("Rooms:");
            foreach (var room in Rooms)
            {
                sb.AppendLine($"- {room}");
            }
            sb.AppendLine($"Walls: {Walls}");
            sb.AppendLine($"Doors: {Doors}");
            sb.AppendLine($"Windows: {Windows}");
            sb.AppendLine($"Roof: {Roof}");
            sb.AppendLine($"Garage: {Garage}");
            return sb.ToString();
        }
    }
}
