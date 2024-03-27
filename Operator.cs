using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1, result4, result5;
            bool result2, result3;

            int x = 10, y = 5;

            // using Arithmetic Operator
            result1 = (x + y);
            Console.WriteLine("Sum is:" + result1);

            // using Relation Opearator
            result2 = (x == y);
            Console.WriteLine("Equal to operator:" + result2);

            bool a = true;
            bool b = false;

            // logical operator
            result3 = a && b;
            Console.WriteLine("AND Operator:" + result3);

            // using Bitwise Opeartor
            result4 = x & y;
            Console.WriteLine("Bitwise AND:" + result4);


            //initialising variable m using simple Assignment operator "="

            // using Assignment operator
            int m = 15;

            // it means m = m + 10
            m += 10;
            Console.WriteLine("Add Assignment Operator:" + m);

            // using conditional operator
            result5 = x < y ? x : y;
            Console.WriteLine("Result:" + result5);
            Console.ReadLine();
        }
    }
}
