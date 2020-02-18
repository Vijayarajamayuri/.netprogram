using System;

namespace sampleDelegate01
{
    class sampleDel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // printMoney(20)
            printDel pTime = new printDel(printTime);//pass a function to a delegate
            pTime(200);
            printDel pMoney = new printDel(printMoney);
            pMoney(300);
        }
        public static void printTime(int time)
        {
            Console.WriteLine("Time in seconds:" + time);

        }
        public static void printMoney(int money)
        {
            Console.WriteLine("Money I  recieved $" + money);
            
        }
        public delegate void printDel(int value);//type safe=same value 

    }
}
