class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("please type a number from 1-7 for responding weekday");
         
        int userNumber = int.Parse(Console.ReadLine());

        switch (userNumber)
        {
            case int u when u == 1:
                
                Console.WriteLine("monday");
                
                break;

            case int u when u == 2:

                Console.WriteLine("Tuesday");

                break;

            case int u when u == 3:
                
                Console.WriteLine("Wednesday");

                break;

            case int u when u == 4:
                
                Console.WriteLine("Thursday");
                
                break;

            case int u when u == 5:
                
                Console.WriteLine("Friday");

                break;

            case int u when u == 6:
                
                Console.WriteLine("Saturday");

                break;
            
            case int u when u == 7:
                
                Console.WriteLine("Sunday");
                
                break;

            default:
                
                Console.WriteLine("Error please type valid input.");
                
                break;

        }
    
    
    }
}