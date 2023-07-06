using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Odd_or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, total, remainder, even, odd;
            num = 0;
            total = 0;
            remainder = 0;
            even = 0;
            odd = 0;
            string reply;

            WriteLine("Ch5 Console Project Odd or Even by Jared Tims\n");

            Write("Please enter a positive number (0 to end): ");
            num = Convert.ToInt32(ReadLine());

                do
                {
                    if (num == 0)
                    {
                        WriteLine($"Number of even totals: {even}");
                        WriteLine($"Number of odd totals: {odd}");

                        Write("\nPress any key to continue...");
                        ReadKey();
                    }
                    else
                    {
                        do
                        {
                            //Write("Please enter a positive number (0 to end): ");
                            //num = Convert.ToInt32(ReadLine());
                            total += num;
                            remainder = num % 2;

                            if (num != 0)
                            {
                                if (remainder != 0)
                                {

                                    odd++;
                                }
                                else
                                {

                                    even++;
                                }
                            }
                        } while (num != 0);


                        WriteLine($"The total of those numbers is {total}");

                        if (remainder == 0)
                        {
                            WriteLine($"That number is odd.");
                        }
                        else
                        {
                            WriteLine("That number is even.");
                        }

                        Write("Do you want to continue? (y/n)");
                        reply = ReadLine();
                    } while (reply == "y") ;


                WriteLine($"Number of even totals: {even}");
                WriteLine($"Number of odd totals: {odd}");

                Write("\nPress any key to continue...");
                ReadKey();
        }
    }
}