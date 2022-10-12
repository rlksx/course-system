using course_system.NotificationContext;
namespace course_system.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) 
            : base(title, url) {    }

        public IList<Notification> Notifications { get; set; }
    }
}