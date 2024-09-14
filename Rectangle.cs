using System;
using System.Diagnostics;

namespace InterfaceIComparableCircle
{
    public class Rectangle:Shape
    {
        public double width=1.0;
        public double height=1.0;
        public double GetWidth()
        {
            return width;
        }
        public virtual void SetWidth(double width)
        {
            this.width=width;
        }
        public double GetHeight()
        {
            return height;
        }
        public virtual void SetHeight(double height)
        {
            this.height=height;
        }
        public Rectangle(){}
        public Rectangle(double width,double height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(double width,double height, string color, bool filled) : base(color ,filled)
        {
            this.width = width;
            this.height = height;
        }
        private double GetArea ()
        {
            return width*height;
        }
        private double GetPerimeter ()
        {
            return 2*(width+height);
        }
        public override string ToString()
        {
            return "A Rectangle with width = " + width+ " and length = " + height +" which is a subclass of " + base.ToString();
        }
    }
}