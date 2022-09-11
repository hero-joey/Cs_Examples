using System;

namespace NameSpaceLib
{
    public class NameSpaceClsFirst
    {
        public static void Print()
        {
            Console.WriteLine(typeof(NameSpaceClsFirst).FullName);
        }
    }

    internal class NameSpaceClsSecond
    {
        public static void Print()
        {
            Console.WriteLine(typeof(NameSpaceClsSecond).FullName);
        }
    }
}
