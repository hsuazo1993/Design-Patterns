namespace Design_Patterns_Dotnet.Factory_Method.NotificationExample
{
    // Notification Factory
    public static class NotificationFactory
    {
        public static INotification CreateNotification(string notificationType)
        {
            switch (notificationType.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new ArgumentException("Invalid notification type.");
            }
        }
    }
}
