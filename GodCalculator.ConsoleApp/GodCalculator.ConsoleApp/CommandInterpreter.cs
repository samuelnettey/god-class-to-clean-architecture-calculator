namespace GodCalculator.ConsoleApp;

public class CommandInterpreter
{
    public ArithmeticOperation ParseCommand(string command) =>
        Enum.Parse<ArithmeticOperation>(command, true);
}
