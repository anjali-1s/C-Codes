using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring character
            char a = 'G';

            // Integer Data Types is generally used for numeric values
            int i = 89;
            short s = 78;     // short ranges are 87878787878

            // long may uses Integer values which may signed or unsigned
            long l = 4564;

            // UInt data type is generally used for unsigned integer values
            uint ui = 85;
            ushort us = 76;     // gives range error

            // ulong data type is generally used for unsigned integer values
            ulong ul = 3624573;

            // by default fraction value is double in c#
            double d = 8.538674532;

            // for float use 'f' as suffix
            float f = 3.7330645f;

            // for decimal use 'm' as suffix
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsigned integer: " + ui);
            Console.WriteLine("Unsigned short: " + us);
            Console.WriteLine("Unsigned long: " + ul);

            // boolean data type
            bool b = true;
            if (b == true)
                Console.WriteLine("Hii Geek");
                
                Console.ReadLine();
        }
    }
}
