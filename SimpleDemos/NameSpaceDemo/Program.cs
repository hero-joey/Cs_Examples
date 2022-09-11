using System;
using ThirdNameSpace;
using NameSpaceLib;

namespace FirstNameSpace
{
    internal class MyNameSpace
    {
        public static void Print()
        {
            Console.WriteLine("First namespace");
        }
    }
}

namespace SecondNameSpace
{
    internal class MyNameSpace
    {
        public static void Print()
        {
            Console.WriteLine("Second namespace");
        }
    }
}

namespace ThirdNameSpace
{
    class MyNameSpace
    {
        public static void Print()
        {
            Console.WriteLine("Third namespace");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(typeof(Program).Namespace);
        FirstNameSpace.MyNameSpace.Print();
        SecondNameSpace.MyNameSpace.Print();

        MyNameSpace.Print();

        //引用外部dll中的public类
        NameSpaceClsFirst.Print();
        //引用外部dll中的内部类, 无法访问
        //NameSpaceLib.NameSpaceClsSecond.Print();
    }
}

