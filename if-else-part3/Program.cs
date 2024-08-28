
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type your number to find out your current grade.");


        int grade = int.Parse(Console.ReadLine());




        switch (grade)
        {

            case int g when g >= 90 && g <= 100:
                Console.WriteLine("your grade is A");

                break;

            case int g when g >= 80 && g <= 89:
                Console.WriteLine("your grade is B");

                break;

            case int g when g >= 70 && g <= 79:
                Console.WriteLine("your grade is C");

                break;
            
            case int g when g >= 60 && g <= 70:
                Console.WriteLine("your grade is D");

                break;

            case int g when g <= 59:
                Console.WriteLine("your grade is F");

                break;

            default:

                Console.WriteLine("error grade not recognized in range");
                    
               break;
            


           
        
        
        
        }
            

      
    }
}