namespace Design_Patterns_Dotnet.Factory_Method.NotificationExample
{
    // Concrete Notification classes
    public class EmailNotification : INotification
    {
        public void Send(string message, string recipient)
        {
            // Logic to send email using recipient email address
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
}
