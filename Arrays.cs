using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declares 1D array of strings
            string[] weekDays;

            // allocating memory for days
            weekDays = new string[] { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

            // displaying each of elemnts of array
            foreach(string i in weekDays)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
