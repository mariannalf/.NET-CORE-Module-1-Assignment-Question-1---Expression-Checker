using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Regular Expression Checker!");
        Console.WriteLine("The default regular expression checks for at least one digit.");

        string defaultRegex = @"\d+";
        string customRegex = "";
        bool useDefaultRegex = true;

        while (true)
        {
            Console.Write("Enter a regular expression (or press ENTER to use the default): ");
            customRegex = Console.ReadLine().Trim();
            if (customRegex == "")
            {
                useDefaultRegex = true;
                customRegex = defaultRegex;
            }
            else
            {
                useDefaultRegex = false;
            }

            Console.Write("Enter some input: ");
            string input = Console.ReadLine();

            bool isMatch = Regex.IsMatch(input, customRegex);

            Console.WriteLine($"{input} matches {customRegex}? {isMatch}");

            Console.WriteLine("Press ESC to end or any key to try again.");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }

            Console.WriteLine();
        }
    }
}
