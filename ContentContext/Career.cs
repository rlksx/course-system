namespace course_system.ContentContext
{
    public class Career : Content
    {
        // items
        public IList<CareerItem> Items { get; set; }

        // quantidade de cursos da careira;
        public int TotalCourses => Items.Count; // Expression Body;
        
        public Career(string title, string url) : base(title, url)
        {
            // lista de item da carreira.
            Items = new  List<CareerItem>(); 
        }
    }
} 