using course_system.ContentContext;
namespace course_system {

    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // carreira back end;
            var careers = new List<Career>();
            var backend = new Career("Carreira Backend com .NET", "Neste curso você vai aprender os fundamentos da programação com C#");

            // cursos da carreiras;
            var courses = new List<Course>(); 
            var course01 = new Course("Fundamentos do C#", "csharp-fundamentals");
            var course02 = new Course("Programação Orientdada a Objetos", "oop-course");
            var course03 = new Course("SQL Server", "sqlserver-course");  

            // adicionando a lista de cursos;
            courses.Add(course01);
            courses.Add(course02);
            courses.Add(course03);
            
            // criando items da carreira e adicionand cursos á carreira
            var fundamentalsCsharp = new CareerItem(1, "Fundamentos C#", "0", course01); // curso da carreira 
            var OOP = new CareerItem(2, "Programação Orientada a Objeto", "0", course02); // curso da carreira 
            var SQLSever = new CareerItem(3, "SQL Sever", "0", course03); // curso da carreira 

            // adicionando items da carreira back end, como titulo, descrição e cursos;
            backend.Items.Add(SQLSever); // ordem 3
            backend.Items.Add(OOP); // ordem 2
            backend.Items.Add(fundamentalsCsharp); // ordem 1

            // adicionando carreias na lista de carreiras;
            careers.Add(backend);

            // quantidade de cursos da carreira back end;
            Console.Write($"A carreira backend possuí {backend.TotalCourses} curso(s)!\n");
            
            // ordem dos cursos
            foreach (var career in careers) {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order) ) { // OrderBy e OrderByDeceding;
                    // ordenando cursos ddas carreiras
                    Console.WriteLine($"{item.Order} - {item.Title} - Nivel: {item.Course.Level}"); 
                }
            }

            // artigos
            var articles = new List<Article>();
            // adicionando um artigos
            articles.Add(new Article("Novidades .NET 22", "dotnet22-news"));
            articles.Add(new Article("O que é SQL Sever", "whats-sqlsever"));
            articles.Add(new Article("Principios de Programção Orientada a Objetos", "oop-principles"));
            // percorrendo os artigos
            foreach (var article in articles)
            {
                Console.WriteLine($"\nTitulo do artigo: {article.Title}");
                Console.WriteLine($"Identificador do artigo: {article.Id}");
                Console.WriteLine($"Url do Artigo: {article.Url}" );
            }
             
        }
    }
}