namespace course_system.NotificationContext
{   
    // superclasse abstrata que vai conter métodos para gerar noficação; 
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        // Iniciando lista;
        public Notifiable() => Notifications = new List<Notification>();

        // adicionar uma notificação;
        public void AddNotification(Notification notification) => Notifications.Add(notification);

        // adicionar varias notificações;
        public void AddRangeNotification(IEnumerable<Notification> notification) => Notifications.AddRange(notification);

        // verificando se há notificações;
        public bool IsInvalid => Notifications.Any();
    }  
}