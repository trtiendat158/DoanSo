using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCircle
{
    class Circle
    {
        private double Radius;
        public Circle()
        {
            Radius = 1.0;
        }
        public Circle(double Radius )
        {
            this.Radius = Radius;
        }

        public double GetRadius()
        {
            return Radius;
        }

        public void SetRadius(double NewRadius)
        {
            Radius = NewRadius;
        }

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public double Circumference()
        {
            return (Radius * 2) * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("The circel has a radius is: {0}  \nArea is: {1} \nCir is: {2}", GetRadius(), GetArea(), Circumference());
        }
    }
}
