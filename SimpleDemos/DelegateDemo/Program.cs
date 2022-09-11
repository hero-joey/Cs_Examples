using System;

namespace DelegateDemo
{
    public delegate int FunctionDelegate(int a, int b);

    //C# 中的委托（Delegate）类似于 C 或 C++ 中函数的指针。
    class Program
    {
        private static int Factor = 2;

        static int Sum(int a, int b)
        {
            Console.WriteLine("Sum: {0} {1}", a, b);
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract: {0} {1}", a, b);
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            Console.WriteLine("Multiply: {0} {1}", a, b);
            return a * b * Factor;
        }


        static void Main(string[] args)
        {
            //实例化委托（Delegate）,一旦声明了委托类型，委托对象必须使用 new 关键字来创建，且与一个特定的方法有关
            FunctionDelegate sum = new FunctionDelegate(Sum);
            FunctionDelegate subtract = new FunctionDelegate(Subtract);
            FunctionDelegate multiply = new FunctionDelegate(Multiply);
            Console.WriteLine(sum(1, 2));
            Console.WriteLine(multiply(5, 6));
            Console.WriteLine(subtract(3, 4));

            Console.WriteLine("All result");

            //按照顺序执行所有的函数指针
            //委托的多播（Multicasting of a Delegate）
            FunctionDelegate all;
            all = sum;
            all += multiply;
            all += subtract;

            Console.WriteLine(all(1, 2));

        }
    }
}
