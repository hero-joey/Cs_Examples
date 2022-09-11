using System;

namespace staticMethodDemo
{
    class StaticVar
    {
        private static int _elementCount = 0;

        public StaticVar()
        {
            ++_elementCount;
            Console.WriteLine("Constructor, Element count: {0}", _elementCount);
        }

        //静态构造函数用于初始化任何静态数据，或执行仅需执行一次的特定操作。
        //将在创建第一个实例或引用任何静态成员之前自动调用静态构造函数。
        static StaticVar()
        {
            _elementCount = 20;
        }

        ~StaticVar()
        {
            --_elementCount;
            Console.WriteLine("Deconstructor, Element count: {0}", _elementCount);
        }

        public void GetElementCount()
        {
            Console.WriteLine("Statistic, Element count: {0}", _elementCount);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticVar var1 = new StaticVar();
            StaticVar var2 = new StaticVar();
            StaticVar var3 = new StaticVar();
            var3.GetElementCount();
        }
    }
}
