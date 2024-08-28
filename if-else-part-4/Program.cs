using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type in a year");
        
        int Usernum = Int32.Parse(Console.ReadLine());

        if (Usernum % 4 == 0)
        {
            Console.WriteLine($"{Usernum} is a leap year.");

        }
        else
        {
            Console.WriteLine($"{Usernum} is not a leap year");
        }
        


    }
}