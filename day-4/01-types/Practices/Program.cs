using System;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// Practice1 - Sum of numbers /////
            Console.Write("number one: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("number two: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("result: " + result);



            //////Practice2 - multiplication of two nums ////
            Console.Write("Input first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            double resultt = firstNum * secondNum;
            bool isGreater = false;
            if (resultt > 10)
            {
                isGreater = true;
            }
            Console.WriteLine("Result: " + resultt + "\nResult is greater than 10: " + isGreater);



            ////////Practice3 - Equals or not  //////
            Console.Write("Input first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            bool isEqual = false;
            if (firstNumber == secondNumber)
            {
                isEqual = true;
            }
            Console.WriteLine("Numbers are equal: " + isEqual);



            ////////// Practice 4 - double to int /////
            Console.Write("Input double number: ");
            int num = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Result: " + num);



            ///// Practice 5 -  string characters /////
            Console.Write("Input string: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Substring(0, 4));


            //// Practice 6 - leap year //////
            Console.Write("Input year number: ");
            double inputYear = Convert.ToDouble(Console.ReadLine());
            bool isLeap = false;

            if (inputYear % 4 == 0)
            {
                isLeap = true;
            }
            Console.WriteLine($"{inputYear} is leap year: " + isLeap);
        }
    }
}
