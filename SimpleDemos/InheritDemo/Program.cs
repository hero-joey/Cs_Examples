using System;

namespace InheritDemo
{
    class Shape
    {
        protected int Width;
        protected int Height;

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }


    class Rectangle : Shape
    {
        private int _area;

        public Rectangle(int width, int height) : base(width, height)
        {
            _area = 0;
        }

        public int GetArea()
        {
            _area = Width * Height;
            return _area;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(5, 6);
            Console.WriteLine("Area:{0}", rec.GetArea());
        }
    }
}
