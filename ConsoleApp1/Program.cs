using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<int> table = new HashTable<int>(10);
            table.Insert(123);
            table.Insert(321);
            table.Insert(434);
            var result = table.Search(434);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
