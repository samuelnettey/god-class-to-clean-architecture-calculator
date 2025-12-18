namespace GodCalculator.ConsoleApp;

public class CalculatorService(
    Calculator calculator,
    CommandInterpreter commandInterpreter,
    ConsoleOutputService outputService,
    UserInputService userInputService)
{
    public void Run()
    {
        while (true)
        {
            try
            {
                var command = userInputService.ReadCommand();
                var args = userInputService.ReadArguments();

                var parsedCommand = commandInterpreter.ParseCommand(command);

                var results = calculator.Execute(parsedCommand, args);

                outputService.WriteSuccessMessage($"Result: {results}");
            }
            catch (Exception ex)
            {
                outputService.WriteMessage($"An error occurred: {ex.Message}");
            }
        }
    }
}
