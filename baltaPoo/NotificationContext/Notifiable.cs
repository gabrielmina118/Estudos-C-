namespace BaltaPoo.NotificationContex
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }
        public bool IsInvalid => Notifications.Any();

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}