using System;

namespace InterfaceIComparable
{
    public class Circle:Shape
    {
        private double radius = 1.0;
        protected double GetRadius()
        { 
            return radius;
        }
        protected void SetRadius(double radius)
        {
            this.radius=radius;
        }
        public Circle(){}
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color,filled)
        {
            this.radius = radius;
        }
        private double GetArea ()
        {
            return radius*radius*3.14;
        }
        private double GetPerimeter ()
        {
            return 2*radius*3.14;
        }
        public override string ToString()
        {
            return "A Circle with radius "+ GetRadius()+ " which is a subclass of " + base.ToString();
        }
    }
}