using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaltaPoo.ContentContext
{
    public class Module
    {

        public Module()
        {
            // Inicializar no construtor , classes que dependem de classes
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

}