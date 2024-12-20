using System;

namespace ArrayListSorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            // How many values will the array need
            Console.WriteLine("How many values will be in your array?");
            int numberValues;

            // Input validation 
            while (!int.TryParse(Console.ReadLine(), out numberValues) || numberValues <= 0)
            {
                Console.WriteLine("Enter a valid positive number:");
            }

            // Declare the array
            int[] values = new int[numberValues];

            // Populate the array
            for (int i = 0; i < numberValues; i++)
            {
                Console.WriteLine($"Enter value {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out values[i])) // Validate the input
                {
                    Console.WriteLine("Enter a valid integer value:");
                }
            }

            // Statistics
            int sum = 0;
            int largest = values[0];
            int smallest = values[0];

            for (int i = 0; i < numberValues; i++)
            {
                sum += values[i];

                if (values[i] > largest)
                    largest = values[i];

                if (values[i] < smallest)
                    smallest = values[i];
            }

            double average = (double)sum / numberValues;

            // Display options
            bool exit = false;
            while (!exit) //Program will exoit only when the user chooses the option
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Sum of the array");
                Console.WriteLine("2. Largest value in the array");
                Console.WriteLine("3. Smallest value in the array");
                Console.WriteLine("4. Average of the array");
                Console.WriteLine("5. Exit");

                int option;
                // In order to 
                while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option > 5)
                {
                    Console.WriteLine("Invalid option. Enter a number between 1 and 4:");
                }

                // Process and display the chosen option
                switch (option)
                {
                    case 1:
                        Console.WriteLine($"The sum of your array is {sum}");
                        break;
                    case 2:
                        Console.WriteLine($"The largest value is {largest}");
                        break;
                    case 3:
                        Console.WriteLine($"The smallest value is {smallest}");
                        break;
                    case 4:
                        Console.WriteLine($"The mean of your array is {average:F2}");// F2  give sthe answer in second decimal form
                        break;
                    case 5:
                        Console.WriteLine("Bye...!!!");
                        exit = true;
                        break;
                }
            }
        }
    }
}
