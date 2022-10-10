using course_system.Enums;

namespace course_system.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationLevel { get; set; }
        public EContentLevel Level { get; set; }

        public Course(string title, string url)
            : base(title, url)
        {
            Modules = new List<Module>();
        }
    }
}
