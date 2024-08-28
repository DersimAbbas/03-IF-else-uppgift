class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What would you like to convert? Fahrenheit(F) to Celsius(C) or (C) to (f)");                      //°C = (°F - 32) × 5/9

        Console.WriteLine("Please type c or f");
        
        string answerF = "f";

        string answerC = "c";

        float CelConvert;
        float Fconvert;

        string userAnswer = Console.ReadLine();

        if (userAnswer == answerC || userAnswer == answerF)
        {
            Console.WriteLine("input your numbers to start calculation");
            float userNum = float.Parse(Console.ReadLine());

            if (userAnswer == answerF)
            {
                CelConvert = (userNum - 32) * 5 / 9;

                Console.WriteLine($"from Fahrenheit to Celsius is: {CelConvert}");
            }
            else
            {
                Fconvert = (userNum * 9 / 5) + 32;

                Console.WriteLine($"here is your conversion in degrees: {Fconvert}");
            }
       
                                                                                                                                  //F = (C * 9/5) + 32
        }                                                                                                             
        else
        {
            Console.WriteLine("error please answer with either c or f");
        }
    
    
    
    }
}
                       