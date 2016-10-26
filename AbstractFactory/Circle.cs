﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Circle :IShape
    {
        public virtual void Print()
        {
            Console.WriteLine("Circle");
        }
    }
}
