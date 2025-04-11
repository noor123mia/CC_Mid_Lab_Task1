using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ask for Student ID and extract last two digits
        Console.Write("Enter your Student ID (e.g., BCS-002): ");
        string studentId = Console.ReadLine();

        // Extract numeric part from ID and last two digits
        string digitsOnly = "";
        foreach (char ch in studentId)
        {
            if (char.IsDigit(ch))
                digitsOnly += ch;
        }

        string suffix = digitsOnly.Length >= 2
                        ? digitsOnly.Substring(digitsOnly.Length - 2)
                        : digitsOnly.PadLeft(2, '0'); // ensure two digits

        string customInput = "x:userinput; y:userinput; z:4; result: x * y + z;";

        // Dictionary to store variable names and their values
        Dictionary<string, int> variableValues = new Dictionary<string, int>();

        string resultExpression = "";
        string[] segments = customInput.Split(';');

        foreach (string segment in segments)
        {
            if (string.IsNullOrWhiteSpace(segment))
                continue;

            string[] keyValue = segment.Split(':');
            string variableName = keyValue[0].Trim();
            string variableValue = keyValue[1].Trim();

            if (variableValue.ToLower() == "userinput")
            {
                Console.Write($"Enter value for {variableName}: ");
                int userInput = int.Parse(Console.ReadLine());
                variableValues[variableName] = userInput;
            }
            else if (variableName.ToLower() == "result")
            {
                resultExpression = variableValue;
            }
            else
            {
                int fixedValue = int.Parse(variableValue);
                variableValues[variableName] = fixedValue;
            }
        }

        // Create a new variable name using the student ID suffix (e.g., x02)
        int xWithId = variableValues["x"];
        int y = variableValues["y"];
        int z = variableValues["z"];

        int result = xWithId * y + z;

        Console.WriteLine($"\nUsing variable: x{suffix} (mapped from x)");
        Console.WriteLine($"z = {z}");
        Console.WriteLine($"Result = {result}");
    }
}
