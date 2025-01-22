using Design_Patterns_Dotnet.Builder.CarExample;
using Design_Patterns_Dotnet.Builder.HouseExample;
using Design_Patterns_Dotnet.Builder.PizzaExample;
using Design_Patterns_Dotnet.Factory_Method.CharacterExample;
using Design_Patterns_Dotnet.Factory_Method.DocumentExample;
using Design_Patterns_Dotnet.Factory_Method.NotificationExample;
using Design_Patterns_Dotnet.Strategy.CompressionExample;
using Design_Patterns_Dotnet.Strategy.DiscountExample;
using Design_Patterns_Dotnet.Strategy.ShippingExample;

bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

void PrintTitle()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@"
██████╗ ███████╗███████╗██╗ ██████╗ ███╗   ██╗                      
██╔══██╗██╔════╝██╔════╝██║██╔════╝ ████╗  ██║                      
██║  ██║█████╗  ███████╗██║██║  ███╗██╔██╗ ██║                      
██║  ██║██╔══╝  ╚════██║██║██║   ██║██║╚██╗██║                      
██████╔╝███████╗███████║██║╚██████╔╝██║ ╚████║                      
╚═════╝ ╚══════╝╚══════╝╚═╝ ╚═════╝ ╚═╝  ╚═══╝                      
                                                                    
██████╗  █████╗ ████████╗████████╗███████╗██████╗ ███╗   ██╗███████╗
██╔══██╗██╔══██╗╚══██╔══╝╚══██╔══╝██╔════╝██╔══██╗████╗  ██║██╔════╝
██████╔╝███████║   ██║      ██║   █████╗  ██████╔╝██╔██╗ ██║███████╗
██╔═══╝ ██╔══██║   ██║      ██║   ██╔══╝  ██╔══██╗██║╚██╗██║╚════██║
██║     ██║  ██║   ██║      ██║   ███████╗██║  ██║██║ ╚████║███████║
╚═╝     ╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝
                                                                    
██╗███╗   ██╗       ███╗   ██╗███████╗████████╗                     
██║████╗  ██║       ████╗  ██║██╔════╝╚══██╔══╝                     
██║██╔██╗ ██║       ██╔██╗ ██║█████╗     ██║                        
██║██║╚██╗██║       ██║╚██╗██║██╔══╝     ██║                        
██║██║ ╚████║    ██╗██║ ╚████║███████╗   ██║                        
╚═╝╚═╝  ╚═══╝    ╚═╝╚═╝  ╚═══╝╚══════╝   ╚═╝                        
");
    Console.ResetColor();
}

bool MainMenu()
{
    Console.Clear();
    //Console.WriteLine("--- Design Patterns in .NET ---");
    PrintTitle();
    Console.WriteLine("Choose a Design Pattern example:");
    Console.WriteLine("1. Builder");
    Console.WriteLine("2. Strategy");
    Console.WriteLine("3. Factory");
    Console.WriteLine("4. Exit");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            BuilderMenu();
            return true;
        case "2":
            StrategyMenu();
            return true;
        case "3":
            FactoryMenu();
            return true;
        case "4":
            return false;
        default:
            return true;
    }
}

void BuilderMenu()
{
    Console.Clear();
    Console.WriteLine("Choose a Builder example:");
    Console.WriteLine("1. Simple Pizza Builder");
    Console.WriteLine("2. House Builder with different types");
    Console.WriteLine("3. Fluent Car Builder");
    Console.WriteLine("4. Back to Main Menu");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            RunBuilderPatternPizzaExample();
            break;
        case "2":
            RunBuilderPatternHouseExample();
            break;
        case "3":
            RunFluentBuilderPatternCarExample();
            break;
        case "4":
            // Do nothing, will return to Main Menu
            break;
        default:
            BuilderMenu(); // Invalid option, show menu again
            break;
    }
}

void StrategyMenu()
{
    Console.Clear();
    Console.WriteLine("Choose a Strategy example:");
    Console.WriteLine("1. Shipping Costs Calculation Strategy");
    Console.WriteLine("2. File Compression Strategy");
    Console.WriteLine("3. Total Amount After Discount Calculation Strategy");
    Console.WriteLine("4. Back to Main Menu");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            RunStrategyPatternShippingExample();
            break;
        case "2":
            RunStrategyPatternCompressionExample();
            break;
        case "3":
            RunStrategyPatternDiscountExample();
            break;
        case "4":
            // Do nothing, will return to Main Menu
            break;
        default:
            StrategyMenu(); // Invalid option, show menu again
            break;
    }
}

void FactoryMenu()
{
    Console.Clear();
    Console.WriteLine("Choose a Factory example:");
    Console.WriteLine("1. Game Character Factory");
    Console.WriteLine("2. Document Factory");
    Console.WriteLine("3. Notification Factory");
    Console.WriteLine("4. Back to Main Menu");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            RunFactoryPatternCharacterExample();
            break;
        case "2":
            RunFactoryPatternDocumentExample();
            break;
        case "3":
            RunFactoryPatternNotificationExample();
            break;
        case "4":
            // Do nothing, will return to Main Menu
            break;
        default:
            FactoryMenu(); // Invalid option, show menu again
            break;
    }
}

#region Builder Pattern
void RunBuilderPatternHouseExample()
{
    Console.Clear();
    Console.WriteLine("House Builder with Different Types Example\n");
    Console.WriteLine("This example shows how to use the Builder pattern to create different types of houses (Modern, Victorian) with varying features (rooms, walls, roof, etc.).\n");

    // Build a modern house
    var modernHouseBuilder = new ModernHouseBuilder();
    var modernHouseDirector = new ConstructionDirector(modernHouseBuilder);
    modernHouseDirector.ConstructModernHouse();
    var modernHouse = modernHouseBuilder.GetHouse();
    Console.WriteLine("Modern House:\n" + modernHouse);

    // Build a Victorian house
    var victorianHouseBuilder = new VictorianHouseBuilder();
    var victorianHouseDirector = new ConstructionDirector(victorianHouseBuilder);
    victorianHouseDirector.ConstructVictorianHouse();
    var victorianHouse = victorianHouseBuilder.GetHouse();
    Console.WriteLine("\nVictorian House:\n" + victorianHouse);

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    BuilderMenu();
}

void RunBuilderPatternPizzaExample()
{
    Console.Clear();
    Console.WriteLine("Simple Pizza Builder Example\n");
    Console.WriteLine("This example demonstrates the basic Builder pattern. A Waiter (director) uses a PizzaBuilder to construct a Pizza with predefined steps (dough, sauce, topping).\n");

    // Construct Hawaiian pizza
    var hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
    var hawaiianWaiter = new Waiter(hawaiianPizzaBuilder);
    hawaiianWaiter.ConstructPizza();
    var hawaiianPizza = hawaiianPizzaBuilder.GetPizza();
    Console.WriteLine("Hawaiian Pizza:\n" + hawaiianPizza);

    // Construct Pepperoni pizza
    var pepperoniPizzaBuilder = new PepperoniPizzaBuilder();
    var pepperoniWaiter = new Waiter(pepperoniPizzaBuilder);
    pepperoniWaiter.ConstructPizza();
    var pepperoniPizza = pepperoniPizzaBuilder.GetPizza();
    Console.WriteLine("\nPepperoni Pizza:\n" + pepperoniPizza);

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    BuilderMenu();
}

void RunFluentBuilderPatternCarExample()
{
    Console.Clear();
    Console.WriteLine("Fluent Car Builder Example\n");
    Console.WriteLine("This example demonstrates the Fluent Builder pattern. It uses method chaining to construct a Car object with a more readable and expressive syntax.\n");

    var car = new CarBuilder()
    .WithMake("Toyota")
    .WithModel("Camry")
    .WithColor("Silver")
    .WithYear(2023)
    .Build();

    Console.WriteLine(car);

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    BuilderMenu();
}
#endregion

#region Strategy Pattern
void RunStrategyPatternShippingExample()
{
    Console.Clear();
    Console.WriteLine("Shipping Strategy\n");
    Console.WriteLine("This example demonstrates the Strategy pattern by simulating an e-commerce application with different shipping options (FedEx, UPS, USPS). The user can select their preferred shipping method, and the application will use the corresponding strategy to calculate the shipping cost.\n");

    Order order = new Order();

    Console.WriteLine("Select shipping method:");
    Console.WriteLine("1. FedEx");
    Console.WriteLine("2. UPS");
    Console.WriteLine("3. USPS");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            order.ShippingStrategy = new FedExShippingStrategy();
            break;
        case "2":
            order.ShippingStrategy = new UPSShippingStrategy();
            break;
        case "3":
            order.ShippingStrategy = new USPSShippingStrategy();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            return;
    }

    decimal totalCost = order.CalculateTotalCost();
    Console.WriteLine($"Total cost with shipping: {totalCost}");

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    StrategyMenu();
}

void RunStrategyPatternCompressionExample()
{
    Console.Clear();
    Console.WriteLine("Compression Strategy\n");
    Console.WriteLine("This example demonstrates the Strategy pattern for performing different file compression algorithms (ZIP, RAR). The user can choose the compression method, and the application will use the corresponding strategy to compress a file.\n");

    FileCompressor compressor = new FileCompressor();

    Console.WriteLine("Select compression method:");
    Console.WriteLine("1. ZIP");
    Console.WriteLine("2. RAR");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            compressor.CompressionStrategy = new ZipCompressionStrategy();
            break;
        case "2":
            compressor.CompressionStrategy = new RarCompressionStrategy();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            return;
    }

    compressor.Compress("myFile.txt");

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    StrategyMenu();
}

void RunStrategyPatternDiscountExample()
{
    Console.Clear();
    Console.WriteLine("Discount Strategy\n");
    Console.WriteLine("This example demonstrates the Strategy pattern for applying different discount strategies based on customer loyalty programs (Bronze, Silver, Gold). Each loyalty program has its own discount calculation strategy.\n");

    ShoppingCart cart = new ShoppingCart();

    Console.WriteLine("Enter customer loyalty level (Bronze, Silver, Gold):");
    string loyaltyLevel = Console.ReadLine();

    switch (loyaltyLevel.ToLower())
    {
        case "bronze":
            cart.DiscountStrategy = new BronzeDiscountStrategy();
            break;
        case "silver":
            cart.DiscountStrategy = new SilverDiscountStrategy();
            break;
        case "gold":
            cart.DiscountStrategy = new GoldDiscountStrategy();
            break;
        default:
            Console.WriteLine("Invalid loyalty level.");
            return;
    }

    decimal totalAmount = cart.CalculateTotalAmount(100m); // Example amount
    Console.WriteLine($"Total amount after discount: {totalAmount}");

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    StrategyMenu();
}
#endregion

#region Factory Pattern
void RunFactoryPatternCharacterExample()
{
    Console.Clear();
    Console.WriteLine("Character Factory\n");
    Console.WriteLine("This example demonstrates the Factory pattern by simulating a game with different types of characters (Goblin, Orc, Dragon). The CharacterFactory class provides a method to create different character types without the need for direct instantiation, promoting loose coupling and flexibility.\n");

    ICharacter character1 = CharacterFactory.CreateCharacter("goblin");
    ICharacter character2 = CharacterFactory.CreateCharacter("orc");
    ICharacter character3 = CharacterFactory.CreateCharacter("dragon");

    Console.WriteLine($"Character 1: {character1.Name}, Attack Power: {character1.AttackPower}, HP: {character1.HP}, Defense: {character1.Defense}");
    character1.Attack();
    character1.TakeDamage(15); // Example damage

    Console.WriteLine($"Character 2: {character2.Name}, Attack Power: {character2.AttackPower}, HP: {character2.HP}, Defense: {character2.Defense}");
    character2.Attack();
    character2.TakeDamage(30); // Example damage

    Console.WriteLine($"Character 3: {character3.Name}, Attack Power: {character3.AttackPower}, HP: {character3.HP}, Defense: {character3.Defense}");
    character3.Attack();
    character3.TakeDamage(20); // Example damage

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    FactoryMenu();
}

void RunFactoryPatternDocumentExample()
{
    Console.Clear();
    Console.WriteLine("Document Factory\n");
    Console.WriteLine("This example demonstrates the Factory pattern by simulating a document processing application. The DocumentFactory class provides a method to create different document objects (CV, Invoice) without the need for direct instantiation.\n");

    IDocument doc1 = DocumentFactory.CreateDocument("cv");
    IDocument doc2 = DocumentFactory.CreateDocument("invoice");

    doc1.Generate(); // Output: Generating a CV document...
    doc2.Generate(); // Output: Generating an Invoice document...

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    FactoryMenu();
}

void RunFactoryPatternNotificationExample()
{
    Console.Clear();
    Console.WriteLine("Notification Factory\n");
    Console.WriteLine("This example demonstrates the Factory pattern in a scenario where you have a notification system that needs to send notifications through different channels (Email, SMS, Push Notification). The NotificationFactory class provides a method to create different notification objects without exposing the channel-specific implementation details.\n");

    INotification notification1 = NotificationFactory.CreateNotification("email");
    notification1.Send("Hello!", "user@example.com");

    INotification notification2 = NotificationFactory.CreateNotification("sms");
    notification2.Send("Reminder!", "+15551234567");

    INotification notification3 = NotificationFactory.CreateNotification("push");
    notification3.Send("New message!", "device_token_123");

    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    FactoryMenu();
}
#endregion
