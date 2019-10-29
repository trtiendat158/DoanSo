using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class CircleClass
    {
        private double radius;
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }
        private string _color;
        public string color            //Thuoc tinh khong phai ham 
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        public CircleClass()
        {
            radius = 2.0;
            color = "red";
        }
        public CircleClass(double r)
        {
            radius = 2.0;
            color = "red";
        }
        public CircleClass (double r,string c)
        {
            radius = r;
            color = c;
        }
        public double GetRadius()
        {
            return radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("The circel has a radius is: {0} and color is: {1}", radius, color);
           // return base.ToString();
        }
      
    }
}
