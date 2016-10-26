using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public interface IShapeFactory
    {
        Rectangle CreateRectangle();
        Circle CreateCircle();
    }
}
