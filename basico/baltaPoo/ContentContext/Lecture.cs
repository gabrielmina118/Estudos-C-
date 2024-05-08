using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaltaPoo.ContentContext.Enums;

namespace BaltaPoo.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public int Title { get; set; }
        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}