using System;

namespace IndexerDemo
{
    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        //重载索引器, 键值为string
        public T this[string indexName]
        {
            get
            {
                int index = Convert.ToInt32(indexName);
                return arr[index];
            }

            set
            {
                int index = Convert.ToInt32(indexName);
                 arr[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";
            stringCollection["1"] = "You are my hero!";
            Console.WriteLine(stringCollection[0]);
            Console.WriteLine(stringCollection[1]);
        }
    }
}
