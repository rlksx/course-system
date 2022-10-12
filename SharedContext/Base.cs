using course_system.NotificationContext;
namespace course_system.SharedContext
{
    public class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base() => Id = Guid.NewGuid();
    }
}