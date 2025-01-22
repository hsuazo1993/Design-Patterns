namespace Design_Patterns_Dotnet.Factory_Method.NotificationExample
{
    // Define the Notification interface
    public interface INotification
    {
        void Send(string message, string recipient);
    }
}
