using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class MyShapeFactory : IShapeFactory
    {

        public Rectangle CreateRectangle()
        {
            return new Rectangle();
        }

        public Circle CreateCircle()
        {
            return new Circle();
        }
    }
}
