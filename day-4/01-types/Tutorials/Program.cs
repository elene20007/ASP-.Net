using System;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //////Tutorial1///////////
       
            Console.Write("Input first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double result = firstNumber + secondNumber;
            bool isEven = false;

            if (result%2 == 0)
            {
                isEven = true;
            }

            Console.WriteLine("Result: " + Convert.ToString(result) + "\n" + "Result is even number: " + Convert.ToString(isEven));
            

            //////Tutorial2//////////

            DateTime date = DateTime.Now;
            string current = date.ToString("dddd, dd MMMM yyyy");
            string result = current.Remove(8,12);
            Console.WriteLine("Current date: " + current + "\n" + "Result: " + result);
        }
    }
}
