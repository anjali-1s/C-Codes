using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nitem = 5;
            switch (nitem)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 9:
                    Console.WriteLine("case 9");
                    break;

                default:
                    Console.WriteLine("No match Found");
                    break;
            }

            string day = "Wednesday";
            switch (day)
            {
                case "monday":
                    Console.WriteLine("it is monday");
                    break;

                case "Tuesday":
                    Console.WriteLine("it is tuesday");
                    break;

                case "Wednesday":
                    Console.WriteLine("it is wednesday");
                    break;

                case "Thursday":
                    Console.WriteLine("it is thursday");
                    break;

                case "Friday":
                    Console.WriteLine("it is friday");
                    break;

                case "Saturday":
                    Console.WriteLine("it is saturday");
                    break;

                case "Sunday":
                    Console.WriteLine("it is sunday");
                    break;

                default:
                    Console.WriteLine("invalid case");
                    break;
            }
            Console.ReadLine();
        }
    }
}
