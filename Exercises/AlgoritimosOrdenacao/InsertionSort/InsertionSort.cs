using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            int last = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    Swap(array, i, i + 1);
                }
                for (int j = i-1; j > last - 1; j--)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                        last = j;
                    }
                }
            }
            return array;
        }
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static void Print<T>(T[] array)
        {
            Console.Write('[');
            foreach (T i in array)
            {
                Console.Write(i + " ");
            }
            Console.Write(']');
        }
    }
}