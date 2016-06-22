using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesSterlingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Name = "LionKing";
            Dog dog = new Dog();
            dog.Name = "Phill";

            Console.WriteLine(dog.Eat());

            Console.ReadLine();
        }
    }
}
