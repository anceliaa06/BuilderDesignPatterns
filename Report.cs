using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssign
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }

        public void Display(string format)
        {
            Console.WriteLine($"--- {format.ToUpper()} REPORT ---");
            Console.WriteLine($"Title  : {Title}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine($"Footer : {Footer}");
        }
    }
}
