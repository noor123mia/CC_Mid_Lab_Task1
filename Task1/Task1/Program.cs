using System;

class Program
{
    static void Main()
    {
        // Ask for Student ID
        Console.Write("Enter your Student ID (e.g., BCS-000): ");
        string studentId = Console.ReadLine();

        // Extract only digits from student ID
        string digitsOnly = "";
        foreach (char ch in studentId)
        {
            if (char.IsDigit(ch))
                digitsOnly += ch;
        }

        // Check if we have at least two digits
        if (digitsOnly.Length < 2)
        {
            Console.WriteLine("Invalid ID. Must contain at least two digits.");
            return;
        }

        // Get last two digits
        char secondLastDigitChar = digitsOnly[digitsOnly.Length - 2];
        char lastDigitChar = digitsOnly[digitsOnly.Length - 1];

        int x = int.Parse(secondLastDigitChar.ToString());
        int y = int.Parse(lastDigitChar.ToString());

        // Ask user for value of z
        Console.Write("Enter value for z: ");
        int z = int.Parse(Console.ReadLine());


        // Calculate result
        int result = x * y + z;

        // Output
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"z = {z}");
        Console.WriteLine($"\nResult = x * y + z = {x} * {y} + {z} = {result}");
    }
}
