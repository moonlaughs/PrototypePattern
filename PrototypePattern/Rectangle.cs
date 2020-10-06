using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Rectangle : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Rectangle(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Rectangle(Rectangle source)
        {
        }

        public IShape Clone()
        {
            return new Rectangle(this);
        }
    }
}
