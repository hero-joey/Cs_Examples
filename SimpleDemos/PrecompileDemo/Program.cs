//#define指令常和#if条件语句结合使用，单独使用无意义,
//#define与#undef声明必须放在C#源文件的开头位置，即程序集的引用的上方,不然将报错
#define PI
#define PI2
#undef PI2
using System;

namespace PrecompileDemo
{
    class Program
    {
        #region CheckCrc
        public static void CheckCrc()
        {

        }
        #endregion

        static void Main(string[] args)
        {
            #if (PI)
                Console.WriteLine("PI is defined");
#else
                Console.WriteLine("PI is not defined");
#endif

            //PI2定义后, 被取消
            #if (PI2)
                Console.WriteLine("PI2 is defined");
            #else
            #endif
                Console.WriteLine("PI2 is not defined");
        }
    }
}
