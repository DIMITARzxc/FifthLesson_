using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractise
{
    public class Human
    {

    }
     public class Cat
    {
         public string Name;
         public int Age;
        public Cat Father;
        public Cat Mother;
        public Human Owner;

        public void Voice()
        {
            Console.WriteLine($"Meow My name is {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var catBob = new Cat();
            catBob.Name = "Bob";
            catBob.Age = 3;
            var catJohn = new Cat();
            catJohn.Name = "John";
            catJohn.Age = 1;
            catJohn.Father = catBob;
            catBob.Voice();
            catJohn.Voice();
            Console.Read();
        }
    }
}
