using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static int Addition(int a)
        {
            int add = a + a;
            return add;
        }

        static void Main(string[] args)
        {
            // while Loop
            int x = 1;
            // Exit when x becomes greater than 4
            while(x <= 4)
            {
                Console.WriteLine("Geeks For Geeks");
                x++;
            }

            // for loop
            for(int y = 1; y <= 4; y++)
            {
                Console.WriteLine("Geeks For Geeks");
            }

            // foreach loop
            Console.WriteLine("Print Array:");

            // creating an array
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach(int items in arr)
            {
                Console.WriteLine(items);
                //Console.WriteLine();
            }
            

            // jump statements
            // break statements
            for(int i = 1; i < 4; i++)
            {
                if( i == 3)
                    break;


                Console.WriteLine("Geeks For Geeks");
            }

            // continue statements
            for(int j = 1; j < 10; j++)
            {
                if (j == 4)
                    continue;

                Console.WriteLine(j);
            }

            // goto statements
            int number = 20;
            switch (number)
            {
                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 10:
                    Console.WriteLine("case 10");
                    break;

                case 20:
                    Console.WriteLine("case 20");
                    goto case 5;

                default:
                    Console.WriteLine("No match found");
                    break;
            }


            // return statements
            int num = 2;
            int result = Addition(num);
            Console.WriteLine("The Addition is {0}", result);

            Console.ReadLine();
        }
    }
}
