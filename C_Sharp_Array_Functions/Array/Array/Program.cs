using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2007, 95, 96, 2010, 2000, 2003 };
            ArrayFunctions arrayFunctions = new();
            Console.WriteLine("Sorted Array:");
            Console.WriteLine("---------------");
            arrayFunctions.SortArray(array);
            Console.WriteLine("\n\n");
            Console.WriteLine("Reverse Sorted Array:");
            Console.WriteLine("---------------");
            arrayFunctions.ReverseSortArray(array);
        }
    }

    class ArrayFunctions
    {
        public void SortArray(Array array)
        {
            Array.Sort(array);
            
            foreach(int array_loop in array)
            {
            Console.WriteLine(array_loop);
            }
        }

        public void ReverseSortArray(Array array)
        {
            Array.Reverse(array);
            foreach (int array_loop in array)
            {
                Console.WriteLine(array_loop);
            }
        }
    }
}
