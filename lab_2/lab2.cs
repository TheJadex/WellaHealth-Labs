using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declearing 10 Variable with different datatypes - Assignment A
            string strVar = "WellaHealth!";
            int intVar = 100;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;
            long myNum = 15000000000L;
            double doubleNum = 8.358674532;
            dynamic dyn = 123;
            ulong ul = 3624573;
            ushort us = 76;

            Console.WriteLine("1.  String: " + strVar);
            Console.WriteLine("2.  Integer: " + intVar);
            Console.WriteLine("3.  Float: " + floatVar);
            Console.WriteLine("4.  Char:" + charVar);
            Console.WriteLine("5.  Boolean: " + boolVar);
            Console.WriteLine("6.  Long: " + myNum);
            Console.WriteLine("7.  Double: " + doubleNum);
            Console.WriteLine("8.  Dynamic: " + dyn);
            Console.WriteLine("9.  Unsinged long: " + ul);
            Console.WriteLine("10. Unsinged short: " + us);


            //Showing examples of Implicit and Explicit Conversions - Assignment B
                //Implicit - Conversions declared as 'Implicit' occurs automatically when it is required
            int someInt = 992;
            long biggerInt = someInt;

                //Explicit - Conversions declared as 'Explicit' require a cast to be callled
            int someOtherInt = (int)biggerInt;
            Console.WriteLine(biggerInt);  
            Console.WriteLine(someOtherInt);  
        }
    }
}
