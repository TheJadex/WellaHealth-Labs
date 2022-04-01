using System;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //lab1 assignment 1 - Print name & Class
            string myName = "Moyosoreoluwa, ";
            string otherMsg = "I am in backend class of Wella Schools.";

            //lab1 assignment 2 - Reason for learning backend
            string learnBackend = "As a backend developer, I get to understand more " + 
                                  "concept about programming and to put myself on a " +
                                  "front foot ahead when being recuited for job " + 
                                  "and to also develop my own apps and deploy them to the tech market.";


            Console.WriteLine("Hello " + myName + otherMsg);
            Console.WriteLine(""); //serves as a breakline.
            Console.WriteLine(learnBackend);
        }
    }
}
