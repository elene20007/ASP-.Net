using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What is you name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadKey();*/


            /*string message = "The value is ";
            Int32 val = 30;
            Console.Write(message + val);
            Console.ReadKey();*/


            /*Int32 first = 10, second = 20;
            bool status = true;
            Console.WriteLine(first + second);
            Console.WriteLine(first < second);
            Console.WriteLine(!(status));
            Console.ReadKey();*/


            /*
            ////////////////////////////////////////////
            int val = (int)1.5; //cast1.
            float floatValue = val;
            Console.WriteLine(val);

            object val = new StringBuilder();

            if (val is StringBuilder) // Cast 2.
            {
                StringBuilder builder = val as StringBuilder; // Cast 3.
                Console.WriteLine(builder.Length == 0);
            } ///////////////////////////////////////////////
            */


            /*for (char c = 'a'; c <= 'e'; c++)
            {
                // Cast the char to an int.
                int code = c;
                // Cast the int to a char.
                // ... An int is larger than a char.
                // ... So an explicit cast is needed.
                char original = (char)c;
                Console.WriteLine(c + "..." + code + "..." + original);
            }*/


            /*// Assign an int and then cast it to an object implicitly.
            int value1 = 400;
            object value2 = value1;
            // Explicitly cast to an integer again.
            int value3 = (int)value2;
            Console.WriteLine(value3);
            // Try to cast it to a string.
            try
            {
                string value4 = (string)value2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }*/


            /*int i = 12;
            double d = 765.12;
            float f = 56.123F;
            // Using Built- In Type Conversion
            // Methods & Displaying Result
            Console.WriteLine(Convert.ToString(f));
            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(Convert.ToUInt32(f));
            Console.WriteLine(Convert.ToDouble(i));
            Console.WriteLine("GeeksforGeeks");*/

        }
    }
}