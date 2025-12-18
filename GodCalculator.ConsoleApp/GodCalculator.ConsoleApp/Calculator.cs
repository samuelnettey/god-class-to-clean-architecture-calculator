namespace GodCalculator.ConsoleApp;

public class Calculator
{
    public int Execute(ArithmeticOperation opearation, CalculatorArguments args) => opearation switch
    {
        ArithmeticOperation.Add => args.A + args.B,
        ArithmeticOperation.Sub => args.A - args.B,
        ArithmeticOperation.Mul => args.A * args.B,
        ArithmeticOperation.Div => args.A / args.B,
        _ => throw new InvalidOperationException("Unknown operation")
    };
}
