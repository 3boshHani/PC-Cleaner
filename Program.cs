using System;
using Spectre.Console;
using Functions;
class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.ForegroundColor  = ConsoleColor.Magenta;
            Console.Clear();

            // Create and configure the table
            Table table = new();
            table.AddColumn(new TableColumn("Choose: 1 - 2 - 3").Width(30).Centered());
            table.AddRow("1. Start Clean");
            table.AddRow("2. Instagram");
            table.AddRow("3. Close App");

            table.Border = TableBorder.Rounded;
            // Center align the table
            table.Centered();
            AnsiConsole.Write(table);
            AnsiConsole.Write(new Markup("[bold darkviolet]Made by 3Bosh_Hani[/]").Centered());
            ConsoleKeyInfo pressed = Console.ReadKey();
            switch (pressed.Key)
            {
                // the clear
                case ConsoleKey.D1:
                    Function.CleanUp();
                    Console.Clear();
                    AnsiConsole.Write(new Markup("[bold darkviolet] Cleaning Done ! [/]").Centered());
                    AnsiConsole.Write(new Markup(" ").Centered());
                    AnsiConsole.Write(new Markup("[bold darkviolet] Press Any Key To Close ! [/]").Centered());
                    Console.ReadKey();  
                    return;
                    // insta
                case ConsoleKey.D2:
                    Function.OpenLink("https://www.instagram.com/3bosh_hani/");
                    break;
                    // close
                case ConsoleKey.D3:
                    return;  
                default:    
                    Console.WriteLine("Please Press 1 - 2 - 3");
                    break;
            }

        }
    }
}