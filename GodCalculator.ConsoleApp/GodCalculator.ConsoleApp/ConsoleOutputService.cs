namespace GodCalculator.ConsoleApp;

using Spectre.Console;

public class ConsoleOutputService
{
    public void WriteMessage(string message) => Console.WriteLine(message);

    public void WriteSuccessMessage(string message) 
    {
        var panel = new Panel($"[bold yellow]{message}[/]")
        {
            Header = new PanelHeader("[green]✓ Success[/]", Justify.Center),
            Border = BoxBorder.Double,
            BorderStyle = new Style(Color.Green),
            Padding = new Padding(2, 1)
        };
        AnsiConsole.Write(panel);
        AnsiConsole.WriteLine();
    }
}
