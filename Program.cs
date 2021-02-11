using System;

namespace FizzBuzzGit
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n=1; n <= 100; n++)
            {
               
                if(n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }

                else if(n % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if(n % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
               
                else
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadLine();

        }
    }
}
