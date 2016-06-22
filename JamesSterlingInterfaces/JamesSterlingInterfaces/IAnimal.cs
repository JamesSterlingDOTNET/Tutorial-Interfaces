using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesSterlingInterfaces
{
    public interface IAnimal
    {
        string Eat();
        string MakeSound();
        void Sleep();
        string Drink();
        void Move();
    }
}
