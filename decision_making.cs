using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if Statements

            string name = "Geeks";
            if(name == "Geeks")
            {
                Console.WriteLine("Geeks For Geeks");
            }

            // if - else Statements

            int a = 30;
            int b = 45;
            if(a > b)
            {
                Console.WriteLine("a is greater");
            }
            else
            {
                Console.WriteLine("b is greater");
            }

            // if - else - if ladder
            int c = 67;
            if(a > b)
            {
                Console.WriteLine("a is greater");
            }
            else if (b > c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }

            // Nested - if statements
            if (a > 10)
            {
                if (a > 0)
                {
                    Console.WriteLine("value of a is:" + a);
                }
                else
                {
                    Console.WriteLine("Value is less than 0");
                }
            }
            else
            {
                Console.WriteLine("Condition not satisfied");
            }
            Console.ReadLine();
        }
    }
}
