using course_system.SharedContext;
namespace course_system.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; } // numero da ordem da aula;
        public string Title { get; set; } // titulo da aula;
        public int DurationInMinutes { get; set; } // duração da auça;
        public Enums.EContentLevel Level { get; set; } // nivel da aula;
    }
}  