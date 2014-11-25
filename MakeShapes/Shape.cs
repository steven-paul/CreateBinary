using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeShapes
{
    internal class Shape
    {
        internal virtual void Print()
        {
            Console.WriteLine("I am a generic shape.");
        }
    }
    internal class Circle:Shape
    {
        internal override void Print()
        {
            Console.WriteLine("I am a circle.");
        }
    }
    internal class Square:Shape
    {
        internal override void Print()
        {
            Console.WriteLine("I am a square.");
        }
    }
    internal class Triangle:Shape
    {
        internal override void Print()
        {
            Console.WriteLine("I am a triangle.");
        }
    }
}
