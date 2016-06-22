using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesSterlingInterfaces
{
    public class Lion : IAnimal
    {
        public string Name { get; set; }

        public string Drink()
        {
            return Name + " is drinking.";
        }

        public string Eat()
        {
            return Name + " is eating some meat.";
        }

        public string MakeSound()
        {
            return Name + "HRRAWWW";
        }

        public void Move()
        {
            Console.WriteLine(Name + " is crawling.");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " is sleeping like a real lion.");
        }
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public string Drink()
        {
            return Name + " is drinking like a hero!";
        }

        public string Eat()
        {
            return Name + " is eating tuna.";
        }

        public string MakeSound()
        {
            return Name + " is barking!";
        }

        public void Move()
        {
            Console.WriteLine(Name + " is running!");
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " is sleeping next to his boss");
        }
    }
}
