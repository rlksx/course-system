namespace course_system.ContentContext
{
    public class Module // módulos do curso
    {
        public int Order { get; set; } // ordem dos módulos do curso
        public string Title { get; set; } // titulo do módulo
        public IList<Lecture> Lectures { get; set; } // lista das aulas contidas no módulo

        public Module()
        {
            Lectures = new List<Lecture>();
        }
    }
}