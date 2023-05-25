using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public string Name { get; set; }

        public virtual void VirtualShape()
        {
            Console.WriteLine($"This is a shape");
        }
    }
}
