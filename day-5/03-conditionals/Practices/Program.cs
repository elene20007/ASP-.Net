using System;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {

            //////  Practice 1  /////
            /* Console.Write("Input number: ");
            string inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out int output))
            {
                int number = Convert.ToInt32(inputNum);
                if (number % 5 == 0)
                {
                    if (number % 10 == 0)
                    {
                        Console.WriteLine("Number is divisible by 5 and 10");
                    }
                    else
                    {
                        Console.WriteLine("Number is divisible by 5 only");
                    }
                }
                else
                {
                    Console.WriteLine("Number is not divisible by 5 or 10");
                }
            }
            else
            {
                Console.WriteLine("Incorrect format");
            } */

            //////////////////////////////////////////////////////////////////////////////////////////


            ////    Practice 2  ////
            /*
            Console.WriteLine("======= Menu ======\n" +
                        "1.The current month\n" +
                        "2.The current day of week\n" +
                        "3.The current year\n" +
                        "0.Exit\n" +
                        "===================\n" +
                        "Select Menu number: ");

            string inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out int output))
            {
                int number = Convert.ToInt32(inputNum);
                if(number == 0)
                {
                    Console.WriteLine("Exiting now...");
                }
                else
                {
                    Console.WriteLine("The current date: " + DateTime.Now);
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Month: " + DateTime.Now.ToString("mm"));
                            break;
                        case 2:
                            Console.WriteLine("Day of the week: " + DateTime.Now.ToString("dddd"));
                            break;
                        case 3:
                            Console.WriteLine("Year: " + DateTime.Now.ToString("yyyy"));
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect format");
            } */

            /////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////    Practice 3      //////
            /*
            Console.WriteLine("Input the number of month: ");
            string inputNum = Console.ReadLine();

            if (int.TryParse(inputNum, out int output))
            {
                int number = Convert.ToInt32(inputNum);
                if (number >= 1 & number <= 12)
                {
                    string month = "";
                    switch (number)
                    {
                        case 1:
                            month = "January";
                            break;
                        case 2:
                            month = "February";
                            break;
                        case 3:
                            month = "March";
                            break;
                        case 4:
                            month = "April";
                            break;
                        case 5:
                            month = "May";
                            break;
                        case 6:
                            month = "June";
                            break;
                        case 7:
                            month = "July";
                            break;
                        case 8:
                            month = "August";
                            break;
                        case 9:
                            month = "September";
                            break;
                        case 10:
                            month = "October";
                            break;
                        case 11:
                            month = "November";
                            break;
                        case 12:
                            month = "December";
                            break;
                    }
                    Console.WriteLine("Month: " + month);
                }
                else
                {
                    Console.WriteLine($"Month {number} is not exists");
                }
            }
            else
            {
                Console.WriteLine("Incorrect format");
            } 
            */

        }
    }
}
