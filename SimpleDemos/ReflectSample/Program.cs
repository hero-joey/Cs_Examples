using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t1 = DateTime.Now.GetType();
            Console.WriteLine(t1.Name);

            Type t2 = typeof(DateTime);
            Console.WriteLine(t2.Name);

            Type t3 = typeof(DateTime[]);
            Console.WriteLine(t3.Name);

            Type t4 = typeof(Dictionary<int, string>);
            Console.WriteLine(t4.Name);

            Type t5 = typeof(Dictionary<,>);
            Console.WriteLine(t5.Name);

            Type stringType = typeof(string);
            string name = stringType.Name;

            Type baseType = stringType.BaseType;
            Assembly assembly = stringType.Assembly;

            bool isPublic = stringType.IsPublic;
            Console.ReadKey();
        }
    }
}
