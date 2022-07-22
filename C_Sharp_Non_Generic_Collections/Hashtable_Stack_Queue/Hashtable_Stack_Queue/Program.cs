using System;
using System.Collections;

namespace Hashtable_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("////////////////////////////HASHTABLE////////////////////////////");

            Console.WriteLine("Creating a Hashtable & adding values to it");
            Hashtable hashtable = new();
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(-1 / 2, "-1");
            hashtable.Add(3, "-2");
            hashtable.Add(-3, "-2");
            hashtable.Add("Name", "-2");

        //    var cities = new Hashtable(){
        //    {"UK", "London, Manchester, Birmingham"},
        //    {"USA", "Chicago, New York, Washington"},
        //    {"India", "Mumbai, New Delhi, Pune"}
        //};
        //    foreach (DictionaryEntry city in cities)
        //    {
        //        Console.WriteLine("Key: '{0}' , Value: '{1}' ", city.Key, city.Value);
        //    }

            foreach (DictionaryEntry hash in hashtable)
            {
                Console.WriteLine("Key: '{0}' , Value: '{1}' " /*, HashCode {2}*/, hash.Key,hash.Value /*,hash.GetHashCode()*/);
                //Tried to get the actual hashcode here using the GetHashCode() method but could not get it
            }

            Console.WriteLine("--------------");
            //ContainValue method provides us True or False output based on if the given value is in the hashtable or not.
            Console.WriteLine("If Contains Specific Value: " + hashtable.ContainsValue("99999"));

            Console.WriteLine("--------------");
            //Clear method clears everything from the hashtable
            hashtable.Clear();
            Console.WriteLine("After clearing the hashtable: ");

            foreach (DictionaryEntry hash in hashtable)
            {
                Console.WriteLine("Key: '{0}' , Value: '{1}' ", hash.Key, hash.Value);
            }

            Console.WriteLine("--------------");
            //Adding values to the hastable using Indexer
            Console.WriteLine("Adding values to hashtable using Indedxer");
            hashtable[1] = "One";
            hashtable[5] = "Five";
            hashtable[30] = "Thirty";

            foreach (DictionaryEntry hash in hashtable)
            {
                Console.WriteLine("Key: '{0}' , Value: '{1}' ", hash.Key, hash.Value);
            }

            Console.WriteLine("--------------");
            Console.WriteLine("After Updating hashtable with Indexer");
            //Updating value of exisitng key using indexer
            hashtable[1] = "Ek";

            foreach (DictionaryEntry hash in hashtable)
            {
                Console.WriteLine("Key: '{0}' , Value: '{1}' ", hash.Key, hash.Value);
            }

            Console.WriteLine("////////////////////////////QUEUE////////////////////////////");

            //Creating a queue and adding values to it using Enqueue
            Console.WriteLine("Creating a Queue & adding values to it");
            Queue queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (var q in queue)
            {
                Console.WriteLine(" {0} ",q);
            }

            Console.WriteLine("--------------");

            //Using Peek method to peek into the queue
            Console.WriteLine("Peeking into queue, the current element is: {0}",queue.Peek());

            Console.WriteLine("--------------");
            Console.WriteLine("Checking if specific item is in the queue:");
            Console.WriteLine("{0}",queue.Contains(3));

            Console.WriteLine("--------------");
            Console.WriteLine("Deleting items from a Queue");
            //Using dequeue to delete the first or first few elements from the queue since queue works on FIFO, requires no parameter.
            queue.Dequeue();
            queue.Dequeue();

            foreach (var q in queue)
            {
                Console.WriteLine(" {0} ", q);
            }

            Console.WriteLine("--------------");
            Console.WriteLine("After cleaing the queue:");
            queue.Clear();

            foreach (var q in queue)
            {
                Console.WriteLine(" {0} ", q);
            }

            Console.WriteLine("////////////////////////////STACK////////////////////////////");
            //Creating a stack and adding elements to it using Push method
            Console.WriteLine("Creating a Stack & adding values to it");
            Stack stack = new();
            stack.Push("Parth");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push("Lemon");
            stack.Push("India");


            foreach (var s in stack)
            {
                Console.WriteLine(" {0} ", s);
            }

            Console.WriteLine("--------------");
            //Popping the last element of the stack, since LIFO
            Console.WriteLine("Popping last values from it");
            stack.Pop();

            foreach (var s in stack)
            {
                Console.WriteLine(" {0} ", s);
            }

            Console.WriteLine("--------------");
            //Popping the last element of the stack, since LIFO
            Console.WriteLine("Peeking the latest values from it");
            stack.Peek();

            foreach (var s in stack)
            {
                Console.WriteLine(" {0} ", s);
            }

            Console.WriteLine("--------------");
            //Checking if the Stack has specific values
            Console.WriteLine("Checking if the Stack has specific values");
            Console.WriteLine(stack.Contains("Parth"));

            Console.WriteLine("--------------");
            //Cloning the stack
            Console.WriteLine("Cloning the stack to another stack");
            Stack stack2 = (Stack)stack.Clone();

            foreach (var s2 in stack2)
            {
                Console.WriteLine(" {0} ", s2);
            }
        }
    }
}
