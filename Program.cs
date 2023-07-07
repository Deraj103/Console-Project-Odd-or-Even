using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Odd_or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int total;
            int remainder = 0;
            bool even;
            int evenTotal = 0;
            int oddTotal = 0;
            string reply;

            WriteLine("Ch5 Console Project Odd or Even by Jared Tims\n");

            do //exit loop with y/n
            {
                total = PositiveInteger();
                if (total == 0)
                    reply = "y"; //"break;" will also break out of the loop
                else
                {



                    WriteLine($"The total of those numbers is {total}");

                    even = OddOrEven(total);

                    if (even == true)
                        WriteLine("That number is even.");
                    else
                        WriteLine("That number is odd.");

                    Write("Do you want to continue? (y/n)");
                    reply = ReadLine();
                }
            } while (reply == "y");

            WriteLine($"Number of even totals: {evenTotal}");
            WriteLine($"Number of odd totals: {oddTotal}");

            Write("\nPress any key to continue...");
            ReadKey();
        }

        //Include a method to get the positive integers in a loop, until the user enters 0,
        //and return the sum of those numbers. Validate that each number is a positive integer (greater than zero).
        static int PositiveInteger()
        {
            int num;
            int total = 0;

            do
            {
                Write("Please enter a positive number (0 to end): ");
                num = Convert.ToInt32(ReadLine());
                if (num > 0)
                {
                    total += num;
                }
            } while (num != 0);

            return total;
        }

        //Write another method to determine if a number passed into it is even or odd and return a Boolean
        //that is true when the number is even, false when it is odd.
        static bool OddOrEven(int total)
        {
            int remainder = 0;
            bool even = false;

            remainder = total % 2;

            if (remainder == 0)
                even = true;

            return even;
        }

    }
}