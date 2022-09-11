using System;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;


            bool? boolval = new bool?(); 
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            // display the values
            Console.WriteLine("A Nullable boolean value: {0}", boolval);


            double num5 = num1 ?? 2.5;
            Console.WriteLine("Number5:{0}", num5);

            int num6 = num2 ?? 10;
            Console.WriteLine("Number6:{0}", num6);

        }
    }
}
