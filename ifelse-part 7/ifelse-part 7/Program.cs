using System.ComponentModel.Design;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("please input your amount of purchases, if its over $1000. You get 10% discount.");
        double discount;
        double total;

        double purchase = double.Parse(Console.ReadLine());

        if (purchase > 1000)
        {

           discount = purchase * 0.1;

            discount = Convert.ToInt32(discount);

            total = purchase - discount;

            Console.WriteLine($"your discount is 10% you saved {discount}, which is applying to your purchase. your new total is {total} ");
        }
        else
        {
            Console.WriteLine($"your purchase is {purchase}");


        }

        
    }
}