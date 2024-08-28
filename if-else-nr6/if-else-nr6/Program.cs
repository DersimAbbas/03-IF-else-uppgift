class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("please type any number, can be positive or negative or even zero.");

        float UserNum = float.Parse(Console.ReadLine());

        if (UserNum < 0)
        {


            Console.WriteLine($"your number {UserNum} is negative");


        }
        else if (UserNum > 0)
        {
            Console.WriteLine($"your number {UserNum} is Positive");
        }
        else
        {
            Console.WriteLine("your number is 0");
        }

        
    }
} 