using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("please type a number");

        string UserNum = Console.ReadLine(); //jag använder string istället för int för att sen använda tryparse.
        int number;

        if (int.TryParse(UserNum, out number)) // med tryparse så får jag en extra if/else sats, den behövs för att skriva ut error om man skulle använda ett nummer med decimal.
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("your number is even");

            }
            else
            {
                Console.WriteLine("your number is odd");

            }

        }
        else
        {
            Console.WriteLine("invalid input please dont try to destroy my PC with these errors, type a Whole number");
        }

    }
}
