using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> s = new List<Shape>();
            s.Add(new Triangle { });
            s.Add(new Square { });
            s.Add(new Circle { });
            s.Add(new Shape { });
            foreach (Shape shape in s)
            {
                shape.Print();
            }
            Console.ReadLine();
        }
    }
}