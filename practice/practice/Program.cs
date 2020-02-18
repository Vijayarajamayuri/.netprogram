using System;
using System.Collections.Generic;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var names=new List<string>{ "mayuri","sindhu"};
            foreach(var name in names)
            {
                Console.WriteLine("hello  "+name.ToUpper());
            }

            Console.WriteLine("Hello World!");
        }
    }
}
