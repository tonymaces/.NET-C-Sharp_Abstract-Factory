using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class MyCircle :Circle
    {
        public override void Print()
        {
            Console.WriteLine("MyCircle");
        }
    }
}
