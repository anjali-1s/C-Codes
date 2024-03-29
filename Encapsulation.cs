using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    public class DemoEncap
    {
        private string studentName;
        private int studentAge;

        public String Name
        {
            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }
        }

        public int Age
        {
            get
            {

                return studentAge;
            }

            set
            {
                studentAge = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DemoEncap demo = new DemoEncap();

            demo.Name = "Ankita";
            demo.Age = 21;

            Console.WriteLine("Name :" + demo.Name);
            Console.WriteLine("Age :" + demo.Age);
            Console.ReadLine();
        }
    }
}
