using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IShapeFactory fac = new MyShapeFactory();
            Circle c = fac.CreateCircle();
            c.Print();
        }
    }
}
