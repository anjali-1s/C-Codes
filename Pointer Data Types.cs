using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                // declaring variable
                int n = 10;

                // store variable n address location in pointer variable p
                int* p = &n;
                Console.WriteLine("value is:{0}", n);
                Console.WriteLine("Address is:{0}", (int)p);
                Console.ReadLine();
            }
        }
    }
}
