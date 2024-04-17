using BaltaPoo.ContentContext.Enums;

namespace BaltaPoo.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            // Inicializar no construtor , classes que dependem de classes
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }



}