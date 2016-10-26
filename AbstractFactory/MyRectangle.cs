using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class MyRectangle :Rectangle
    {
        public override void Print()
        {
            Console.WriteLine("MyRectangle");
        }
    }
}
