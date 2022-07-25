using System;
using System.Collections.Generic;

namespace Generic_Collections
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("////////////////////List////////////////////");
            Console.WriteLine("---------------");
            Console.WriteLine("Creating a non generic list and addding elements to it");
            List<string> list = new();
            list.Add("Bread");
            list.Add("Butter");
            list.Add("Cream");
            list.Add("Milk");
            list.Add("Oranges");
            list.Add("Bananas");

            //Or we can create list as follows, here we will create an object of the List using Collection Iniializer
            //List<string> list = new();
            //{
            //    "Bread",
            //    "Butter",
            //    "Cream"
            //};

            foreach(var list_item in list)
            {
                Console.WriteLine(list_item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Inserting elements in the list");
            list.Insert(5, "Jell-o");
            foreach (var list_item in list)
            {
                Console.WriteLine(list_item);
            }


            Console.WriteLine("---------------");
            Console.WriteLine("Inserting elements of a collection into another collection at specified index");
            List<string> additional_list = new()
            {
                "Lichi",
                "Rice"
            };

            list.InsertRange(1, additional_list);
            foreach (var list_item in list)
            {
                Console.WriteLine(list_item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if a value exists in a collection:");
            Console.WriteLine(list.Contains("Lichi"));

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if a value exists in a collection based on a condition:");
            Console.WriteLine(list.Exists(condition => condition.StartsWith("R")));

            Console.WriteLine("////////////////////Stack////////////////////");
            Console.WriteLine("---------------");
            Console.WriteLine("Creating a non generic stack and addding object to it");
            Stack<string> stack = new();

            stack.Push("Record 1");
            stack.Push("Record 2");
            stack.Push("Record 3");
            stack.Push("Record 4");
            stack.Push("Record 5");

            foreach(string stack_list in stack)
            {
                Console.WriteLine(stack_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Popping the last object added:");
            Console.WriteLine(stack.Pop());

            Console.WriteLine("---------------");
            Console.WriteLine("Peeking the last element");
            Console.WriteLine(stack.Peek());

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if a particular record exists in the stack");
            Console.WriteLine(stack.Contains("Record 2"));

            Console.WriteLine("---------------");
            Console.WriteLine("Using CopyTo to copy an array in stack");
            string[] copy_stack = new string[10];
            stack.CopyTo(copy_stack,0);

            foreach (string copystack_list in copy_stack)
            {
                Console.WriteLine(copystack_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Clearing the stack");
            stack.Clear();

            foreach (string stack_list in stack)
            {
                Console.WriteLine(stack_list);
            }
            Console.WriteLine("---------------");

            Console.WriteLine("////////////////////Queue////////////////////");
            Console.WriteLine("---------------");
            Console.WriteLine("Creating a non generic queue and addding object to it");
            Queue<string> queue = new();

            queue.Enqueue("Token 1");
            queue.Enqueue("Token 2");
            queue.Enqueue("Token 3");
            queue.Enqueue("Token 4");
            queue.Enqueue("Token 5");

            foreach (string queue_list in queue)
            {
                Console.WriteLine(queue_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Removing objects from queue");
            queue.Dequeue();
            foreach (string queue_list in queue)
            {
                Console.WriteLine(queue_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Peeking the current object from queue");
            Console.WriteLine(queue.Peek()); 

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if a particular object is in the queue");
            Console.WriteLine(queue.Contains("Token 4"));

            Console.WriteLine("---------------");
            Console.WriteLine("Copying one dimensional array into the queue");
            string[] copy_queue = new string[50];
            queue.CopyTo(copy_queue,0);
            foreach (string queue_list in queue)
            {
                Console.WriteLine(queue_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Clearing the queue");
            queue.Clear();

            Console.WriteLine("////////////////////Queue////////////////////");
            Console.WriteLine("---------------");
            Console.WriteLine("Creating a non generic queue and addding object to it");
            HashSet<int> hashset = new();

            hashset.Add(1231);
            hashset.Add(1232);
            hashset.Add(1233);
            hashset.Add(1234);
            hashset.Add(1235);
            hashset.Add(1235123);
            hashset.Add(1235124);
            hashset.Add(1235125);

            foreach (int hashset_list in hashset)
            {
                Console.WriteLine(hashset_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Removing a single element");
            hashset.Remove(1232);

            foreach (int hashset_list in hashset)
            {
                Console.WriteLine(hashset_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Removing a elements throught a condition using RemoveWhere element");
            hashset.RemoveWhere(x => x == 1235124);
            foreach (int hashset_list in hashset)
            {
                Console.WriteLine(hashset_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if a certain element is present in hashset or not:");
            Console.WriteLine(hashset.Contains(1235124));

            Console.WriteLine("---------------");
            Console.WriteLine("Cound of elements in the hashset");
            Console.WriteLine(hashset.Count);

            Console.WriteLine("---------------");
            Console.WriteLine("Removing all elements from the hashset");
            hashset.Clear();
            foreach (int hashset_list in hashset)
            {
                Console.WriteLine(hashset_list);
            }

            Console.WriteLine("////////////////////Dictionary////////////////////");
            Console.WriteLine("---------------");
            Console.WriteLine("Creating a non generic dictionary and addding object to it");
            Dictionary<int, string> dictionary = new();
            dictionary.Add(1, "A");
            dictionary.Add(2, "B");
            dictionary.Add(3, "C");
            dictionary.Add(4, "D");
            dictionary.Add(5, "E");
            dictionary.Add(6, "F");
            dictionary.Add(7, "G");

            foreach(KeyValuePair<int, string> dictionary_list in dictionary)
            {
                Console.WriteLine(dictionary_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if a certain key exists");
            Console.WriteLine(dictionary.ContainsKey(1));

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if a certain value exists");
            Console.WriteLine(dictionary.ContainsValue("F"));

            Console.WriteLine("---------------");
            Console.WriteLine("Adding value to dictionary using Indexer");
            dictionary[8] = "H";

            foreach (KeyValuePair<int, string> dictionary_list in dictionary)
            {
                Console.WriteLine(dictionary_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Updating value in dictionary using Indexer");
            dictionary[8] = "Z";

            foreach (KeyValuePair<int, string> dictionary_list in dictionary)
            {
                Console.WriteLine(dictionary_list);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Removing value at first index");
            dictionary.Remove(1);

            Console.WriteLine("---------------");
            Console.WriteLine("Clearing al");
            dictionary.Clear();


            Console.WriteLine("////////////////////SortedList////////////////////");
            Console.WriteLine("---------------");
            Console.WriteLine("Creating a non generic sortedList and addding key value pairs  to it");
            SortedList<int,string> sorted_list = new();
            sorted_list.Add(1, "List Item 1");
            sorted_list.Add(3, "List Item 3");
            sorted_list.Add(2, "List Item 2");
            sorted_list.Add(5, "List Item 5");
            sorted_list.Add(4, "List Item 4");

            foreach (KeyValuePair<int,string> sorted_list_iterator in sorted_list)
            {
                Console.WriteLine(sorted_list_iterator);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Removing key value pair via key");
            sorted_list.Remove(1);
            foreach (KeyValuePair<int, string> sorted_list_iterator in sorted_list)
            {
                Console.WriteLine(sorted_list_iterator);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Removing key value pair via index");
            sorted_list.RemoveAt(1);
            foreach (KeyValuePair<int, string> sorted_list_iterator in sorted_list)
            {
                Console.WriteLine(sorted_list_iterator);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if certain key exists in the sortedList");
            Console.WriteLine(sorted_list.ContainsKey(1));

            Console.WriteLine("---------------");
            Console.WriteLine("Checking if certain value exists in the sortedList");
            Console.WriteLine(sorted_list.ContainsValue("List Item 4"));

            Console.WriteLine("---------------");
            Console.WriteLine("Count of all the key value pairs in the sorted list");
            Console.WriteLine(sorted_list.Count);

            Console.WriteLine("---------------");
            Console.WriteLine("Capacity of  the sorted list");
            Console.WriteLine(sorted_list.Capacity);

            Console.WriteLine("---------------");
            Console.WriteLine("Keys in the sortedList");
            foreach (var sorted_list_iterator in sorted_list.Keys)
            {
                Console.WriteLine(sorted_list_iterator);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Values in the sortedList");
            foreach (var sorted_list_iterator in sorted_list.Values)
            {
                Console.WriteLine(sorted_list_iterator);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Clearing sortedlist");
            sorted_list.Clear();
        }
    }
}