using System;
using System.Collections.Generic;

namespace inClass9
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape margaret = new Shape(12);
            Console.WriteLine(margaret.GetArea());

            Rectangle jeremy = new Rectangle(2, 4);
            Console.WriteLine(jeremy.GetArea());

            Circle ken = new Circle(42);
            Console.WriteLine(ken.GetArea());

            List<Shape> friends = new List<Shape>//polymorphism
            {
                margaret, jeremy, ken,
                new Circle(5),
                new Rectangle(5,7)
            };

            Console.WriteLine();
            foreach(Shape friend in friends)
            {
                Console.WriteLine(friend.GetArea());
            }
        }
    }
}
