using System;

class Program
{
    static void Main()
    {
        int sumEven = 0;
        int sumOdd = 0;

        // Looping through the first 10 numbers starting from 0
        for (int number = 0; number <= 9; number++)
        {
            // Checking if the number is divisible by 2 to determine if it's even
            if (number % 2 == 0)
            {
                sumEven += number;
                Console.WriteLine($"{number} is an even number");
            }
            else // If it's not divisible by 2, then it must be odd
            {
                sumOdd += number;
                Console.WriteLine($"{number} is an odd number");
            }
        }

        // Display the sum of even and odd numbers after finishing the loop
        Console.WriteLine($"Total of even numbers : {sumEven}");
        Console.WriteLine($"Total of odd numbers : {sumOdd}");

        Console.ReadKey();
    }
}
