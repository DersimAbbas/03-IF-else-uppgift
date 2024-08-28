using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Input a three-digit number from the user
        Console.Write("Enter a three-digit number: ");
        string UserNumber = Console.ReadLine();

        // Validate input: Check if input is a three-digit number
        if (UserNumber.Length != 3 || !int.TryParse(UserNumber, out _))
        {
            Console.WriteLine("Please enter a valid three-digit number.");
            return;
        }

        // Convert the input string into a list of characters (digits)
        List<char> digits = new List<char>(UserNumber.ToCharArray());

        // Initialize variables for the maximum number construction
        string maxNumber = "";

        // Iterate three times to find the largest digit each time
        for (int i = 0; i < 3; i++)
        {
            char maxDigit = '0'; // Start with the smallest possible digit
            int maxIndex = -1;   // Index of the current maximum digit

            // Find the largest digit in the remaining list
            for (int j = 0; j < digits.Count; j++)
            {
                if (digits[j] > maxDigit)
                {
                    maxDigit = digits[j];
                    maxIndex = j;
                }
            }

            // If a valid maxIndex was found, append the largest digit to maxNumber
            if (maxIndex != -1)
            {
                maxNumber += maxDigit;
                digits.RemoveAt(maxIndex); // Remove the used digit from the list
            }
        }

        // Output the maximum number formed by rearranging the digits
        Console.WriteLine("The maximum number from your three digits is:  " + maxNumber);
    }
}

    