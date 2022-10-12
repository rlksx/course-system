namespace course_system.NotificationContext
{   
    // superclasse abstrata que vai conter métodos para gerar noficação; 
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddRangeNotification(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }
    }  
}