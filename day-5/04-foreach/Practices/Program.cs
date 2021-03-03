using System;
using System.Collections.Generic;
using System.Linq;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Practice 1 ///
            
            int count = 0;
            int inputNumber = 1;
            while (inputNumber != 0) 
            {
                Console.Write("Input number: ");
                string inputNum = Console.ReadLine();

                if (int.TryParse(inputNum, out int output))
                {
                    inputNumber = Convert.ToInt32(inputNum);
                    count++;
                }
            } 
            Console.WriteLine($"Count of entered numbers before zero: {count-1}");
            

            /// Practice 2 ///
            
            Console.Write("Input length of array: ");
            string arrayLength = Console.ReadLine();

            if (int.TryParse(arrayLength, out int arrayNum))
            {
                List<int> array1 = new List<int>();

                while (array1.Count != arrayNum)
                {
                    Console.Write($"Input number {array1.Count + 1}: ");
                    string inputAr = Console.ReadLine();

                    if (int.TryParse(inputAr, out int inputNum))
                    {
                        array1.Add(inputNum);
                    }
                }
                string outputArray = "";
                for (int i = 0; i < array1.Count; i++)
                {
                    outputArray += Convert.ToString(array1[i]) + " ";

                }
                Console.WriteLine($"Array: {outputArray}\nThe biggest in array: {array1.Max()}");
            }
            else
            {
                Console.WriteLine("Incorrect format");
            }
            

            /// Practice 3 ///
            
            string yesOrNo = "y";
            List<string> history = new List<string>();
            do
            {
                Console.WriteLine("==============================");
                
                Console.Write("Input number X: ");
                string inputX = Console.ReadLine();
                if (int.TryParse(inputX, out int X))
                {
                    
                }
                else
                {
                    Console.WriteLine($"Inaccessible operation: {inputX} is not a number\n");
                    continue;
                }
                Console.Write("Input number Y: ");
                string inputY = Console.ReadLine();
                if (int.TryParse(inputY, out int Y))
                {
                    if (Y == 0)
                    {
                        Console.WriteLine("Inaccessible operation: You cannot divide by zero.\n");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Inaccessible operation: {inputY} is not a number\n");
                    continue;
                }
                Console.WriteLine("\nChoose a mathematical operation from the following list:\n" +
                                    "1 - Add\n" +
                                    "2 - Subtract\n" +
                                    "3 - Multiply\n" +
                                    "4 - Divide\n");
                Console.Write("Option: ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    string result = $"{X} + {Y} = {X+Y}";
                    Console.WriteLine($"Result: {result}");
                    history.Add(result);
                }
                else if (option == "2")
                {
                    string result = $"{X} - {Y} = {X - Y}";
                    Console.WriteLine($"Result: {result}");
                    history.Add(result);
                }
                else if (option == "3")
                {
                    string result = $"{X} * {Y} = {X * Y}";
                    Console.WriteLine($"Result: {result}");
                    history.Add(result);
                }
                else if (option == "4")
                {
                    string result = $"{X} / {Y} = {X / Y}";
                    Console.WriteLine($"Result: {result}");
                    history.Add(result);
                }
                else
                {
                    Console.WriteLine("Try another option ..");
                    continue;
                }

                Console.WriteLine("==============================");

                Console.Write("\nContinue (y/n): ");
                yesOrNo = Console.ReadLine();

            } while (yesOrNo == "y");
            

            /// Practice 4 /// 
            
            for (int i = 5; i > 0; i-=1)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i-1 == j)
                    {
                        Console.Write("1   ");
                    }
                    else
                    {
                        Console.Write("0   ");
                    }
                }
                Console.WriteLine("\n");
            }
            
        }
    }
}
