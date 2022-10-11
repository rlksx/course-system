namespace course_system.ContentContext
{
    public class CareerItem 
    // classe item da carreira que organiza o cursos da carreira;
    {
        public int Order { get; set; } // ordem do curso;
        public string Title { get; set; } // Titulo do curso;
        public string Description { get; set; } // descrição da curso
        public Course Course { get; set; } // curso;

        public CareerItem(int order, string title, string description, Course course)
        {
            this.Order = order;
            this.Title = title;
            this.Description = description;
            this.Course = course;

            if (Course == null)
                throw new System.Exception("O curso não pode ser nulo!");
        }
    }
}