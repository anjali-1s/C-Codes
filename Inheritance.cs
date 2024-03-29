using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GFG
    {
        public string name;
        public string subject;

        // public method of the base class
        public void readers(string name,string subject)
        {
            this.name = name;
            this.subject = subject;

            Console.WriteLine("Myself :" + name);
            Console.WriteLine("My Favourite Subject is :" + subject);
        }
    }

    class GeeksForGeeks : GFG
    {
        public GeeksForGeeks()
        {
            Console.WriteLine("Geeks For Geeks");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GeeksForGeeks g = new GeeksForGeeks();
            g.readers("AnJaLi", "C#");
            Console.ReadLine();
        }
    }
}
