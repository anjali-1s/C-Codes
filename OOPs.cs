using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Dog
    {
        string name;
        string breed;
        string color;
        int age;

        // constructor
        public Dog(string name,string breed,string color,int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }

        // property 1
        public string getName()
        {
            return name;
        }

        // property 2
        public string getBreed()
        {
            return breed;
        }

        // property 3
        public string getColor()
        {
            return color;
        }

        // property 4
        public int getAge()
        {
            return age;
        }

        // method 1
        public string tostring()
        {
            return ("Hii my name is:" + " "  + this.getName() + "\nMy breed,color,age are:" + " " + this.getBreed() + "," + this.getColor() + "," + this.getAge());
        }

        // main method
        public static void Main(string[] args)
        {
            Dog tuffy = new Dog("tuffy", "papillon", "White", 5);
            Console.WriteLine(tuffy.tostring());
            Console.ReadLine();
        }
    }
}

