namespace course_system.ContentContext
{
    public class CareerItem 
    // classe item da carreira que organiza o cursos da carreira;
    {
        public int Order { get; set; } // ordem dos cursos;
        public string Title { get; set; } // Titulo da carreira;
        public string Description { get; set; } // descrição da carreira;
        public Course Courses { get; set; } // Cursos da carreira;

    }
}