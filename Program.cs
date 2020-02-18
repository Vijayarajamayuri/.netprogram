using System;

namespace ClassActivity01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1******************************

            String str;
            int count = 1, s = 1;


            Console.Write("Input the string : ");
            str = Console.ReadLine();
            while (s <= str.Length - 1)
            {
                if (str[s] == ' ' || str[s] == '\n' || str[s] == '\t')
                {
                    if (str[s + 1] != ' ')
                    {
                        count++;
                    }
                }
                s++;
            }
            Console.WriteLine("Total number of words in a given string  " + str + " is " + count);

            //2****************************************************************
            Console.WriteLine("Enter the input for getting the initials");
            String name = Console.ReadLine();
            String stm = null;                           
            for (int i = 1; i < name.Length - 1; i++)
            {
                if (name.Length == 0 || name[i] == ' ')
                    if(name[i+1]!=' ')
                    {
                        stm = stm + name[i + 1];
                    }

            }
            Console.WriteLine("Initials of the given string is "+name[0]+stm); 

            //3********************************************
            Console.Write(" Input :");
            String RevString = Console.ReadLine();
            String Reverse = " ";
            for (int i = RevString.Length - 1; i > -1; i--)
            {
                Reverse = Reverse + RevString[i];

            }
            Console.WriteLine("The reversal of a given String is " + Reverse);

            //4******************************************
            Console.WriteLine("Enter a number to find the sum of n numbers which are multiples of 5");
            string N = Console.ReadLine();
            int st = Convert.ToInt32(N);
            int n, sum = 0;
            for (n = 1; n <= st; n++)
            {n
                sum = 5 * (n * (n + 1) / 2);

            }

            Console.WriteLine("sum of first " + N + " numbers which are multiples of 5 is " + sum);


            //5***************************************

            int a = 3, b = 4;
            double POWER = Math.Pow(a, b);
            Console.WriteLine("The value of 3^4 is " + POWER);
        }
    }
}
