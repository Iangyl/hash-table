using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class HashTable<T>
    {
        private List<T>[] array;
        public HashTable(int size)
        {
            array = new List<T>[size];
            for (int i = 0; i < 10; i++)
            {
                array[i] = new List<T>();
            }
        }
        private int HashCode(T value)
        {
            string strValue = value.ToString();
            if (strValue.Length <= 0) throw new Exception("Error: invalid value.");
            return HashCount(strValue);
        }
        private int HashCount(string strValue)
        {
            int result = 0;
            string concatStr = "";
            for (int i = 0; i < strValue.Length; i++)
            {
                concatStr += (int)strValue[i];
            }
            if (concatStr.Length >= 10) concatStr = concatStr.Substring(0, 9);
            int number = Int32.Parse(concatStr);
            if (number > array.Length - 1)
            {
                while(number != 0)
                {
                    int temp = number % 10;
                    number /= 10;
                    result += temp;
                }
            }
            result /= 2;
            if (result > array.Length - 1) return HashCount(result.ToString());
            return result;
        }
        public void Insert(T value)
        {
            int id = HashCode(value);
            array[id].Add(value);
        }
        public T[] Search(T value)
        {
            int id = HashCode(value);
            var result = (from item in array[id]
                          where item.Equals(value)
                          select item).ToArray();
            return result;
        }
    }
}
