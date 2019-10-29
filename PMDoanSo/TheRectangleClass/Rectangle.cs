using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRectangleClass
{
    class Rectangle
    {
        private float Length;
        private float Width;

        public Rectangle()
        {
            Length = 6.0f;
            Width = 3.0f;
        }

        public Rectangle(float Length, float Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public float GetLength()
        {
            return Length;
        }

        public void SetLength(float NewLength)
        {
            Length = NewLength;
        }

        public float GetWidth()
        {
            return Width;
        }

        public void SetWidth(float NewWidth)
        {
            Width = NewWidth;
        }
        public double GetArea()
        {
            return Width * Length;
        }
        public double GetPerimater()
        {
            return (Width + Length) / 2;
        }
        public override string ToString()
        {
            return string.Format("The rectangle has a Length is: {0}  \nWidth is: {1} \nAre is: {2} \nPerimeter is: {3}", GetLength(), GetWidth(), GetArea(),GetPerimater());
        }
    }
}
