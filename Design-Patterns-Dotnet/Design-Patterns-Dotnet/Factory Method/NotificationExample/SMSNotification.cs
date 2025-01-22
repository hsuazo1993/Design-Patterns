namespace Design_Patterns_Dotnet.Factory_Method.NotificationExample
{
    // Concrete Notification classes
    public class SMSNotification : INotification
    {
        public void Send(string message, string recipient)
        {
            // Logic to send SMS using recipient phone number
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }
}
