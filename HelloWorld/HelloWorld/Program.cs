using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "mayuri";
            string name1 = "Ray";
            Console.WriteLine(name);
          
            Console.WriteLine($"hi my name is {name}{name1}");
            Console.WriteLine($"The name {name} has {name.Length} letters.");
            Console.WriteLine($"The name {name1} has {name1.Length} letters.");

            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            /*numbers*/
        
     /*
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            Console.WriteLine(b);*/
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine(max + 1);
            Console.WriteLine(min - 1);
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);




            Console.WriteLine($"The range of integers is {min} to {max}");

        }
    }
}
