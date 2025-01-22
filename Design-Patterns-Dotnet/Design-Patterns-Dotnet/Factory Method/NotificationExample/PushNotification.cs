namespace Design_Patterns_Dotnet.Factory_Method.NotificationExample
{
    // Concrete Notification classes
    public class PushNotification : INotification
    {
        public void Send(string message, string recipient)
        {
            // Logic to send push notification using recipient device token
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
        }
    }
}
