using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get number input from the user
            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();

            // Validate input: check if it is a valid integer
            if (int.TryParse(input, out int number))
            {
                // Check if the number is greater than 0
                if (number > 0)
                {
                    // Initialize countdown variable
                    int countdown = number;

                    // Countdown using a while loop
                    while (countdown >= 0)
                    {
                        Console.WriteLine(countdown);
                        countdown--; // Decrement countdown variable
                    }
                }
                else
                {
                    Console.WriteLine("Error: Number must be greater than 0.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
        }
    }
}




