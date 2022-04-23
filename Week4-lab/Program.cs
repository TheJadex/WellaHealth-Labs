using System;

namespace Week4_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;  
   
            Console.Write("Enter first number: ");  
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            if(result < 100){
                Console.WriteLine("Your answer is less than 100. Therefore, your result is " + (result < 100));
            }
            else{
                Console.WriteLine("Your answer is greater than 100. Therefore, your result is " + (result < 100));
            }
            
        }
    }
}
