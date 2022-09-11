using System;
using System.Collections.Generic;

namespace PolymorphismDemo
{
    class Shape
    {
        protected string Name;
        protected int Width, Height;
        public Shape(string name, int width = 0, int height = 0)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
        }
        public virtual int Area()
        {
            Console.WriteLine("父类的面积：");
            return this.Width * this.Height;
        }

        public string GetName()
        {
            return Name;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base("Rectangle", a, b)
        {

        }
        public override int Area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (Width * Height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base("Triangle", a, b)
        {

        }
        public override int Area()
        {
            Console.WriteLine("Triangle 类的面积：");
            return (Width * Height / 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(4,5), 
                new Triangle(4,5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape name:{0}, area:{1}", shape.GetName(), shape.Area());
            }
        }

    }
}
