using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    

    class CustomHashMap
    {
        private static readonly int SIZE = 16;
        private LinkedList<Entry>[] table;

        public CustomHashMap()
        {
            table = new LinkedList<Entry>[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                table[i] = new LinkedList<Entry>();
            }
        }

        private int GetHash(string key)
        {
            return Math.Abs(key.GetHashCode() % SIZE);
        }

        public void Put(string key, int value)
        {
            int hash = GetHash(key);
            LinkedList<Entry> bucket = table[hash];

            foreach (Entry entry in bucket)
            {
                if (entry.Key.Equals(key))
                {
                    entry.Value = value;
                    return;
                }
            }
            bucket.AddLast(new Entry(key, value));
        }

        public int? Get(string key)
        {
            int hash = GetHash(key);
            LinkedList<Entry> bucket = table[hash];

            foreach (Entry entry in bucket)
            {
                if (entry.Key.Equals(key))
                {
                    return entry.Value;
                }
            }
            return null;
        }

        public void Remove(string key)
        {
            int hash = GetHash(key);
            LinkedList<Entry> bucket = table[hash];
            bucket.RemoveAll(entry => entry.Key.Equals(key));
        }

        public void Display()
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("Bucket " + i + ": ");
                foreach (Entry entry in table[i])
                {
                    Console.Write("[" + entry.Key + " -> " + entry.Value + "] ");
                }
                Console.WriteLine();
            }
        }

        private class Entry
        {
            public string Key { get; set; }
            public int Value { get; set; }

            public Entry(string key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }

    public class Demo
    {
        public static void Main()
        {
            CustomHashMap map = new CustomHashMap();
            map.Put("one", 1);
            map.Put("two", 2);
            map.Put("three", 3);
            map.Put("key1", 4);
            map.Put("hello", 5);

            Console.WriteLine("Value for key 'two': " + map.Get("two"));
            map.Remove("two");
            Console.WriteLine("Value for key 'two' after removal: " + map.Get("two"));

            map.Display();
        }
    }

}
