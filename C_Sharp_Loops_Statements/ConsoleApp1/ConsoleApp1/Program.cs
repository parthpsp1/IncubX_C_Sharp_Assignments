using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Assignment - 1 'Selection / Iteration / Jump' Statements \n");
            Console.WriteLine("----------------------- \n");

            //Simple If Statement \n
            Console.WriteLine("If, else  and else if Statements \n");
            Random generateRandomNumber = new();
            int randomNumber = generateRandomNumber.Next(10);
            if (randomNumber == 5)
            {
                Console.WriteLine("Random Number = 5");
            }
            else if (randomNumber == 10)
            {
                Console.WriteLine("Random Number = 10");
            }
            else
            {
                Console.WriteLine("Random Number not equal to 5 or 10 but instead = {0}", randomNumber);
            }

            Console.WriteLine("----------------------- \n");
            //Simple Switch Case Statement \n
            Console.WriteLine("Switch Case Statement \n");

            Console.WriteLine("Enter First Number");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Second Number");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Choose One of the Options");
            Console.WriteLine("1 : Addition");
            Console.WriteLine("2 : Subtraction");
            Console.WriteLine("3 : Division");
            Console.WriteLine("4 : Multiplication");
            
            int option = int.Parse(Console.ReadLine());
            float result = 0;
                
            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 / num2;
                    break;
                case 4:
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

            Console.WriteLine("Result = {0}",result);

            Console.WriteLine("----------------------- \n");
            //Simple While Statement \n
            Console.WriteLine("While Statement \n");
            int x = 4;
            while(x > 1){
                x--;
                Console.WriteLine(x);
            }
            Console.WriteLine("BOOM!");

            Console.WriteLine("----------------------- \n");
            //Simple Do While Statement \n
            Console.WriteLine("Do While Statement \n");
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("I have been incremented to : {0} using Do While Loop \n", i);
            }
            while (i < 5);

            Console.WriteLine("----------------------- \n");
            //Simple For Statement \n
            Console.WriteLine("For Statement \n");
            for(int loop = 1; loop <= 5; loop++)
            {
                Console.WriteLine("I am printing for the {0} time", loop);
            }

            Console.WriteLine("----------------------- \n");
            //Simple Foreach Statement \n
            Console.WriteLine("Foreach Statement \n");
            string[] friends = { "Ajinkya", "Nitin", "Vaibhavi", "Vedant", "Shardul", "Aditya", "Nikita", "Trupti", "Raj", "Rohit"};
            foreach(string friend_loop in friends)
            {
                Console.WriteLine("Name of my friends: {0}", friend_loop);
            }
        }
    }
}
