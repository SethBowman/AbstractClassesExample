using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class Dog : Animal
    {
        public override void AbstractAnimal()
        {
            Console.WriteLine("Dog is abstract");
        }

        public override void VirtualAnimal()
        {
            Console.WriteLine("Dog is virtual");
        }
    }
}
