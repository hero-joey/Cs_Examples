using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            arrayList.Add(45);
            arrayList.Add(78);
            arrayList.Add(33);
            arrayList.Add(56);
            arrayList.Add(12);
            arrayList.Add(23);
            arrayList.Add(9);

            Console.WriteLine("Capacity: {0} ", arrayList.Capacity);
            Console.WriteLine("Count: {0}", arrayList.Count);

            Console.Write("Content: ");
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            arrayList.Sort();
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");
            ht.Add("008", null);

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("009", "Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();


            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(1, 2);
            dictionary.Add(2, 4);
            dictionary.Add(3, 6);
            Console.WriteLine(dictionary[3]);
        }
    }
}
