using System;
using System.Collections.Generic;
using System.Text;

namespace inClass9
{
    //Rectangle is inherriting from the Shape class
    class Rectangle : Shape
    {
        public double Y { get; set; }

        // :base 
        public Rectangle(double Length, double Width) : base(Length)//<--- only for constructors
        {
            //Already happening because of :base(Length) --->  X = Length;
            Y = Width;
        }

        public override double GetArea()
        {
            //because X is the public property of the base (parent) class
            //we can use it here as a property of the derived (child) class
            return X * Y;
        }
    }
}
