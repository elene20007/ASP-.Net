using System;
using System.Drawing;

namespace Tutorials
{
    class Program
    {
        public enum Colors
        {
            red = 1,
            orange = 2,
            yellow = 3,
            green = 4,
            blue = 5,
            indigo = 6,
            violet = 7
        }
        static void Main(string[] args)
        {
            ////  Tutorial 1 - exercises ////
            /* Console.Write("Input the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Input the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the 3rd number: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            double maxNum = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
            string result = "Negative number didn't contain";
            if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
            {
                result = "Negative number contained";
            }
            
            Console.WriteLine("\nThe greatest number: " + maxNum + "\n" + result); */



            //// Tutorial 2 - colors ////
            /*
            Console.Write("Input color number: ");
            string inputColorNum = Console.ReadLine();
            if (Char.IsDigit(Convert.ToChar(inputColorNum)))
            {
                int ColorNum = Convert.ToInt32(inputColorNum);
                if (1 <= ColorNum & ColorNum <= 7)
                {
                    Console.WriteLine(Enum.GetName(typeof(Colors), ColorNum));
                }
                else
                {
                    Console.WriteLine("white");
                }
            }
            else
            {
                Console.WriteLine("Incorrect format");
            }  */


        }

    }
}
