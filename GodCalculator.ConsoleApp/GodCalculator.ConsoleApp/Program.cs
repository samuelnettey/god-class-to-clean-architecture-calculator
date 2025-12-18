using GodCalculator.ConsoleApp;

var calculatorService = new CalculatorService(
    new Calculator(),
    new CommandInterpreter(),
    new ConsoleOutputService(),
    new UserInputService()
);

calculatorService.Run();
