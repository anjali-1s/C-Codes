using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Refrence data types

            // declaring strings
            string a = "Geeks" + " ";

            // append in a
            a += "for" + " ";
            a = a + "Geeks";
            Console.WriteLine(a);

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine(obj);

            // to show type of object using GetType()
            Console.WriteLine(obj.GetType());
            Console.ReadLine();

        }
    }
}
