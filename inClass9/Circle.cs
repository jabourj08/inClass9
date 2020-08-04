using System;
using System.Collections.Generic;
using System.Text;

namespace inClass9
{
    class Circle : Shape
    {
        //because Circle does not require any additional properties for area, skip to constructor

        public Circle(double radius) : base(radius)
        {
            //X = radius; This is happening automatically in the Shape(parent) class
        }

        public override double GetArea()
        {
            return Math.PI * (Math.Pow(X, 2));
        }
    }
}
