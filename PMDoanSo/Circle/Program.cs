using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleClass c1 = new CircleClass();
            Console.WriteLine("Radius is {0}",c1.GetRadius());
            Console.WriteLine("Area is {0}", c1.GetArea());

            CircleClass c2 = new CircleClass(3.0);
            Console.WriteLine("Radius is {0}", c2.GetRadius());
            Console.WriteLine("Area is {0}", c2.GetArea());

            CircleClass c3 = new CircleClass(4.0, "Orange");
            Console.WriteLine("Radius is {0}", c3.GetRadius());
            Console.WriteLine("Color is {0}", c3.color);

            CircleClass c4 = new CircleClass();
            c4.SetRadius(5.0);
            c4.color="Dark";
            Console.WriteLine("Radius is: " + c4.GetRadius() + "\nColor is: "+c4.color);

            Console.WriteLine(c4.ToString());
        }
    }
}
