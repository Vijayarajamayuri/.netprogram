using System;

namespace NumberchangerwithDelegates
{
    class NumberChanger
    {
        static int num = 10;
   static void Main(string[] args)
        {
        
            Console.WriteLine("Hello World!");
            NumChange sum = new NumChange(add);
            sum(20);
            Console.WriteLine(num);
            NumChange diff = new NumChange(sub);//30-10=20
            diff(10);
            Console.WriteLine(num);
            NumChange mult = new NumChange(mul);//30-10=20
            mul(10);
            Console.WriteLine(num);
        }
        public static int add(int n)
        {
            num = num + n;
            return num;
        }
        public static int sub(int n)
        {
            num = num - n;
            return num;
        }
        public static int mul(int n)
        {
            num = num * n;
            return num;
        }
        public delegate int NumChange(int value);

    }
}
