using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int age;

        Console.WriteLine("whats your age?");

        string UserAge = Console.ReadLine();

        if (int.TryParse(UserAge, out age))
        {
            if (age < 13)
            {
                Console.WriteLine("you are a child.");
            }
            else if (age <= 19)
            {
                Console.WriteLine("you are a teenager!");
            }
            else
            {
                Console.WriteLine("you are an adult.");
            }
        }
        else
        {
            Console.WriteLine("invalid input please type a whole number");
        }
    }
}
