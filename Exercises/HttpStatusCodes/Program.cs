using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;

ConsoleApplication.Run();

public class ConsoleApplication
{

    public static void Run()
    {

        System.Console.Write("Enter a Response Code: ");
        int input = int.Parse(Console.ReadLine());

        if (input >= 100 && input <= 199)
        {
            if (input == 104)
            {
                System.Console.WriteLine($"{input} is not a valid Response.");
            }
            else
            {
                System.Console.WriteLine($"{input} is an Informational Response.");
            }
        }
        else if (input >= 200 && input <= 299)
        {
            if (input == 207)
            {
                System.Console.WriteLine($"{input} is not a valid Response.");
            }
            else
            {
                System.Console.Write($"{input} is a Successful Response.");
            }
        }
        else if (input >= 300 && input <= 399)
        {
            if (input == 305 || input == 309)
            {
                System.Console.WriteLine($"{input} is not a valid Response.");
            }
            else
            {
                System.Console.WriteLine($"{input} is a Redirection Response.");
            }
        }
        else if (input >= 400 && input <= 499)
        {
            switch (input)
            {
                case 427:
                case 421:
                case 432:
                case 452:
                case 420:
                case 419:
                case 430:
                case 424:
                case 423:
                    System.Console.WriteLine($"{input} is not a valid Response.");
                    break;
                default:
                    System.Console.WriteLine($"{input} is a Client Error Response.");
                    break;
            }
        }
        else if (input >= 500 && input <= 599)
        {
            if (input == 509 || input == 512)
            {
                System.Console.WriteLine($"{input} is not a valid Response.");
            }
            else
            {
                System.Console.WriteLine($"{input} is a Server Error Response.");
            }
        }
        else
        {
            System.Console.WriteLine($"{input} is not a valid Response.");
        }
    }
}

