using System;
using System.IO;

namespace PrintStringDelegateDemo
{
    class Program
    {
        static FileStream _fileStream;
        static StreamWriter _streamWriter;

        // delegate declaration
        public delegate void PrintString(string s);

        // this method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        //this method prints to a file
        public static void WriteToFile(string str)
        {
            _fileStream = new FileStream("D:\\message.txt",
                FileMode.OpenOrCreate, FileAccess.Write);
            _streamWriter = new StreamWriter(_fileStream);
            _streamWriter.WriteLine(str);
            _streamWriter.Flush();
            _streamWriter.Close();
            _fileStream.Close();
        }

        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void SendString(PrintString ps)
        {
            ps("Hello World");
        }

        static void Main(string[] args)
        {
            PrintString ps1 = new PrintString(WriteToScreen);
            PrintString ps2 = new PrintString(WriteToFile);
            SendString(ps1);
            SendString(ps2);
            Console.ReadKey();
        }
    }
}
