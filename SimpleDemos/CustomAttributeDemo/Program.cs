using System;
using System.Net.Security;
using System.Reflection;

namespace CustomAttributeDemo
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    class AuthorInfo : Attribute
    {
        private string _name;
        private int _id;

        public AuthorInfo(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public string Name => _name;

        public int Id => _id;
    }


    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    class BugInfo : Attribute
    {
        private string _author;
        private int _level;
        private string _tester;

        public BugInfo(string author, int level, string tester)
        {
            _author = author;
            _level = level;
            _tester = tester;
        }

        public string Author => _author;

        public int Level => _level;

        public string Tester
        {
            get => _tester;
            set => _tester = value;
        }
    }


    [AuthorInfo(name:"hero", id:318)]
    class Program
    {
        [BugInfo(author:"SomeOne", level:0, tester:"Tester1")]
        public static void Test()
        {
            Console.WriteLine("Just for test!");
        }

        public static void Main(string[] args)
        {
            Type type = typeof(Program);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                if (!((attribute as AuthorInfo) is null))
                {
                    AuthorInfo authorInfo = (AuthorInfo)attribute;
                    Console.WriteLine(authorInfo.Name);
                    Console.WriteLine(authorInfo.Id);
                }
            }
            
            //返回为当前 Type 的所有公共方法
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var methodInfo in methodInfos)
            {
                object[] methodAttributes = methodInfo.GetCustomAttributes(false);
                foreach (var methodAttribute in methodAttributes)
                {
                    if (!((methodAttribute as BugInfo) is null))
                    {
                        BugInfo bugInfo = (BugInfo)methodAttribute;
                        Console.WriteLine(bugInfo.Author);
                        Console.WriteLine(bugInfo.Level);
                        Console.WriteLine(bugInfo.Tester);
                    }
                }
            }
        }
    }
}
