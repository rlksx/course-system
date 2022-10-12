using course_system.NotificationContext;
namespace course_system.ContentContext
{
    public class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base() => Id = Guid.NewGuid();
    }
}