using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result = 0; // We define our variables
        char op; // This variable will hold the operator for the operation to be performed

        Console.WriteLine("Calculator"); // We print the title

        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine()); // We get the first number from the user

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine()); // We get the second number from the user

        Console.Write("Select the operation to perform (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine()); // We get the operation chosen by the user

        switch (op)
        { // We perform the operation using a switch-case structure
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operation!"); // If an invalid operation is chosen, we print an error message
                break;
        }

        Console.WriteLine("Result: " + result); // We print the result of the operation

        Console.ReadLine(); // We wait for a key press to close the console window
    }
}
