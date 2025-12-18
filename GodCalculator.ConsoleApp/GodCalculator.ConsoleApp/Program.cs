// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

string[] commands = { "add", "sub", "mul", "div" };

int Add(int a, int b) => a + b; 
int Sub(int a, int b) => a - b;
int Mul(int a, int b) => a * b; 
int Div(int a, int b) => a / b; 

while (true) 
{
    Console.WriteLine("Enter Command: add, sub, mul div");
    string? command = Console.ReadLine();
    if (commands.Contains(command)) 
    {
        Console.WriteLine("Enter your first value: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter your second value: ");
        int b = int.Parse(Console.ReadLine()!);

        int result = command switch 
        {
            "add" => Add(a, b),
            "sub" => Sub(a, b),
            "mul" => Mul(a, b),
            "div" => Div(a, b),
            _ => throw new InvalidEnumArgumentException()
        };

        Console.WriteLine($"Result: {result}");
    }
    else 
    {
        Console.WriteLine("Unknown command");
    }
}