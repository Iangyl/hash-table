using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class HashTable
    {
        private List<int>[] array = new List<int>[10];
        public HashTable()
        {
            for (int i = 0; i < 10; i++)
            {
                array[i] = new List<int>();
            }
        }
        private int HashCode(int value)
        {         
            string str = value.ToString();
            if (str.Length > 1) return HashCount(value);
            else return value;
        }
        private int HashCount(int value)
        {
            int result = 0;
            while (value > 0)
            {
                int temp = value % 10;
                result += temp;
                value /= 10;
            }
            if (result > 9) return HashCount(result);
            return result;
        }
        public void Insert(int value)
        {
            int id = HashCode(value);
            array[id].Add(value);
        }
        public int[] Search(int value)
        {
            int id = HashCode(value);
            var result = (from item in array[id]
                         where item == value
                         select item).ToArray();
            return result;
        }
    }
}
