//#define DUMP 
using System;
using System.Diagnostics;

namespace AttributeDemo
{
    class TestClass2
    {
        [Obsolete("Use new DumpNew")]
        public static void DumpOld()
        {
            Console.WriteLine("DumpOld");
        }

        public static void DumpNew()
        {
            Console.WriteLine("DumpNew");
        }

    }

    public class Myclass
    {
        //Conditional预定义特性标记了一个条件方法，其执行依赖于指定的预处理标识符。
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }

        [Conditional("DUMP")]
        public static void Dump(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //仅DEBUG打印, Release不会打印
            Myclass.Message("Hello");
            Myclass.Dump("World");

            //系统提示过时的函数
            TestClass2.DumpOld();
        }
    }
}
