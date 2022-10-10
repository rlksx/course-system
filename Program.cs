using course_system.ContentContext;
namespace course_system {

    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // carreira back end;
            var backend = new Career("Carreira Backend com .NET", null);
            // items da carreira back end, como titulo, descrição e cursos;
            backend.Items.Add(new CareerItem());
            // quantidade de cursos da carreira back end;
            Console.Write($"A carreira backend possuí {backend.TotalCourses} cursos!\n");

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