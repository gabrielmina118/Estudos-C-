using System;
using BaltaPoo.ContentContext;

namespace BaltaPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo 1", "orientacao-objeto"));
            articles.Add(new Article("Artigo 2", "segurancao-informacao"));
            articles.Add(new Article("Artigo 3", "banco de dados"));

            var courses = new List<Course>();
            var course = new Course("Fundamentos OOP", "fundamentos oop");
            var courseAspNet = new Course("Fundamentos aspNet", "fundamentos aspnet");
            
            courses.Add(course);
            courses.Add(courseAspNet);

            var careerList = new List<Career>();
            var careerDotnet = new Career("Desenvolvedor .net", "dev dotnet");
            var careerItem = new CareerItem(1, "Começe por aqui", "", course);
            var careerItemSegundo = new CareerItem(2, "Continue estudando", "", null);

            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItemSegundo);
            careerList.Add(careerDotnet);

            foreach(var career in careerList){
                foreach(var item in career.Items.OrderBy(x=> x.Ordem)){
                    Console.WriteLine($"{item.Ordem} - {item.Title} -  {item.Course?.Title}");

                    foreach(var notification in item.Notifications){
                        Console.WriteLine($"Notificação - {notification.Message}");
                    }
                }
            }
        }
    }
}