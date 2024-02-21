using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the current day of the week
        Console.WriteLine("Please enter the current day of the week:");
        string input = Console.ReadLine();

        try
        {
            // Try to parse the user input into the DaysOfWeek enum
            DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true);

            // If parsing is successful, print the day
            Console.WriteLine($"The day you entered is: {day}");
        }
        catch (ArgumentException)
        {
            // If parsing fails, catch the exception and prompt the user to enter a valid day
            Console.WriteLine("Please enter an actual day of the week.");
        }

        // Wait for the user to acknowledge the result
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
