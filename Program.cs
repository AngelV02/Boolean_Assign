using System;

namespace Boolean_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            Console.WriteLine("Boolean comparison using a while statement:");

            int i = 1; // Initialize the counter

            while (i <= 5) // Condition: While i is less than or equal to 5
            {
                Console.WriteLine("Current value of i: " + i);
                i++; // Increment the counter
            }

            Console.WriteLine();

            // Boolean comparison using a do-while statement
            Console.WriteLine("Boolean comparison using a do-while statement:");

            int j = 1; // Initialize the counter

            do
            {
                Console.WriteLine("Current value of j: " + j);
                j++; // Increment the counter
            }
            while (j <= 5); // Condition: While j is less than or equal to 5

            Console.WriteLine();
        }
    }
}
