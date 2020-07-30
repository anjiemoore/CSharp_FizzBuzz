using System;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print numbers from 1-00
            for (int i = 0; i <= 100; i++)
            {
                string results = "";

                //If number is divisible by 3 print "Fizz"

                if (i % 3 == 0) results = "Fizz";
                //If number is divisible by 5 print "Buzz"
                //If number is divisible by both 3 and 5 print "Fizz Buzz"

                if (i % 5 == 0) results = results + "Buzz";

                //If number is neither divisible by 3 or 5 print number
                if (results.Length == 0) results = i.ToString();
                Console.WriteLine(results);
                Console.ReadKey();

            }

            //Alternative way
            //For loop should start at 1 and not 0
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
