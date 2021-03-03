using System;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Declaration examples of arays ///
            /*
             int[] array1 = new int[5];
             int[] array2 = new int[] { 1, 3, 5, 7, 9 };
             int[] array3 = { 1, 3, 5, 7, 9 };
             int[,] multiDimentionalArray1 = new int[2,3];
             int[,] multiDimentionalArray2 = { { 1, 2, 3 } , { 4, 5, 6 } };
             int[][] jaggedArray = new int[6][];
             jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

            /// while loop ///
            
            int n = 0;
            while (n < 5)
            {   
                Console.WriteLine(n);
                n++;
            }

            /// do while loop ///
            
            int n = 0;
            do
            {   
                Console.WriteLine(n);
                n++;
            }   while (n < 5);
            
            /// for loop ///
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            /// foreach loop ///
            
            var fibNums = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach  (int element in fibNums)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}");
             */

            /// Tutorial 1 ///
            /*
            Console.WriteLine("Input first number: ");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Input second number: ");
            string secondInput = Console.ReadLine();

            if (int.TryParse(firstInput, out int output) & int.TryParse(secondInput, out int ouput))
            {
                int firstNumber = Convert.ToInt32(firstInput);
                int secondNumber = Convert.ToInt32(secondInput);
                if (firstNumber >= secondNumber)
                {
                    Console.WriteLine("Range can not be calculated");
                }
                else
                {
                    for (int i = firstNumber + 1; i < secondNumber; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect format");
            }
            */

            /// Tutorial 2 ///
            /*
            for (int i = 0; i < 5; i ++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i == j)
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
            */
        }
    }
}
