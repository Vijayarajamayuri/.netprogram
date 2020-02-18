using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter the full name :");
                String name = Console.ReadLine();

                if (string.IsNullOrEmpty(name)) 
                {
                    Console.WriteLine("sorry, Please enter your name?");

                }

            }
    }
    }
}
