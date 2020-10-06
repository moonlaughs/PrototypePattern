using System;
using System.Collections.Generic;
using System.Linq;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shapes");
            List<IShape> arrayOfShape = new List<IShape>();
            Rectangle rectangle = new Rectangle(2,5);
            arrayOfShape.Add(rectangle);

            Console.WriteLine(arrayOfShape.Count());

            arrayOfShape.Add(rectangle.Clone());
            Console.WriteLine(arrayOfShape.Count());
        }
    }
}
