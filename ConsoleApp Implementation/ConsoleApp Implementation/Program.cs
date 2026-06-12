using System;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- PART 1: WHILE LOOP ---

            // Initialize a counter variable
            int count = 1;

            // The while loop checks the boolean condition (count <= 3) BEFORE executing
            Console.WriteLine("Starting the While Loop:");
            while (count <= 3)
            {
                // Print the current value of count to the console
                Console.WriteLine("While count is: " + count);

                // Increment count by 1 so the loop eventually ends
                count++;
            }

            // Separator for clarity in console output
            Console.WriteLine("----------------------------");

            // --- PART 2: DO WHILE LOOP ---

            // Initialize a new variable for the do while loop
            int number = 1;

            // The do while loop executes the code block FIRST, then checks the condition
            Console.WriteLine("Starting the Do While Loop:");
            do
            {
                // Print the current value of number to the console
                Console.WriteLine("Do While number is: " + number);

                // Increment number by 1
                number++;

                // The boolean comparison happens here; loop repeats if number is less than 4
            } while (number < 4);

            // Keeps the console window open until a key is pressed
            Console.WriteLine("\nAssignment complete. Press any key to exit...");
            Console.ReadKey();
        }
    }
}