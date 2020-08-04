using System;
using System.Collections.Generic;
using System.Text;

namespace inClass9
{
    class Shape
    {
        //Property
        public double X { get; set; }

        //Constructors
        public Shape(double X)
        {
            //The 'this' property X is being set to the parameter X
            this.X = X;
        }

        //method
        //virtual keyword is a way for us to make a method that is implemented at the parent level
        //but it can be overriden by each child class in their own way
        public virtual double GetArea()
        {
            return 1;
        }
    }

}
