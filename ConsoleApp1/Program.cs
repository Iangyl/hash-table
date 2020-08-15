using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<string> table = new HashTable<string>(10);
            table.Insert("Вова");
            table.Insert("Даня");
            table.Insert("Кирилл");
            var result = table.Search("Кирилл");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
