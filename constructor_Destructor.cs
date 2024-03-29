using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_destructor
{

    class complex
    {
        int real, img;

        public complex()
        {
            real = 0;
            img = 0;
        }

        // to set the value of real and img
        public void setValue(int r, int i)
        {
            real = r;
            img = i;
        }

        public void DisplayValue()
        {
            Console.WriteLine("Real :" + real);
            Console.WriteLine("img :" + img);
        }

        ~complex()
        {
            Console.WriteLine("Destructor was called");
        }
    }

    internal class Program
    {
        string name;
        int id;

        Program(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
        static void Main(string[] args)
        {

            Program pgrm = new Program("Anjali", 123);
            Console.WriteLine("Name :" + " " + pgrm.name + "\nId :" + " " + pgrm.id);

            // creating complex class object
            complex c = new complex();
            c.setValue(2, 3);
            c.DisplayValue();
            Console.WriteLine("Hii");
        }
    }

}
