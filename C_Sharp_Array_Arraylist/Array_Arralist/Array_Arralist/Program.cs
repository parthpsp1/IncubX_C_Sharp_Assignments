using System;
using System.Collections;

namespace Array_Arralist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array & Arraylist Assignment");

            Array_Properties array_Properties = new Array_Properties();

            Console.WriteLine("\n");
            Console.WriteLine("--// Array Properties //--");
            array_Properties.length();
            //array_Properties.getLength();
            array_Properties.sort_array();
            array_Properties.reverse_array();
            array_Properties.copy_array();

            Console.WriteLine("\n");
            Console.WriteLine("--// Arraylist Properties //--");

            ArrayList array_list = new ArrayList();
            array_list.Add(1);
            array_list.Add("Parth");
            array_list.Add(true);
            array_list.Add(3.22);

            Console.WriteLine("Initial Array list is:");
            Console.WriteLine("-- Add");
            
            foreach(var item in array_list)
            {
            Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("-- Remove");
            Console.WriteLine("Removing the value of 'True'");
            array_list.Remove(true);
            foreach (var item in array_list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            array_list.Insert(1,true);
            array_list.Insert(2, "Suyash");
            array_list.Insert(5, null);
            array_list.Insert(6, false);
            Console.WriteLine("-- Insert");
            Console.WriteLine("After Inserting some values");
            foreach (var item in array_list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("-- RemoveAt");
            array_list.RemoveAt(5);
            Console.WriteLine("After Removing at specified index some values");
            foreach (var item in array_list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("-- IndexOf");
            Console.WriteLine("Printing Index Of a specific value in Arraylist");
            Console.WriteLine(array_list.IndexOf("Parth"));

            Console.WriteLine("---------------");
            Console.WriteLine("-- TrimToSize");
            array_list.TrimToSize();
            foreach (var item in array_list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Array_Properties
    {
        string[] namesArray = { "Ajinkya", "Ajinkya", "Vaibhavi", "Nitin", "Vedant"};
        int[] numArray = { 1, 2, 4, 5, 1, 3, 2, 3, 5, 6, 7, 8, 4, 3, 5, 7, 9, 0 };

        //Method to print the length of the array
        public void length()
        {
            Console.WriteLine("Length of the names array is : {0}",namesArray.Length);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------");
        }

        //Method to getlength of the array
        //public void getLength()
        //{
        //    Console.WriteLine("geLength of array is:");
        //    Console.WriteLine(namesArray.GetLength(0));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("--------------------------");
        //}

        //Method to sort the array
        public void sort_array()
        {
            Array.Sort(numArray);
            Console.WriteLine("Sorted array is:");
            for(int i =0; i < numArray.Length; i++)
            {
            Console.Write("{0} ", numArray[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------");
        }

        //Method to print reverse of the array
        public void reverse_array()
        {
            Array.Reverse(numArray);
            Console.WriteLine("Reversed array is:");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write("{0} ", numArray[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------");
        }

        //Method to copy original elements from original array and put them in duplicate array
        public void copy_array()
        {
            int[] duplicateArray = new int[10];
            Array.Copy(numArray,duplicateArray, 5);
            Console.WriteLine("Copied Array is:");
            for (int i = 0; i < duplicateArray.Length; i++)
            {
            Console.Write("{0} ",duplicateArray[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------");
        }
    }
}
