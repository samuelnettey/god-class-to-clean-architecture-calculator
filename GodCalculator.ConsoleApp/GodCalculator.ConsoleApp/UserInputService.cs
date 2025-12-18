// See https://aka.ms/new-console-template for more information
using GodCalculator.ConsoleApp;

public class UserInputService
{
    public string ReadCommand()
    {
        Console.WriteLine("Enter Command: add, sub, mul div");
        return Console.ReadLine()!;
    }
    public CalculatorArguments ReadArguments() 
    {   
        Console.WriteLine("Enter your first value: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter your second value: ");
        int b = int.Parse(Console.ReadLine()!);
        return new CalculatorArguments { A = a, B = b };
    }
}