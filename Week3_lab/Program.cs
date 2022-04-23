using System;
 
namespace Week3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to check: ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
 
            int divisor  = 0;
 
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisor ++;
                }
            }
            if (divisor == 2)
            {
                Console.WriteLine("The entered number is a prime number.");
            }
            else
            {
                Console.WriteLine("The entered number is not a prime number.");
            }
            Console.ReadLine();

        }
    }
}