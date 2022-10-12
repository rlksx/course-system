using course_system.NotificationContext;
namespace course_system.ContentContext
{
    public class CareerItem : Base
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

            // if (course == null)
            //     throw new System.Exception("O curso não pode ser nulo!");
            //     // um custo alto no processamento e a execução é parada.

            if (course == null)
                AddNotification( new Notification("course" + order, "Curso Invalido") );
        }
    } 
} 