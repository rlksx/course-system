namespace course_system.ContentContext
{   
    // superclasse abstrata
    public abstract class Content : Base
    {
        public string Title { get; set; }
        public string Url { get; set; }        

        public Content(string title, string url)
        {
            this.Title = title;
            this.Url = url;
        }

    }
}