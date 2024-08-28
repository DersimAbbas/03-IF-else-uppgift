using System;
using Figgle;

class Program
{
    static void Main(string[] args)
    {
        string password = "cloud24";

        Console.WriteLine("Please type in your password:");

        string userInput = Console.ReadLine();

        string accessGranted = "Access Granted";
        string accessDenied = "Access Denied";

        if (userInput == password)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FiggleFonts.Standard.Render(accessGranted));
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FiggleFonts.Standard.Render(accessDenied));
        }

        // Reset the console color to default
        Console.ResetColor();
    }
}
